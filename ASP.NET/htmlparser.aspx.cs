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
	/// Summary description for htmlparser.
	/// </summary>
	public partial class htmlparser : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.HtmlParser htmlparser1;
		protected CleverComponents.InetSuite.Http http1;
	
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
			this.htmlparser1 = new CleverComponents.InetSuite.HtmlParser();
			this.http1 = new CleverComponents.InetSuite.Http();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			string html = http1.Get(edtUrl.Text);
			htmlparser1.Parse(html);

			DataTable links = new DataTable();
			links.Columns.Add("Url");

			foreach (CleverComponents.InetSuite.HtmlLink link in htmlparser1.Links) {
				DataRow row = links.NewRow();
				row["Url"] = link.Href;
				links.Rows.Add(row);
			}

			DataGrid1.DataSource = links;
			DataGrid1.DataBind();
		}
	}
}
