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
	/// Summary description for emailvalidator.
	/// </summary>
	public partial class emailvalidator : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.EmailValidator emailvalidator1;
	
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
			this.emailvalidator1 = new CleverComponents.InetSuite.EmailValidator();
		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			emailvalidator1.ValidationLevel = (EmailValidationLevel)StringUtils.StrToIntDef(cbLevel.Text, 0);
			emailvalidator1.DnsServer = edtDNS.Text;
			emailvalidator1.BlackList = StringUtils.GetStringArray(edtBlackList.Text);

			EmailValidationResult result = emailvalidator1.Validate(edtEmail.Text);

			switch (result) {
				case EmailValidationResult.BlacklistOk: edtResult.Text = "Blacklist passed"; break;
				case EmailValidationResult.SyntaxOk: edtResult.Text = "Syntax valid"; break;
				case EmailValidationResult.DomainOk: edtResult.Text = "Domain valid"; break;
				case EmailValidationResult.SmtpOk: edtResult.Text = "Email exchanger valid"; break;
				case EmailValidationResult.MailboxOk: edtResult.Text = "Mailbox valid"; break;
				default: edtResult.Text = "E-mail invalid"; break;
			}
		}
	}
}
