using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CleverComponents.InetSuite;

namespace DnsLookup
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			cbNameType.SelectedIndex = 1;
		}

		private void btnResolve_Click(object sender, EventArgs e)
		{
			dnsQuery1.Server = edtDnsServer.Text;
			dnsQuery1.Port = Convert.ToInt32(edtPort.Text);
			dnsQuery1.TimeOut = Convert.ToInt32(edtTimeOut.Text) * 1000;

			try
			{
				switch (cbNameType.SelectedIndex)
				{
					case 0: dnsQuery1.ResolveMX(edtName.Text); break;
					case 1: dnsQuery1.ResolveIP(edtName.Text); break;
					case 2: dnsQuery1.ResolveHost(edtName.Text); break;
					case 3: dnsQuery1.ResolveNS(edtName.Text); break;
				}

				memResult.Text = "";

				FillMXResult();
				FillHostResult();
				FillNameServerResult();
				FillAliasResult();

				if (StringUtils.IsEmpty(edtDnsServer.Text))
				{
					edtDnsServer.Text = dnsQuery1.Server;
				}

				MessageBox.Show("Done");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void FillMXResult()
		{
			if (dnsQuery1.MailServers.Count == 0) return;

			memResult.Text += "====== Mail Servers ======\r\n";

			foreach (MailServerInfo mx in dnsQuery1.MailServers)
			{
				memResult.Text += String.Format("{0}, Preference {1}, {2}\r\n", mx.Name, mx.Preference, mx.IPAddress);
			}

			memResult.Text += "\r\n";
		}

		private void FillHostResult()
		{
			if (dnsQuery1.Hosts.Count == 0) return;

			memResult.Text += "====== Hosts ======\r\n";

			foreach (HostInfo host in dnsQuery1.Hosts)
			{
				memResult.Text += String.Format("{0}, {1}\r\n", host.Name, host.IPAddress);
			}

			memResult.Text += "\r\n";
		}

		private void FillNameServerResult()
		{
			if (dnsQuery1.NameServers == null || dnsQuery1.NameServers.Length == 0) return;

			memResult.Text += "====== Name Servers ======\r\n";
			memResult.Text += StringUtils.GetStringsAsString(dnsQuery1.NameServers);
			memResult.Text += "\r\n";
		}

		private void FillAliasResult()
		{
			if (dnsQuery1.Aliases == null || dnsQuery1.Aliases.Length == 0) return;

			memResult.Text += "====== Aliases ======\r\n";
			memResult.Text += StringUtils.GetStringsAsString(dnsQuery1.Aliases);
			memResult.Text += "\r\n";
		}
	}
}
