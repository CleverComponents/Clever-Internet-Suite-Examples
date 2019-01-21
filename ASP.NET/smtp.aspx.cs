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
	/// Summary description for smtp.
	/// </summary>
	public partial class smtp : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.Smtp smtp1;
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
			this.smtp1 = new CleverComponents.InetSuite.Smtp();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			// 
			// smtp1
			// 
			this.smtp1.Port = 25;
			// 
			// mailMessage1
			// 
			this.mailMessage1.Date = new System.DateTime(2006, 5, 8, 16, 47, 44, 46);
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).EndInit();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			mailMessage1.BuildMessage(edtBody.Text, "");
			mailMessage1.From.FullAddress = edtFrom.Text;
			mailMessage1.ToList.EmailAddresses = edtTo.Text;
			mailMessage1.Subject = edtSubject.Text;

			smtp1.Server = edtServer.Text;
			smtp1.UserName = edtUser.Text;
			smtp1.Password = edtPassword.Text;

			try {
				smtp1.Open();
				smtp1.Send(mailMessage1);

				lblStatus.Visible = true;
				lblStatus.BackColor = Color.White;
				lblStatus.ForeColor = Color.Black;
				lblStatus.Text = "The message was sent successfully";
			}
			catch (Exception ex) {
				lblStatus.Visible = true;
				lblStatus.BackColor = Color.Red;
				lblStatus.ForeColor = Color.White;
				lblStatus.Text = ex.Message;
			}
			smtp1.Close();
		}
	}
}
