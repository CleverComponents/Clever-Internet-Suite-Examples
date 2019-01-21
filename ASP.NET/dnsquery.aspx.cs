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
	/// Summary description for dnsquery.
	/// </summary>
	public partial class dnsquery : System.Web.UI.Page
	{
		protected CleverComponents.InetSuite.DnsQuery dnsquery1;
	
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
			this.dnsquery1 = new CleverComponents.InetSuite.DnsQuery();
		}
		#endregion

		protected void Button1_Click(object sender, System.EventArgs e) {
			dnsquery1.Server = edtServer.Text;

			string type = cbType.SelectedValue;

			if (type == "MX") {
				dnsquery1.ResolveMX(edtName.Text);
			}
			else if (type == "A") {
				dnsquery1.ResolveIP(edtName.Text);
			}
			else if (type == "PTR") {
				dnsquery1.ResolveHost(edtName.Text);
			}
			else if (type == "NS") {
				dnsquery1.ResolveNS(edtName.Text);
			}

			edtResult.Text = "";

			if (dnsquery1.MailServers.Count > 0) {
				edtResult.Text += "Mail Servers:\r\n";
			}
			foreach (MailServerInfo mx in dnsquery1.MailServers) {
				edtResult.Text += mx.Preference.ToString() + " - " + mx.Name + " - " + mx.IPAddress + "\r\n";
			}

			if (dnsquery1.Hosts.Count > 0) {
				edtResult.Text += "Hosts:\r\n";
			}
			foreach (HostInfo host in dnsquery1.Hosts) {
				edtResult.Text += host.Name + " - " + host.IPAddress + "\r\n";
			}

			if (dnsquery1.NameServers.Length > 0) {
				edtResult.Text += "Name Servers:\r\n";
			}
			foreach (string ns in dnsquery1.NameServers) {
				edtResult.Text += ns + "\r\n";
			}
		}
	}
}
