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
	/// Summary description for webdavclient.
	/// </summary>
	public partial class webdavclient : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.WebDav webdav1;
	
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
			this.webdav1 = new CleverComponents.InetSuite.WebDav();
		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			webdav1.UserName = edtUser.Text;
			webdav1.Password = edtPassword.Text;

			webdav1.ListDir(edtHost.Text);

			DataTable resources = new DataTable();
			resources.Columns.Add("Path");
			resources.Columns.Add("Size");

			foreach (WebDavProperty resource in webdav1.ResourceProperties) {
				DataRow row = resources.NewRow();
				resources.Rows.Add(row);
				row["Path"] = resource.Uri;
				row["Size"] = resource.Value;
			}

			DataGrid1.DataSource = resources;
			DataGrid1.DataBind();
		}
	}
}
