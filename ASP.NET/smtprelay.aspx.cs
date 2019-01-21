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
	/// Summary description for smtprelay.
	/// </summary>
	public partial class smtprelay : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.SmtpRelay smtprelay1;
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
			this.smtprelay1 = new CleverComponents.InetSuite.SmtpRelay();
			this.mailMessage1 = new CleverComponents.InetSuite.MailMessage();
			((System.ComponentModel.ISupportInitialize)(this.mailMessage1)).BeginInit();
			// 
			// smtp1
			// 
			this.smtprelay1.Port = 25;
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

			smtprelay1.DnsServer = edtDns.Text;
			smtprelay1.Send(mailMessage1);

			edtResult.Text = "";
			foreach (SmtpRelayStatus statusItem in smtprelay1.StatusList) {
				edtResult.Text += "===== " + Server.HtmlEncode(statusItem.Domain) + " =====\r\n";
				edtResult.Text += "Mail server: " + Server.HtmlEncode(statusItem.MailServer) + "\r\n";

				if (statusItem.IsSent) {
					edtResult.Text += "Status: Sent\r\n";
				}
				else {
					edtResult.Text += "Status: Not Sent\r\n";
				}

				edtResult.Text += "Server response: " + Server.HtmlEncode(statusItem.ResponseText) + "\r\n";
				edtResult.Text += "Error: " + Server.HtmlEncode(statusItem.ErrorText) + "\r\n\r\n";
			}
		}
	}
}
