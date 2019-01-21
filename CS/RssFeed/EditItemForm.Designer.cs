namespace RssFeed {
	partial class EditItemForm {
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
			this.edtTitle = new System.Windows.Forms.TextBox();
			this.edtLink = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edtPubDate = new System.Windows.Forms.DateTimePicker();
			this.edtGuid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			// 
			// edtTitle
			// 
			this.edtTitle.Location = new System.Drawing.Point(85, 12);
			this.edtTitle.Name = "edtTitle";
			this.edtTitle.Size = new System.Drawing.Size(273, 20);
			this.edtTitle.TabIndex = 1;
			this.edtTitle.Text = "News Title";
			// 
			// edtLink
			// 
			this.edtLink.Location = new System.Drawing.Point(85, 38);
			this.edtLink.Name = "edtLink";
			this.edtLink.Size = new System.Drawing.Size(273, 20);
			this.edtLink.TabIndex = 3;
			this.edtLink.Text = "http://www.sample.com/news.html";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(27, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Link";
			// 
			// edtDescription
			// 
			this.edtDescription.Location = new System.Drawing.Point(85, 64);
			this.edtDescription.Name = "edtDescription";
			this.edtDescription.Size = new System.Drawing.Size(273, 20);
			this.edtDescription.TabIndex = 5;
			this.edtDescription.Text = "New version released.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Description";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(19, 94);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Pub Date";
			// 
			// edtPubDate
			// 
			this.edtPubDate.Location = new System.Drawing.Point(85, 90);
			this.edtPubDate.Name = "edtPubDate";
			this.edtPubDate.Size = new System.Drawing.Size(200, 20);
			this.edtPubDate.TabIndex = 7;
			// 
			// edtGuid
			// 
			this.edtGuid.Location = new System.Drawing.Point(85, 116);
			this.edtGuid.Name = "edtGuid";
			this.edtGuid.Size = new System.Drawing.Size(273, 20);
			this.edtGuid.TabIndex = 9;
			this.edtGuid.Text = "New_version_released";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(19, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "GUID";
			// 
			// button1
			// 
			this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new System.Drawing.Point(176, 155);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new System.Drawing.Point(283, 155);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 11;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// EditItemForm
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.button2;
			this.ClientSize = new System.Drawing.Size(381, 192);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.edtGuid);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtPubDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtLink);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtTitle);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "EditItemForm";
			this.Text = "RSS News Item";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtTitle;
		public System.Windows.Forms.TextBox edtLink;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox edtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.DateTimePicker edtPubDate;
		public System.Windows.Forms.TextBox edtGuid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}