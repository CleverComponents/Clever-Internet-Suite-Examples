using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CleverComponents.Utils {
	public class IniFile {
		string path;

		[DllImport("kernel32")]
		static extern long WritePrivateProfileString(string section,
			string key,string val,string filePath);

		[DllImport("kernel32")]
		static extern int GetPrivateProfileString(string section,
			string key,string def, StringBuilder retVal, int size,string filePath);

		public IniFile(string iniPath) {
			this.path = iniPath;
		}

		public void IniWriteValue(string section, string key, string theValue) {
			WritePrivateProfileString(section, key, theValue, this.path);
		}

		public string IniReadValue(string section, string key, string defaultValue) {
			StringBuilder sb = new StringBuilder(2047);
			GetPrivateProfileString(section, key, defaultValue, sb, 255, this.path);
			return sb.ToString();

		}
	}
}
