using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using CleverComponents.InetSuite;

namespace NewsGroups
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtNewsServer;
		private System.Windows.Forms.ComboBox cbNewsGroup;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnGetArticles;
		private System.Windows.Forms.Button btnPostNew;
		private System.Windows.Forms.Button btnReply;
		private System.Windows.Forms.TreeView tvArticles;
		private System.Windows.Forms.TextBox memBody;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private CleverComponents.InetSuite.Nntp nntp1;
		private CleverComponents.InetSuite.MailMessage mailMessage1;
		private bool isLoading = false;

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
			this.edtNewsServer = new System.Windows.Forms.TextBox();
			this.cbNewsGroup = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnGetArticles = new System.Windows.Forms.Button();
			this.btnPostNew = new System.Windows.Forms.Button();
			this.btnReply = new System.Windows.Forms.Button();
			this.tvArticles = new System.Windows.Forms.TreeView();
			this.memBody = new System.Windows.Forms.TextBox();
			this.nntp1 = new CleverComponents.InetSuite.Nntp();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "News Server";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "News Group";
			// 
			// edtNewsServer
			// 
			this.edtNewsServer.Location = new System.Drawing.Point(104, 16);
			this.edtNewsServer.Name = "edtNewsServer";
			this.edtNewsServer.Size = new System.Drawing.Size(352, 20);
			this.edtNewsServer.TabIndex = 2;
			this.edtNewsServer.Text = "msnews.microsoft.com";
			// 
			// cbNewsGroup
			// 
			this.cbNewsGroup.Enabled = false;
			this.cbNewsGroup.Location = new System.Drawing.Point(104, 48);
			this.cbNewsGroup.Name = "cbNewsGroup";
			this.cbNewsGroup.Size = new System.Drawing.Size(352, 21);
			this.cbNewsGroup.TabIndex = 3;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(24, 88);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnGetArticles
			// 
			this.btnGetArticles.Enabled = false;
			this.btnGetArticles.Location = new System.Drawing.Point(112, 88);
			this.btnGetArticles.Name = "btnGetArticles";
			this.btnGetArticles.Size = new System.Drawing.Size(75, 23);
			this.btnGetArticles.TabIndex = 5;
			this.btnGetArticles.Text = "Get Articles";
			this.btnGetArticles.Click += new System.EventHandler(this.btnGetArticles_Click);
			// 
			// btnPostNew
			// 
			this.btnPostNew.Enabled = false;
			this.btnPostNew.Location = new System.Drawing.Point(296, 88);
			this.btnPostNew.Name = "btnPostNew";
			this.btnPostNew.Size = new System.Drawing.Size(75, 23);
			this.btnPostNew.TabIndex = 6;
			this.btnPostNew.Text = "Post New...";
			this.btnPostNew.Click += new System.EventHandler(this.btnPostNew_Click);
			// 
			// btnReply
			// 
			this.btnReply.Enabled = false;
			this.btnReply.Location = new System.Drawing.Point(384, 88);
			this.btnReply.Name = "btnReply";
			this.btnReply.Size = new System.Drawing.Size(75, 23);
			this.btnReply.TabIndex = 7;
			this.btnReply.Text = "Reply...";
			this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
			// 
			// tvArticles
			// 
			this.tvArticles.Location = new System.Drawing.Point(24, 120);
			this.tvArticles.Name = "tvArticles";
			this.tvArticles.Size = new System.Drawing.Size(432, 97);
			this.tvArticles.TabIndex = 8;
			this.tvArticles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvArticles_AfterSelect);
			// 
			// memBody
			// 
			this.memBody.Location = new System.Drawing.Point(24, 224);
			this.memBody.Multiline = true;
			this.memBody.Name = "memBody";
			this.memBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memBody.Size = new System.Drawing.Size(432, 144);
			this.memBody.TabIndex = 9;
			// 
			// nntp1
			// 
			this.nntp1.GroupOverviewing += new CleverComponents.InetSuite.GroupOverviewEventHandler(this.nntp1_GroupOverview);
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 5, 16, 32, 5, 968);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 382);
			this.Controls.Add(this.memBody);
			this.Controls.Add(this.tvArticles);
			this.Controls.Add(this.btnReply);
			this.Controls.Add(this.btnPostNew);
			this.Controls.Add(this.btnGetArticles);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.cbNewsGroup);
			this.Controls.Add(this.edtNewsServer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "News Group Reader";
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();
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

		private void btnConnect_Click(object sender, System.EventArgs e) {
			cbNewsGroup.Enabled = false;
			btnGetArticles.Enabled = false;
			btnPostNew.Enabled = false;
			btnReply.Enabled = false;
			tvArticles.Enabled = false;
			memBody.Enabled = false;
			cbNewsGroup.Enabled = false;

			try {
				nntp1.Close();
				nntp1.Server = edtNewsServer.Text;
				nntp1.Open();

				string[] list = nntp1.GetGroups();

				string s = cbNewsGroup.Text;
				cbNewsGroup.Items.Clear();
				foreach(string group in list) {
					cbNewsGroup.Items.Add(group);
				}
				cbNewsGroup.Text = s;

				cbNewsGroup.Enabled = true;
				btnGetArticles.Enabled = true;
				btnPostNew.Enabled = true;
				btnReply.Enabled = true;
				tvArticles.Enabled = true;
				memBody.Enabled = true;
				cbNewsGroup.Enabled = true;
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void btnGetArticles_Click(object sender, System.EventArgs e) {
			btnGetArticles.Enabled = false;
			btnPostNew.Enabled = false;
			btnReply.Enabled = false;
			tvArticles.Enabled = false;
			memBody.Enabled = false;
			isLoading = true;
			try {
				tvArticles.Nodes.Clear();
				memBody.Text = "";

				nntp1.SelectGroup(cbNewsGroup.Text);
				nntp1.GroupOverview();
			}
			finally {
				isLoading = false;
				btnGetArticles.Enabled = true;
				btnPostNew.Enabled = true;
				btnReply.Enabled = true;
				tvArticles.Enabled = true;
				memBody.Enabled = true;
			}
		}

		private void btnPostNew_Click(object sender, System.EventArgs e) {
			if (MessageFrm.PostNew(mailMessage1))
				nntp1.PostArticle(mailMessage1, "", cbNewsGroup.Text);
		}

		private void btnReply_Click(object sender, System.EventArgs e) {
			if (tvArticles.SelectedNode == null) {
				MessageBox.Show("Select article first");
				return;
			}

			nntp1.GetArticle(tvArticles.SelectedNode.Tag.ToString(), mailMessage1);

			if (MessageFrm.ReplyTo(mailMessage1))
				nntp1.PostArticle(mailMessage1, tvArticles.SelectedNode.Tag.ToString(), cbNewsGroup.Text);
		}

		private TreeNode FindNodeByMessageID(TreeNodeCollection list, string messageID) {
			foreach(TreeNode node in list) {
				if (node.Tag.ToString() == messageID) return node;
				TreeNode subNode = FindNodeByMessageID(node.Nodes, messageID);
				if (subNode != null) return subNode;
			}
			return null;
		}

		private void tvArticles_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) {
			if (isLoading || (e.Node == null)) return;
			isLoading = true;
			try {
				memBody.Lines = nntp1.GetBody(e.Node.Tag.ToString());
			}
			finally {
				isLoading = false;
			}
		}

		private void nntp1_GroupOverview(object sender, CleverComponents.InetSuite.GroupOverviewEventArgs e) {
			TreeNode node = null;

			try {
				if (e.ArticleInfo.References != null && e.ArticleInfo.References.Length > 0)
					node = FindNodeByMessageID(tvArticles.Nodes, e.ArticleInfo.References[e.ArticleInfo.References.Length - 1]);
			}
			catch (Exception) {}

			TreeNode newNode;
			if (node != null)
				newNode = node.Nodes.Add(e.ArticleInfo.Subject + " from " + e.ArticleInfo.From.FullAddress);
			else
				newNode = tvArticles.Nodes.Add(e.ArticleInfo.Subject + " from " + e.ArticleInfo.From.FullAddress);

			newNode.Tag = e.ArticleInfo.MessageID;
		}
	}
}
