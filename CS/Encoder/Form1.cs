using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace Encoder
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnEncode;
		private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.Button btnEncodeFile;
		private System.Windows.Forms.Button btnDecodeFile;
		private System.Windows.Forms.TextBox edtSource;
		private System.Windows.Forms.TextBox edtDestination;
		private System.Windows.Forms.ComboBox cbEncoding;
		private System.Windows.Forms.ComboBox cbEncodingFile;
		private System.Windows.Forms.TextBox edtSourceFile;
		private System.Windows.Forms.TextBox edtDestinationFile;
		private CleverComponents.InetSuite.Encoder encoder1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			cbEncoding.SelectedIndex = 1;
			cbEncodingFile.SelectedIndex = 1;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.edtSource = new System.Windows.Forms.TextBox();
			this.edtDestination = new System.Windows.Forms.TextBox();
			this.cbEncoding = new System.Windows.Forms.ComboBox();
			this.btnEncode = new System.Windows.Forms.Button();
			this.btnDecode = new System.Windows.Forms.Button();
			this.edtSourceFile = new System.Windows.Forms.TextBox();
			this.edtDestinationFile = new System.Windows.Forms.TextBox();
			this.cbEncodingFile = new System.Windows.Forms.ComboBox();
			this.btnEncodeFile = new System.Windows.Forms.Button();
			this.btnDecodeFile = new System.Windows.Forms.Button();
			this.encoder1 = new CleverComponents.InetSuite.Encoder();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "This demo demonstrates how to decode / encode a file using the base64, UUE or Quo" +
				"tedPrintable encoding formats.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Please select the source and destination files, the required encoding format and " +
				"press the Encode or Decode buttons.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Source String";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Result String";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "Encoding Format";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(16, 224);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 1);
			this.panel1.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 240);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 6;
			this.label6.Text = "Source File";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 264);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 7;
			this.label7.Text = "Destination File";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 296);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Encoding Format";
			// 
			// edtSource
			// 
			this.edtSource.Location = new System.Drawing.Point(120, 104);
			this.edtSource.Name = "edtSource";
			this.edtSource.Size = new System.Drawing.Size(296, 20);
			this.edtSource.TabIndex = 9;
			this.edtSource.Text = "sample text to encode";
			// 
			// edtDestination
			// 
			this.edtDestination.Location = new System.Drawing.Point(120, 128);
			this.edtDestination.Name = "edtDestination";
			this.edtDestination.ReadOnly = true;
			this.edtDestination.Size = new System.Drawing.Size(296, 20);
			this.edtDestination.TabIndex = 10;
			this.edtDestination.Text = "";
			// 
			// cbEncoding
			// 
			this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEncoding.Items.AddRange(new object[] {
															"Quoted Printable",
															"Base 64",
															"UUE"});
			this.cbEncoding.Location = new System.Drawing.Point(120, 160);
			this.cbEncoding.Name = "cbEncoding";
			this.cbEncoding.Size = new System.Drawing.Size(152, 21);
			this.cbEncoding.TabIndex = 11;
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(120, 192);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.TabIndex = 12;
			this.btnEncode.Text = "Encode";
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// btnDecode
			// 
			this.btnDecode.Location = new System.Drawing.Point(224, 192);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.TabIndex = 13;
			this.btnDecode.Text = "Decode";
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// edtSourceFile
			// 
			this.edtSourceFile.Location = new System.Drawing.Point(120, 240);
			this.edtSourceFile.Name = "edtSourceFile";
			this.edtSourceFile.Size = new System.Drawing.Size(296, 20);
			this.edtSourceFile.TabIndex = 14;
			this.edtSourceFile.Text = "image001.jpg";
			// 
			// edtDestinationFile
			// 
			this.edtDestinationFile.Location = new System.Drawing.Point(120, 264);
			this.edtDestinationFile.Name = "edtDestinationFile";
			this.edtDestinationFile.Size = new System.Drawing.Size(296, 20);
			this.edtDestinationFile.TabIndex = 15;
			this.edtDestinationFile.Text = "image001_encoded.txt";
			// 
			// cbEncodingFile
			// 
			this.cbEncodingFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEncodingFile.Items.AddRange(new object[] {
																"Quoted Printable",
																"Base 64",
																"UUE"});
			this.cbEncodingFile.Location = new System.Drawing.Point(120, 296);
			this.cbEncodingFile.Name = "cbEncodingFile";
			this.cbEncodingFile.Size = new System.Drawing.Size(152, 21);
			this.cbEncodingFile.TabIndex = 16;
			// 
			// btnEncodeFile
			// 
			this.btnEncodeFile.Location = new System.Drawing.Point(120, 328);
			this.btnEncodeFile.Name = "btnEncodeFile";
			this.btnEncodeFile.TabIndex = 17;
			this.btnEncodeFile.Text = "Encode";
			this.btnEncodeFile.Click += new System.EventHandler(this.btnEncodeFile_Click);
			// 
			// btnDecodeFile
			// 
			this.btnDecodeFile.Location = new System.Drawing.Point(224, 328);
			this.btnDecodeFile.Name = "btnDecodeFile";
			this.btnDecodeFile.TabIndex = 18;
			this.btnDecodeFile.Text = "Decode";
			this.btnDecodeFile.Click += new System.EventHandler(this.btnDecodeFile_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(440, 366);
			this.Controls.Add(this.btnDecodeFile);
			this.Controls.Add(this.btnEncodeFile);
			this.Controls.Add(this.cbEncodingFile);
			this.Controls.Add(this.edtDestinationFile);
			this.Controls.Add(this.edtSourceFile);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.btnEncode);
			this.Controls.Add(this.cbEncoding);
			this.Controls.Add(this.edtDestination);
			this.Controls.Add(this.edtSource);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnEncode_Click(object sender, System.EventArgs e) {
			encoder1.EncodeMethod = (EncodeMethod)(cbEncoding.SelectedIndex + 1);
			edtDestination.Text = encoder1.Encode(edtSource.Text);
		}

		private void btnDecode_Click(object sender, System.EventArgs e) {
			encoder1.EncodeMethod = (EncodeMethod)(cbEncoding.SelectedIndex + 1);
			edtDestination.Text = encoder1.Decode(edtSource.Text);
		}

		private void btnEncodeFile_Click(object sender, System.EventArgs e) {
			using(FileStream source = new FileStream(edtSourceFile.Text, FileMode.Open, FileAccess.Read)) {
				using(FileStream dest = new FileStream(edtDestinationFile.Text, FileMode.Create)) {
					try {
						encoder1.EncodeMethod = (EncodeMethod)(cbEncodingFile.SelectedIndex + 1);
						encoder1.Encode(source, dest);
						MessageBox.Show("Done");
					}
					catch (Exception ex) {
						MessageBox.Show(ex.Message);
					}
				}
			}
		}

		private void btnDecodeFile_Click(object sender, System.EventArgs e) {
			using(FileStream source = new FileStream(edtSourceFile.Text, FileMode.Open, FileAccess.Read)) {
				using(FileStream dest = new FileStream(edtDestinationFile.Text, FileMode.Create)) {
					try {
						encoder1.EncodeMethod = (EncodeMethod)(cbEncodingFile.SelectedIndex + 1);
						encoder1.Decode(source, dest);
						MessageBox.Show("Done");
					}
					catch (Exception ex) {
						MessageBox.Show(ex.Message);
					}
				}
			}
		}
	}
}
