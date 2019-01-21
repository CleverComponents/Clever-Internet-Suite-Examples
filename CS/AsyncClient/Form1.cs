using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CleverComponents.InetSuite;

namespace AsyncClientDemo {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		delegate void WriteTerminalDelegate(string msg);

		void WriteTerminal(string msg) {
			if (this.IsDisposed) return;

			if (this.InvokeRequired) {
				this.Invoke(new WriteTerminalDelegate(WriteTerminal), new object[] { msg });
			}
			else {
				memTerminal.Text += msg + "\r\n";
				memTerminal.Select(memTerminal.Text.Length, 0);
				memTerminal.ScrollToCaret();
			}
		}

		private void asyncClient1_Disconnected(object sender, EventArgs e) {
			WriteTerminal("Connection closed\r\n");
		}

		private void asyncClient1_Read(object sender, EventArgs e) {
			using (StringStream str = new StringStream()) {
				asyncClient1.ReadData(str);
				if (!StringUtils.IsEmpty(str.DataString)) {
					WriteTerminal(str.DataString.Trim() + "\r\n");
				}
			}
		}

		private void btnConnect_Click(object sender, EventArgs e) {
			asyncClient1.Server = edtHost.Text;
			asyncClient1.Port = Convert.ToInt32(edtPort.Text);
			asyncClient1.Open();
			memTerminal.Focus();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
			if (!asyncClient1.Active) return;

			string s = e.KeyChar.ToString();

			if (e.KeyChar == '\r') {
				s = "\r\n";
			}

			using (StringStream str = new StringStream(s)) {
				asyncClient1.WriteData(str);
			}
		}

		private void asyncClient1_Connected(object sender, EventArgs e) {
			WriteTerminal("Connected to " + asyncClient1.Server + "(" + asyncClient1.Port.ToString() + ")\r\n");
		}
	}
}