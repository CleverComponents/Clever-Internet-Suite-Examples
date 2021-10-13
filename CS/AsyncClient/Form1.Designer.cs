namespace AsyncClientDemo {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.edtHost = new System.Windows.Forms.TextBox();
			this.edtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConnect = new System.Windows.Forms.Button();
			this.memTerminal = new System.Windows.Forms.TextBox();
			this.asyncClient1 = new CleverComponents.InetSuite.AsyncClient();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host";
			// 
			// edtHost
			// 
			this.edtHost.Location = new System.Drawing.Point(114, 22);
			this.edtHost.Name = "edtHost";
			this.edtHost.Size = new System.Drawing.Size(253, 20);
			this.edtHost.TabIndex = 1;
			this.edtHost.Text = "localhost";
			// 
			// edtPort
			// 
			this.edtPort.Location = new System.Drawing.Point(114, 48);
			this.edtPort.Name = "edtPort";
			this.edtPort.Size = new System.Drawing.Size(91, 20);
			this.edtPort.TabIndex = 3;
			this.edtPort.Text = "23";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Port";
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(388, 19);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 4;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// memTerminal
			// 
			this.memTerminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.memTerminal.Location = new System.Drawing.Point(4, 85);
			this.memTerminal.Multiline = true;
			this.memTerminal.Name = "memTerminal";
			this.memTerminal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.memTerminal.Size = new System.Drawing.Size(478, 284);
			this.memTerminal.TabIndex = 5;
			this.memTerminal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// asyncClient1
			// 
			this.asyncClient1.LocalBinding = null;
			this.asyncClient1.Server = null;
			this.asyncClient1.TlsFlags = CleverComponents.InetSuite.Sspi.TlsFlags.None;
			this.asyncClient1.Connected += new System.EventHandler(this.asyncClient1_Connected);
			this.asyncClient1.Disconnected += new System.EventHandler(this.asyncClient1_Disconnected);
			this.asyncClient1.Read += new System.EventHandler(this.asyncClient1_Read);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 372);
			this.Controls.Add(this.memTerminal);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.edtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtHost);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Asynchronous client sample - TELNET";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtHost;
		private System.Windows.Forms.TextBox edtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox memTerminal;
		private CleverComponents.InetSuite.AsyncClient asyncClient1;
	}
}

