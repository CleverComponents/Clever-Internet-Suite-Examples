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
using CleverComponents.InetSuite;

namespace inetsuitedemocs
{
	/// <summary>
	/// Summary description for pop3.
	/// </summary>
	public partial class pop3 : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.Pop3 pop31;
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
			this.pop31 = new CleverComponents.InetSuite.Pop3();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			// 
			// pop31
			// 
			this.pop31.Port = 110;
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 8, 17, 4, 14, 859);
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			DataTable messages = new DataTable();
			messages.Columns.Add("Subject");
			messages.Columns.Add("From");
			messages.Columns.Add("Date");

			pop31.Server = edtServer.Text;
			pop31.UserName = edtUser.Text;
			pop31.Password = edtPassword.Text;
			pop31.Open();

			for (int i = 1; i <= pop31.MessageCount; i++) {
				pop31.RetrieveHeader(i, mailMessage1);

				DataRow row = messages.NewRow();
				row["Subject"] = mailMessage1.Subject;
				row["From"] = mailMessage1.From;
				row["Date"] = mailMessage1.Date;
				messages.Rows.Add(row);
			}

			DataGrid1.DataSource = messages;
			DataGrid1.DataBind();

			pop31.Close();
		}
	}
}
