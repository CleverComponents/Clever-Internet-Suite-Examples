using System;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace GZipDeflate
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
		private System.Windows.Forms.TextBox edtSource;
		private System.Windows.Forms.Button btnSource;
		private System.Windows.Forms.Button btnDestination;
		private System.Windows.Forms.TextBox edtDestination;
		private System.Windows.Forms.Button btnCompress;
		private System.Windows.Forms.Button btnUncompress;
		private System.Windows.Forms.ProgressBar progressBar1;
		private CleverComponents.InetSuite.GZip gZip1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
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
			this.edtSource = new System.Windows.Forms.TextBox();
			this.btnSource = new System.Windows.Forms.Button();
			this.btnDestination = new System.Windows.Forms.Button();
			this.edtDestination = new System.Windows.Forms.TextBox();
			this.btnCompress = new System.Windows.Forms.Button();
			this.btnUncompress = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.gZip1 = new CleverComponents.InetSuite.GZip();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(360, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "This sample demonstrates using the TclGZip component for deflating / inflating da" +
    "ta stream.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(360, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "The deflated file is not compatible with WinZip file format since it does not con" +
    "tain the description header.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Source File";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Destination File";
			// 
			// edtSource
			// 
			this.edtSource.Location = new System.Drawing.Point(104, 112);
			this.edtSource.Name = "edtSource";
			this.edtSource.Size = new System.Drawing.Size(240, 20);
			this.edtSource.TabIndex = 4;
			// 
			// btnSource
			// 
			this.btnSource.Location = new System.Drawing.Point(352, 112);
			this.btnSource.Name = "btnSource";
			this.btnSource.Size = new System.Drawing.Size(24, 23);
			this.btnSource.TabIndex = 5;
			this.btnSource.Text = "...";
			this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
			// 
			// btnDestination
			// 
			this.btnDestination.Location = new System.Drawing.Point(352, 144);
			this.btnDestination.Name = "btnDestination";
			this.btnDestination.Size = new System.Drawing.Size(24, 23);
			this.btnDestination.TabIndex = 7;
			this.btnDestination.Text = "...";
			this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
			// 
			// edtDestination
			// 
			this.edtDestination.Location = new System.Drawing.Point(104, 144);
			this.edtDestination.Name = "edtDestination";
			this.edtDestination.Size = new System.Drawing.Size(240, 20);
			this.edtDestination.TabIndex = 6;
			// 
			// btnCompress
			// 
			this.btnCompress.Location = new System.Drawing.Point(64, 184);
			this.btnCompress.Name = "btnCompress";
			this.btnCompress.Size = new System.Drawing.Size(112, 23);
			this.btnCompress.TabIndex = 8;
			this.btnCompress.Text = "Compress File";
			this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
			// 
			// btnUncompress
			// 
			this.btnUncompress.Location = new System.Drawing.Point(232, 184);
			this.btnUncompress.Name = "btnUncompress";
			this.btnUncompress.Size = new System.Drawing.Size(112, 23);
			this.btnUncompress.TabIndex = 9;
			this.btnUncompress.Text = "Uncompress File";
			this.btnUncompress.Click += new System.EventHandler(this.btnUncompress_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(0, 240);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(400, 16);
			this.progressBar1.Step = 1;
			this.progressBar1.TabIndex = 10;
			// 
			// gZip1
			// 
			this.gZip1.Progress += new CleverComponents.InetSuite.ProgressEventHandler(this.gZip1_Progress);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(402, 256);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btnUncompress);
			this.Controls.Add(this.btnCompress);
			this.Controls.Add(this.btnDestination);
			this.Controls.Add(this.edtDestination);
			this.Controls.Add(this.btnSource);
			this.Controls.Add(this.edtSource);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GZip / Deflate";
			this.ResumeLayout(false);
			this.PerformLayout();

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

		private void btnSource_Click(object sender, System.EventArgs e) {
			if(openFileDialog1.ShowDialog() == DialogResult.OK) {
				edtSource.Text = openFileDialog1.FileName;
			}
		}

		private void btnDestination_Click(object sender, System.EventArgs e) {
			if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
				edtDestination.Text = saveFileDialog1.FileName;
			}
		}

		private void btnCompress_Click(object sender, System.EventArgs e) {
			progressBar1.Maximum = 100;
			progressBar1.Value = 0;
			gZip1.Compress(edtSource.Text, edtDestination.Text);
			MessageBox.Show(String.Format("The file {0} was deflated and stored to {1}",
				edtSource.Text, edtDestination.Text));
		}

		private void btnUncompress_Click(object sender, System.EventArgs e) {
			progressBar1.Maximum = 100;
			progressBar1.Value = 0;
			using(Stream source = new FileStream(edtSource.Text, FileMode.Open, FileAccess.Read)) {
				using(Stream dest = new FileStream(edtDestination.Text, FileMode.CreateNew)) {
					gZip1.Uncompress(source, dest);
				}
			}

			MessageBox.Show(String.Format("The file {0} was inflated and stored to {1}",
				edtSource.Text, edtDestination.Text));
		}

		private void gZip1_Progress(object sender, CleverComponents.InetSuite.ProgressEventArgs e) {
			progressBar1.Maximum = (int)e.TotalBytes;
			progressBar1.Value = (int)e.BytesProceed;
		}

	}
}
