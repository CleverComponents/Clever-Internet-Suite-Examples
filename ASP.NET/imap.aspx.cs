using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace inetsuitedemocs
{
	/// <summary>
	/// Summary description for imap.
	/// </summary>
	public partial class imap : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.Imap4 imap41;
		protected CleverComponents.InetSuite.MailMessage mailMessage1;
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.imap41 = new CleverComponents.InetSuite.Imap4();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			// 
			// imap41
			// 
			this.imap41.Port = 143;
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 8, 17, 7, 13, 484);
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			DataTable messages = new DataTable();
			messages.Columns.Add("Subject");
			messages.Columns.Add("From");
			messages.Columns.Add("Date");

			imap41.Server = edtServer.Text;
			imap41.UserName = edtUser.Text;
			imap41.Password = edtPassword.Text;
			imap41.Open();
			imap41.SelectMailBox(edtMailBox.Text);

			for (int i = 1; i <= imap41.CurrentMailBox.ExistsMessages; i++) {
				imap41.RetrieveHeader(i, mailMessage1);

				DataRow row = messages.NewRow();
				row["Subject"] = mailMessage1.Subject;
				row["From"] = mailMessage1.From;
				row["Date"] = mailMessage1.Date;
				messages.Rows.Add(row);
			}

			Datagrid1.DataSource = messages;
			Datagrid1.DataBind();

			imap41.Close();
		}
	}
}
