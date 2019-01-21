using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using CleverComponents.InetSuite;

namespace DkimSign {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				dkim1.ImportPrivateKey(openFileDialog1.FileName);
				using (StreamReader reader = File.OpenText(openFileDialog1.FileName)) {
					mmPrivateKey.Text = reader.ReadToEnd();
				}
				edtDnsTxtName.Text = "";
				edtDnsTxtValue.Text = "";
			}
		}

		private void Form1_Shown(object sender, EventArgs e) {
			edtSignFields.Text = String.Join(",", dkim1.SignedHeaderFields);
		}

		private void btnGenerate_Click(object sender, EventArgs e) {
			dkim1.Domain = edtDkimDomain.Text;
			dkim1.Selector = edtDkimSelector.Text;

			dkim1.GenerateSigningKey(512);

			StringCollectionEx list = new StringCollectionEx();
			dkim1.ExportPrivateKey(list);
			mmPrivateKey.Lines = list.ToArray();

			dkim1.GenerateDnsRecord();

			edtDnsTxtName.Text = dkim1.DnsRecord.Name;
			edtDnsTxtValue.Text = dkim1.DnsRecord.Value;
		}

		private void btnSend_Click(object sender, EventArgs e) {
			if (smtp1.Active) return;

			dkim1.Domain = edtDkimDomain.Text;
			dkim1.Selector = edtDkimSelector.Text;
			dkim1.SignedHeaderFields = StringUtils.GetStringArray(edtSignFields.Text, ',');

			dkim1.ImportPrivateKey(mmPrivateKey.Lines);

			mailMessage1.BuildMessage(mmBody.Text, "");
			mailMessage1.From.FullAddress = edtFrom.Text;
			mailMessage1.ToList.EmailAddresses = edtTo.Text;
			mailMessage1.Subject = edtSubject.Text;

			smtp1.Server = edtServer.Text;
			smtp1.Port = Convert.ToInt32(edtPort.Text);

			smtp1.UserName = edtUser.Text;
			smtp1.Password = edtPassword.Text;

			smtp1.Open();
			try {
				smtp1.Send(mailMessage1);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			finally {
				smtp1.Close();
			}

			MessageBox.Show("The signed message was sent successfully.");
		}
	}
}
