using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace HttpClientSSL
{
	/// <summary>
	/// Summary description for certfrm.
	/// </summary>
	public class CertForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		public System.Windows.Forms.TextBox edtName;
		public System.Windows.Forms.TextBox edtIssuedTo;
		public System.Windows.Forms.TextBox edtIssuedBy;
		public System.Windows.Forms.TextBox edtValidFrom;
		public System.Windows.Forms.TextBox edtValidTo;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CertForm()
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
				if(components != null)
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
			this.edtName = new System.Windows.Forms.TextBox();
			this.edtIssuedTo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtIssuedBy = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtValidFrom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtValidTo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Friendly Name";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(96, 16);
			this.edtName.Name = "edtName";
			this.edtName.ReadOnly = true;
			this.edtName.Size = new System.Drawing.Size(256, 20);
			this.edtName.TabIndex = 1;
			this.edtName.Text = "";
			// 
			// edtIssuedTo
			// 
			this.edtIssuedTo.Location = new System.Drawing.Point(96, 48);
			this.edtIssuedTo.Name = "edtIssuedTo";
			this.edtIssuedTo.ReadOnly = true;
			this.edtIssuedTo.Size = new System.Drawing.Size(256, 20);
			this.edtIssuedTo.TabIndex = 3;
			this.edtIssuedTo.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Issued To";
			// 
			// edtIssuedBy
			// 
			this.edtIssuedBy.Location = new System.Drawing.Point(96, 80);
			this.edtIssuedBy.Name = "edtIssuedBy";
			this.edtIssuedBy.ReadOnly = true;
			this.edtIssuedBy.Size = new System.Drawing.Size(256, 20);
			this.edtIssuedBy.TabIndex = 5;
			this.edtIssuedBy.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Issued By";
			// 
			// edtValidFrom
			// 
			this.edtValidFrom.Location = new System.Drawing.Point(96, 112);
			this.edtValidFrom.Name = "edtValidFrom";
			this.edtValidFrom.ReadOnly = true;
			this.edtValidFrom.Size = new System.Drawing.Size(256, 20);
			this.edtValidFrom.TabIndex = 7;
			this.edtValidFrom.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Valid From";
			// 
			// edtValidTo
			// 
			this.edtValidTo.Location = new System.Drawing.Point(96, 144);
			this.edtValidTo.Name = "edtValidTo";
			this.edtValidTo.ReadOnly = true;
			this.edtValidTo.Size = new System.Drawing.Size(256, 20);
			this.edtValidTo.TabIndex = 9;
			this.edtValidTo.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Valid To";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button1.Location = new System.Drawing.Point(32, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Install && Continue";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button2.Location = new System.Drawing.Point(176, 184);
			this.button2.Name = "button2";
			this.button2.TabIndex = 11;
			this.button2.Text = "Continue";
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(272, 184);
			this.button3.Name = "button3";
			this.button3.TabIndex = 12;
			this.button3.Text = "Cancel";
			// 
			// certfrm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(376, 230);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edtValidTo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtValidFrom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtIssuedBy);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtIssuedTo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "certfrm";
			this.Text = "View / Install certificate";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
