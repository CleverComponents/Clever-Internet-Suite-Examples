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
	/// Summary description for rss.
	/// </summary>
	public partial class rss : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.Rss rss1;
	
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
			this.rss1 = new CleverComponents.InetSuite.Rss();

		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			rss1.Get(edtURL.Text);

			edtTitle.Text = Server.HtmlEncode(rss1.Channel.Title);
			edtLink.Text = Server.HtmlEncode(rss1.Channel.Link);
			edtDescription.Text = Server.HtmlEncode(rss1.Channel.Description);

			DataTable messages = new DataTable();
			messages.Columns.Add("Title");
			messages.Columns.Add("Date");

			foreach (RssItem item in rss1.Items) {
				DataRow row = messages.NewRow();
				row["Title"] = item.Title;
				row["Date"] = item.PubDate.ToString();
				messages.Rows.Add(row);
			}

			DataGrid1.DataSource = messages;
			DataGrid1.DataBind();
		}
	}
}
