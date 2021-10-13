using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CleverComponents.InetSuite;

namespace Encoder
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			cbEncoding.SelectedIndex = 1;
			cbEncodingFile.SelectedIndex = 1;
		}

		private void btnEncode_Click(object sender, System.EventArgs e)
		{
			encoder1.EncodeMethod = (EncodeMethod)(cbEncoding.SelectedIndex + 1);
			edtDestination.Text = encoder1.Encode(edtSource.Text);
		}

		private void btnDecode_Click(object sender, System.EventArgs e)
		{
			encoder1.EncodeMethod = (EncodeMethod)(cbEncoding.SelectedIndex + 1);
			edtDestination.Text = encoder1.Decode(edtSource.Text);
		}

		private void btnEncodeFile_Click(object sender, System.EventArgs e)
		{
			using (FileStream source = new FileStream(edtSourceFile.Text, FileMode.Open, FileAccess.Read))
			{
				using (FileStream dest = new FileStream(edtDestinationFile.Text, FileMode.Create))
				{
					try
					{
						encoder1.EncodeMethod = (EncodeMethod)(cbEncodingFile.SelectedIndex + 1);
						encoder1.Encode(source, dest);
						MessageBox.Show("Done");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		private void btnDecodeFile_Click(object sender, System.EventArgs e)
		{
			using (FileStream source = new FileStream(edtSourceFile.Text, FileMode.Open, FileAccess.Read))
			{
				using (FileStream dest = new FileStream(edtDestinationFile.Text, FileMode.Create))
				{
					try
					{
						encoder1.EncodeMethod = (EncodeMethod)(cbEncodingFile.SelectedIndex + 1);
						encoder1.Decode(source, dest);
						MessageBox.Show("Done");
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
			}
		}
	}
}
