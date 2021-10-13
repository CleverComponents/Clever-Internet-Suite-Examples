
namespace Encoder
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnDecodeFile = new System.Windows.Forms.Button();
			this.btnEncodeFile = new System.Windows.Forms.Button();
			this.cbEncodingFile = new System.Windows.Forms.ComboBox();
			this.edtDestinationFile = new System.Windows.Forms.TextBox();
			this.edtSourceFile = new System.Windows.Forms.TextBox();
			this.btnDecode = new System.Windows.Forms.Button();
			this.btnEncode = new System.Windows.Forms.Button();
			this.cbEncoding = new System.Windows.Forms.ComboBox();
			this.edtDestination = new System.Windows.Forms.TextBox();
			this.edtSource = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.encoder1 = new CleverComponents.InetSuite.Encoder();
			this.SuspendLayout();
			// 
			// btnDecodeFile
			// 
			this.btnDecodeFile.Location = new System.Drawing.Point(230, 334);
			this.btnDecodeFile.Name = "btnDecodeFile";
			this.btnDecodeFile.Size = new System.Drawing.Size(75, 23);
			this.btnDecodeFile.TabIndex = 37;
			this.btnDecodeFile.Text = "Decode";
			this.btnDecodeFile.Click += new System.EventHandler(this.btnDecodeFile_Click);
			// 
			// btnEncodeFile
			// 
			this.btnEncodeFile.Location = new System.Drawing.Point(126, 334);
			this.btnEncodeFile.Name = "btnEncodeFile";
			this.btnEncodeFile.Size = new System.Drawing.Size(75, 23);
			this.btnEncodeFile.TabIndex = 36;
			this.btnEncodeFile.Text = "Encode";
			this.btnEncodeFile.Click += new System.EventHandler(this.btnEncodeFile_Click);
			// 
			// cbEncodingFile
			// 
			this.cbEncodingFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEncodingFile.Items.AddRange(new object[] {
            "Quoted Printable",
            "Base 64",
            "UUE"});
			this.cbEncodingFile.Location = new System.Drawing.Point(126, 302);
			this.cbEncodingFile.Name = "cbEncodingFile";
			this.cbEncodingFile.Size = new System.Drawing.Size(152, 21);
			this.cbEncodingFile.TabIndex = 35;
			// 
			// edtDestinationFile
			// 
			this.edtDestinationFile.Location = new System.Drawing.Point(126, 270);
			this.edtDestinationFile.Name = "edtDestinationFile";
			this.edtDestinationFile.Size = new System.Drawing.Size(296, 20);
			this.edtDestinationFile.TabIndex = 34;
			this.edtDestinationFile.Text = "image001_encoded.txt";
			// 
			// edtSourceFile
			// 
			this.edtSourceFile.Location = new System.Drawing.Point(126, 246);
			this.edtSourceFile.Name = "edtSourceFile";
			this.edtSourceFile.Size = new System.Drawing.Size(296, 20);
			this.edtSourceFile.TabIndex = 33;
			this.edtSourceFile.Text = "..\\..\\image001.jpg";
			// 
			// btnDecode
			// 
			this.btnDecode.Location = new System.Drawing.Point(230, 198);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.Size = new System.Drawing.Size(75, 23);
			this.btnDecode.TabIndex = 32;
			this.btnDecode.Text = "Decode";
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(126, 198);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(75, 23);
			this.btnEncode.TabIndex = 31;
			this.btnEncode.Text = "Encode";
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// cbEncoding
			// 
			this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEncoding.Items.AddRange(new object[] {
            "Quoted Printable",
            "Base 64",
            "UUE"});
			this.cbEncoding.Location = new System.Drawing.Point(126, 166);
			this.cbEncoding.Name = "cbEncoding";
			this.cbEncoding.Size = new System.Drawing.Size(152, 21);
			this.cbEncoding.TabIndex = 30;
			// 
			// edtDestination
			// 
			this.edtDestination.Location = new System.Drawing.Point(126, 134);
			this.edtDestination.Name = "edtDestination";
			this.edtDestination.ReadOnly = true;
			this.edtDestination.Size = new System.Drawing.Size(296, 20);
			this.edtDestination.TabIndex = 29;
			// 
			// edtSource
			// 
			this.edtSource.Location = new System.Drawing.Point(126, 110);
			this.edtSource.Name = "edtSource";
			this.edtSource.Size = new System.Drawing.Size(296, 20);
			this.edtSource.TabIndex = 28;
			this.edtSource.Text = "sample text to encode";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(22, 302);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 16);
			this.label8.TabIndex = 27;
			this.label8.Text = "Encoding Format";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(22, 270);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "Destination File";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 246);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 16);
			this.label6.TabIndex = 25;
			this.label6.Text = "Source File";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(22, 230);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 1);
			this.panel1.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(22, 166);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Encoding Format";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Result String";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(22, 110);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 21;
			this.label3.Text = "Source String";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 32);
			this.label2.TabIndex = 20;
			this.label2.Text = "Please select the source and destination files, the required encoding format and " +
    "press the Encode or Decode buttons.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(408, 32);
			this.label1.TabIndex = 19;
			this.label1.Text = "This demo demonstrates how to decode / encode a file using the base64, UUE or Quo" +
    "tedPrintable encoding formats.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 371);
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
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MIME Encoder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDecodeFile;
		private System.Windows.Forms.Button btnEncodeFile;
		private System.Windows.Forms.ComboBox cbEncodingFile;
		private System.Windows.Forms.TextBox edtDestinationFile;
		private System.Windows.Forms.TextBox edtSourceFile;
		private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.Button btnEncode;
		private System.Windows.Forms.ComboBox cbEncoding;
		private System.Windows.Forms.TextBox edtDestination;
		private System.Windows.Forms.TextBox edtSource;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private CleverComponents.InetSuite.Encoder encoder1;
	}
}

