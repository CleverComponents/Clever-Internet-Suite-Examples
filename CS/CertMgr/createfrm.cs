using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CertMgr
{
	/// <summary>
	/// Summary description for createfrm.
	/// </summary>
	public class CreateCertForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox edtCN;
		private System.Windows.Forms.TextBox edtO;
		private System.Windows.Forms.TextBox edtOU;
		private System.Windows.Forms.TextBox edtS;
		private System.Windows.Forms.TextBox edtC;
		private System.Windows.Forms.TextBox edtE;
		public System.Windows.Forms.TextBox edtSerial;
		public System.Windows.Forms.TextBox edtValidFrom;
		public System.Windows.Forms.TextBox edtValidTo;
		public System.Windows.Forms.TextBox edtStoreName;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private TextBox edtL;
		private Label label11;
		public TextBox edtKeyName;
		private Label label12;
        public TextBox edtKeyLength;
        private Label label13;
        private Label label14;
		public CheckBox cbServerAuth;
		public CheckBox cbClientAuth;
		public CheckBox cbEmailProtection;
		public CheckBox cbCodeSigning;
		public TextBox edtFriendlyName;
        private Label label15;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CreateCertForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			edtValidFrom.Text = DateTime.Now.ToString();
			edtValidTo.Text = DateTime.Now.AddYears(1).ToString();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		public string BuildSubjectString() {
			string result = "";
			result += (edtCN.Text != "") ? ",CN=" + edtCN.Text : "";
			result += (edtOU.Text != "") ? ",OU=" + edtOU.Text : "";
			result += (edtO.Text != "") ? ",O=" + edtO.Text : "";
			result += (edtS.Text != "") ? ",S=" + edtS.Text : "";
			result += (edtL.Text != "") ? ",L=" + edtL.Text : "";
			result += (edtC.Text != "") ? ",C=" + edtC.Text : "";
			result += (edtE.Text != "") ? ",E=" + edtE.Text : "";

			if (result != "")
				result = result.Remove(0, 1);
			return result;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edtCN = new System.Windows.Forms.TextBox();
            this.edtO = new System.Windows.Forms.TextBox();
            this.edtOU = new System.Windows.Forms.TextBox();
            this.edtS = new System.Windows.Forms.TextBox();
            this.edtC = new System.Windows.Forms.TextBox();
            this.edtE = new System.Windows.Forms.TextBox();
            this.edtSerial = new System.Windows.Forms.TextBox();
            this.edtValidFrom = new System.Windows.Forms.TextBox();
            this.edtValidTo = new System.Windows.Forms.TextBox();
            this.edtStoreName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.edtL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.edtKeyName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.edtKeyLength = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbServerAuth = new System.Windows.Forms.CheckBox();
            this.cbClientAuth = new System.Windows.Forms.CheckBox();
            this.cbEmailProtection = new System.Windows.Forms.CheckBox();
            this.cbCodeSigning = new System.Windows.Forms.CheckBox();
            this.edtFriendlyName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Common Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Organization";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Organizational Unit";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(265, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Country";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Serial Number";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valid From";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(257, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Valid To";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 334);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(448, 23);
            this.label10.TabIndex = 9;
            this.label10.Text = "The new certificate will be created and installed in to the currently loaded Syst" +
                "em Store:";
            // 
            // edtCN
            // 
            this.edtCN.Location = new System.Drawing.Point(129, 36);
            this.edtCN.Name = "edtCN";
            this.edtCN.Size = new System.Drawing.Size(328, 20);
            this.edtCN.TabIndex = 10;
            this.edtCN.Text = "CleverTester";
            // 
            // edtO
            // 
            this.edtO.Location = new System.Drawing.Point(129, 60);
            this.edtO.Name = "edtO";
            this.edtO.Size = new System.Drawing.Size(328, 20);
            this.edtO.TabIndex = 11;
            this.edtO.Text = "YourCompany";
            // 
            // edtOU
            // 
            this.edtOU.Location = new System.Drawing.Point(129, 84);
            this.edtOU.Name = "edtOU";
            this.edtOU.Size = new System.Drawing.Size(328, 20);
            this.edtOU.TabIndex = 12;
            this.edtOU.Text = "Demos";
            // 
            // edtS
            // 
            this.edtS.Location = new System.Drawing.Point(129, 108);
            this.edtS.Name = "edtS";
            this.edtS.Size = new System.Drawing.Size(104, 20);
            this.edtS.TabIndex = 13;
            this.edtS.Text = "CA";
            // 
            // edtC
            // 
            this.edtC.Location = new System.Drawing.Point(353, 108);
            this.edtC.Name = "edtC";
            this.edtC.Size = new System.Drawing.Size(104, 20);
            this.edtC.TabIndex = 14;
            this.edtC.Text = "US";
            // 
            // edtE
            // 
            this.edtE.Location = new System.Drawing.Point(129, 157);
            this.edtE.Name = "edtE";
            this.edtE.Size = new System.Drawing.Size(328, 20);
            this.edtE.TabIndex = 16;
            this.edtE.Text = "CleverTester@company.mail";
            // 
            // edtSerial
            // 
            this.edtSerial.Location = new System.Drawing.Point(129, 181);
            this.edtSerial.Name = "edtSerial";
            this.edtSerial.Size = new System.Drawing.Size(80, 20);
            this.edtSerial.TabIndex = 17;
            this.edtSerial.Text = "1";
            // 
            // edtValidFrom
            // 
            this.edtValidFrom.Location = new System.Drawing.Point(129, 205);
            this.edtValidFrom.Name = "edtValidFrom";
            this.edtValidFrom.Size = new System.Drawing.Size(104, 20);
            this.edtValidFrom.TabIndex = 18;
            // 
            // edtValidTo
            // 
            this.edtValidTo.Location = new System.Drawing.Point(353, 205);
            this.edtValidTo.Name = "edtValidTo";
            this.edtValidTo.Size = new System.Drawing.Size(104, 20);
            this.edtValidTo.TabIndex = 19;
            // 
            // edtStoreName
            // 
            this.edtStoreName.Location = new System.Drawing.Point(12, 347);
            this.edtStoreName.Name = "edtStoreName";
            this.edtStoreName.ReadOnly = true;
            this.edtStoreName.Size = new System.Drawing.Size(440, 20);
            this.edtStoreName.TabIndex = 40;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(124, 379);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 41;
            this.btnOk.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 379);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 42;
            this.btnCancel.Text = "Cancel";
            // 
            // edtL
            // 
            this.edtL.Location = new System.Drawing.Point(129, 131);
            this.edtL.Name = "edtL";
            this.edtL.Size = new System.Drawing.Size(104, 20);
            this.edtL.TabIndex = 15;
            this.edtL.Text = "SF";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Location";
            // 
            // edtKeyName
            // 
            this.edtKeyName.Location = new System.Drawing.Point(129, 231);
            this.edtKeyName.Name = "edtKeyName";
            this.edtKeyName.Size = new System.Drawing.Size(328, 20);
            this.edtKeyName.TabIndex = 20;
            this.edtKeyName.Text = "testkeyname-99046937-7D4A-441A-8621-5CDADA8AF9DC";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(17, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Key Name";
            // 
            // edtKeyLength
            // 
            this.edtKeyLength.Location = new System.Drawing.Point(129, 257);
            this.edtKeyLength.Name = "edtKeyLength";
            this.edtKeyLength.Size = new System.Drawing.Size(80, 20);
            this.edtKeyLength.TabIndex = 25;
            this.edtKeyLength.Text = "1024";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(17, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Key Length";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(17, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Key Usage";
            // 
            // cbServerAuth
            // 
            this.cbServerAuth.AutoSize = true;
            this.cbServerAuth.Checked = true;
            this.cbServerAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbServerAuth.Location = new System.Drawing.Point(129, 291);
            this.cbServerAuth.Name = "cbServerAuth";
            this.cbServerAuth.Size = new System.Drawing.Size(82, 17);
            this.cbServerAuth.TabIndex = 27;
            this.cbServerAuth.Text = "Server Auth";
            this.cbServerAuth.UseVisualStyleBackColor = true;
            // 
            // cbClientAuth
            // 
            this.cbClientAuth.AutoSize = true;
            this.cbClientAuth.Checked = true;
            this.cbClientAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClientAuth.Location = new System.Drawing.Point(129, 314);
            this.cbClientAuth.Name = "cbClientAuth";
            this.cbClientAuth.Size = new System.Drawing.Size(77, 17);
            this.cbClientAuth.TabIndex = 28;
            this.cbClientAuth.Text = "Client Auth";
            this.cbClientAuth.UseVisualStyleBackColor = true;
            // 
            // cbEmailProtection
            // 
            this.cbEmailProtection.AutoSize = true;
            this.cbEmailProtection.Checked = true;
            this.cbEmailProtection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEmailProtection.Location = new System.Drawing.Point(244, 314);
            this.cbEmailProtection.Name = "cbEmailProtection";
            this.cbEmailProtection.Size = new System.Drawing.Size(102, 17);
            this.cbEmailProtection.TabIndex = 30;
            this.cbEmailProtection.Text = "Email Protection";
            this.cbEmailProtection.UseVisualStyleBackColor = true;
            // 
            // cbCodeSigning
            // 
            this.cbCodeSigning.AutoSize = true;
            this.cbCodeSigning.Checked = true;
            this.cbCodeSigning.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCodeSigning.Location = new System.Drawing.Point(244, 291);
            this.cbCodeSigning.Name = "cbCodeSigning";
            this.cbCodeSigning.Size = new System.Drawing.Size(89, 17);
            this.cbCodeSigning.TabIndex = 29;
            this.cbCodeSigning.Text = "Code Signing";
            this.cbCodeSigning.UseVisualStyleBackColor = true;
            // 
            // edtFriendlyName
            // 
            this.edtFriendlyName.Location = new System.Drawing.Point(129, 10);
            this.edtFriendlyName.Name = "edtFriendlyName";
            this.edtFriendlyName.Size = new System.Drawing.Size(328, 20);
            this.edtFriendlyName.TabIndex = 9;
            this.edtFriendlyName.Text = "Clever Tester";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(17, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 43;
            this.label15.Text = "Friendly Name";
            // 
            // CreateCertForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(472, 423);
            this.Controls.Add(this.edtFriendlyName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbEmailProtection);
            this.Controls.Add(this.cbCodeSigning);
            this.Controls.Add(this.cbClientAuth);
            this.Controls.Add(this.cbServerAuth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.edtKeyLength);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.edtKeyName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.edtL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.edtStoreName);
            this.Controls.Add(this.edtValidTo);
            this.Controls.Add(this.edtValidFrom);
            this.Controls.Add(this.edtSerial);
            this.Controls.Add(this.edtE);
            this.Controls.Add(this.edtC);
            this.Controls.Add(this.edtS);
            this.Controls.Add(this.edtOU);
            this.Controls.Add(this.edtO);
            this.Controls.Add(this.edtCN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateCertForm";
            this.ShowInTaskbar = false;
            this.Text = "Create Self-Signed Certificate Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
	}
}
