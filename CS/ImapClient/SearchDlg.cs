using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ImapClient
{
	/// <summary>
	/// Summary description for SearchDlg.
	/// </summary>
	public class SearchDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtSearchFor;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbSearchIn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SearchDlg()
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
			this.cbSearchIn = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtSearchFor = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search In";
			// 
			// cbSearchIn
			// 
			this.cbSearchIn.Items.AddRange(new object[] {
            "FROM",
            "SUBJECT",
            "TEXT"});
			this.cbSearchIn.Location = new System.Drawing.Point(24, 32);
			this.cbSearchIn.Name = "cbSearchIn";
			this.cbSearchIn.Size = new System.Drawing.Size(248, 21);
			this.cbSearchIn.TabIndex = 1;
			this.cbSearchIn.Text = "SUBJECT";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Search For";
			// 
			// edtSearchFor
			// 
			this.edtSearchFor.Location = new System.Drawing.Point(24, 80);
			this.edtSearchFor.Name = "edtSearchFor";
			this.edtSearchFor.Size = new System.Drawing.Size(248, 20);
			this.edtSearchFor.TabIndex = 3;
			// 
			// btnSearch
			// 
			this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSearch.Location = new System.Drawing.Point(96, 112);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Search";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(192, 112);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			// 
			// SearchDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 152);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.edtSearchFor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbSearchIn);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "SearchDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Find Message";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.SearchDlg_Closing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private void SearchDlg_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			e.Cancel = (this.DialogResult == DialogResult.OK)
				&& ((cbSearchIn.Text == "") || (edtSearchFor.Text == ""));
			if (e.Cancel)
				MessageBox.Show("The search conditions can not be empty");
		}

		public string GetSearchCriteria() {
			return cbSearchIn.Text + " " + edtSearchFor.Text;
		}
	}
}
