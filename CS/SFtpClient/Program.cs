using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SFTPClient {
	static class Program {
		class ExceptionHandler {
			public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
				MessageBox.Show(t.Exception.Message);
			}
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(new ExceptionHandler().OnThreadException);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
