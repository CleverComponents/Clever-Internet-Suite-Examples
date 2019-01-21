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
	/// Summary description for nntp.
	/// </summary>
	public partial class nntp : System.Web.UI.Page {
		protected CleverComponents.InetSuite.Nntp nntp1;

		protected void Page_Load(object sender, System.EventArgs e) {
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e) {
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
		private void InitializeComponent() {
			this.nntp1 = new CleverComponents.InetSuite.Nntp();
		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			nntp1.Server = edtServer.Text;
			nntp1.Open();

			string[] groups = nntp1.GetGroups(false);

			cbNewsgroup.Items.Clear();
			foreach (string group in groups) {
				cbNewsgroup.Items.Add(group);
			}

			if (cbNewsgroup.Items.Count > 0) {
				cbNewsgroup.SelectedIndex = 0;
			}

			nntp1.Close();
			Button2.Enabled = true;
		}

		protected void Button2_Click(object sender, EventArgs e) {
			DataTable messages = new DataTable();
			messages.Columns.Add("Subject");
			messages.Columns.Add("From");
			messages.Columns.Add("Date");

			nntp1.Server = edtServer.Text;
			nntp1.Open();

			nntp1.SelectGroup(cbNewsgroup.SelectedValue);

			nntp1.GroupOverviewing += delegate(object sender1, GroupOverviewEventArgs args) {
				DataRow row = messages.NewRow();
				row["Subject"] = args.ArticleInfo.Subject;
				row["From"] = args.ArticleInfo.From.FullAddress;
				row["Date"] = args.ArticleInfo.Date.ToString();
				messages.Rows.Add(row);
			};

			nntp1.GroupOverview();

			DataGrid1.DataSource = messages;
			DataGrid1.DataBind();

			nntp1.Close();
		}
	}
}
