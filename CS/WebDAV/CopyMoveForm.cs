using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WebDAV
{
	/// <summary>
	/// Summary description for CopyMoveForm.
	/// </summary>
	public class CopyMoveForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;

		public System.Windows.Forms.TextBox edtSource;
		public System.Windows.Forms.TextBox edtDestination;
		public System.Windows.Forms.CheckBox cbIsMove;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CopyMoveForm()
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
			this.label2 = new System.Windows.Forms.Label();
			this.edtSource = new System.Windows.Forms.TextBox();
			this.edtDestination = new System.Windows.Forms.TextBox();
			this.cbIsMove = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Destination";
			// 
			// edtSource
			// 
			this.edtSource.Location = new System.Drawing.Point(88, 16);
			this.edtSource.Name = "edtSource";
			this.edtSource.ReadOnly = true;
			this.edtSource.Size = new System.Drawing.Size(312, 20);
			this.edtSource.TabIndex = 2;
			// 
			// edtDestination
			// 
			this.edtDestination.Location = new System.Drawing.Point(88, 40);
			this.edtDestination.Name = "edtDestination";
			this.edtDestination.Size = new System.Drawing.Size(312, 20);
			this.edtDestination.TabIndex = 3;
			// 
			// cbIsMove
			// 
			this.cbIsMove.Location = new System.Drawing.Point(88, 72);
			this.cbIsMove.Name = "cbIsMove";
			this.cbIsMove.Size = new System.Drawing.Size(136, 24);
			this.cbIsMove.TabIndex = 4;
			this.cbIsMove.Text = "Is Move Resource";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(208, 96);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "OK";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(296, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Cancel";
			// 
			// CopyMoveForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(416, 136);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbIsMove);
			this.Controls.Add(this.edtDestination);
			this.Controls.Add(this.edtSource);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CopyMoveForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Copy / Move Resource";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
	}
}
