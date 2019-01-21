using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WebDAV
{
	/// <summary>
	/// Summary description for ModifyPropForm.
	/// </summary>
	public class ModifyPropForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;

		public System.Windows.Forms.Label lblResource;
		public System.Windows.Forms.TextBox edtName;
		public System.Windows.Forms.TextBox edtValue;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ModifyPropForm()
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
			this.lblResource = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.edtName = new System.Windows.Forms.TextBox();
			this.edtValue = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblResource
			// 
			this.lblResource.Location = new System.Drawing.Point(16, 8);
			this.lblResource.Name = "lblResource";
			this.lblResource.Size = new System.Drawing.Size(288, 23);
			this.lblResource.TabIndex = 0;
			this.lblResource.Text = "lblResource";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Property Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "New value";
			// 
			// edtName
			// 
			this.edtName.Location = new System.Drawing.Point(104, 40);
			this.edtName.Name = "edtName";
			this.edtName.Size = new System.Drawing.Size(200, 20);
			this.edtName.TabIndex = 3;
			this.edtName.Text = "author";
			// 
			// edtValue
			// 
			this.edtValue.Location = new System.Drawing.Point(104, 64);
			this.edtValue.Name = "edtValue";
			this.edtValue.Size = new System.Drawing.Size(200, 20);
			this.edtValue.TabIndex = 4;
			this.edtValue.Text = "J.J. Johnson";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
			this.button1.Location = new System.Drawing.Point(32, 96);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "Set";
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
			this.button2.Location = new System.Drawing.Point(128, 96);
			this.button2.Name = "button2";
			this.button2.TabIndex = 6;
			this.button2.Text = "Remove";
			// 
			// button3
			// 
			this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button3.Location = new System.Drawing.Point(224, 96);
			this.button3.Name = "button3";
			this.button3.TabIndex = 7;
			this.button3.Text = "Cancel";
			// 
			// ModifyPropForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 134);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edtValue);
			this.Controls.Add(this.edtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblResource);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ModifyPropForm";
			this.Text = "Change / Remove Property";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
