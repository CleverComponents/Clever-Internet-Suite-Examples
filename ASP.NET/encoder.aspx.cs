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
	/// Summary description for encoder.
	/// </summary>
	public partial class encoder : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.Encoder encoder1;
	
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
			this.encoder1 = new CleverComponents.InetSuite.Encoder();
		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			encoder1.EncodeMethod = (EncodeMethod)StringUtils.StrToIntDef(cbMethod.SelectedValue, 0);

			string result = encoder1.Encode(edtSource.Text);

			edtResult.Text = Server.HtmlEncode(result);
		}
	}
}
