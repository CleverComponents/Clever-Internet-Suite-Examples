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
	/// Summary description for ftpclient.
	/// </summary>
	public partial class ftpclient : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.Ftp ftp1;
	
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
			this.ftp1 = new CleverComponents.InetSuite.Ftp();
		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			ftp1.Server = edtServer.Text;
			ftp1.Port = StringUtils.StrToIntDef(edtPort.Text, 21);
			ftp1.UserName = edtUser.Text;
			ftp1.Password = edtPassword.Text;

			ftp1.Open();

			string dir = edtCurrentDir.Text;

			if (!StringUtils.IsEmpty(dir)) {
				ftp1.ChangeCurrentDir(dir);
			}

			DataTable files = new DataTable();
			files.Columns.Add("filename");

			ftp1.DirectoryListing += delegate(object sender1, DirectoryListingEventArgs args) {
				DataRow row = files.NewRow();
				files.Rows.Add(row);

				if (args.FileInfo.IsDirectory) {
					row["filename"] = "/" + args.FileInfo.FileName;
				}
				else {
					row["filename"] = args.FileInfo.FileName;
				}
			};

			ftp1.GetDirectoryListing();

			DataGrid1.DataSource = files;
			DataGrid1.DataBind();

			ftp1.Close();
		}
	}
}
