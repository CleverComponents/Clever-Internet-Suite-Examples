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

namespace DkimVerify {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btnCheckMail_Click(object sender, EventArgs e) {
			if (pop3.Active) return;

			pop3.Server = edtServer.Text;
			pop3.Port = Convert.ToInt32(edtPort.Text);
			pop3.UserName = edtUser.Text;
			pop3.Password = edtPassword.Text;

			lbMessages.Items.Clear();

			pop3.Open();
			try {
				for (int i = 1; i <= pop3.MessageCount; i++) {
					string result = "( NO DKIM ) ";

					try {
						pop3.Retrieve(i);

						if (mailMessage1.Dkim.Signatures.Count > 0) {
							result = "( DKIM OK ) ";
						}
					}
					catch (CryptError) {
						result = "( DKIM FAIL ) ";
					}
					catch (DkimError) {
						result = "( DKIM FAIL ) ";
					}

					lbMessages.Items.Add(result + mailMessage1.Subject);
				}
			}
			finally {
				pop3.Close();
			}

			MessageBox.Show("Done");
		}
	}
}
