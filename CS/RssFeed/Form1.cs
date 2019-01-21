using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using CleverComponents.InetSuite;

namespace RssFeed
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtTitle;
		private System.Windows.Forms.TextBox edtLink;
		private System.Windows.Forms.TextBox edtDescription;
		private TextBox edtCopyright;
		private Label label1;
		private TextBox edtLanguage;
		private Label label2;
		private TextBox edtWebMaster;
		private Label label3;
		private TextBox edtGenerator;
		private Label label4;
		private TextBox edtImageUrl;
		private Label label9;
		private ListBox lbNews;
		private Button btnAdd;
		private Button btnDelete;
		private Button btnClear;
		private Button btnLoad;
		private Button btnSave;
		private Rss rss1;
		private OpenFileDialog openFileDialog;
		private SaveFileDialog saveFileDialog;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing) {
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.edtTitle = new System.Windows.Forms.TextBox();
			this.edtLink = new System.Windows.Forms.TextBox();
			this.edtDescription = new System.Windows.Forms.TextBox();
			this.edtCopyright = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.edtLanguage = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtWebMaster = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtGenerator = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtImageUrl = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lbNews = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.rss1 = new CleverComponents.InetSuite.Rss();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Title";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Link";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Description";
			// 
			// edtTitle
			// 
			this.edtTitle.Location = new System.Drawing.Point(94, 16);
			this.edtTitle.Name = "edtTitle";
			this.edtTitle.Size = new System.Drawing.Size(306, 20);
			this.edtTitle.TabIndex = 11;
			this.edtTitle.Text = "Demo Company - News";
			// 
			// edtLink
			// 
			this.edtLink.Location = new System.Drawing.Point(94, 40);
			this.edtLink.Name = "edtLink";
			this.edtLink.Size = new System.Drawing.Size(306, 20);
			this.edtLink.TabIndex = 12;
			this.edtLink.Text = "http://www.sample.com";
			// 
			// edtDescription
			// 
			this.edtDescription.Location = new System.Drawing.Point(94, 64);
			this.edtDescription.Name = "edtDescription";
			this.edtDescription.Size = new System.Drawing.Size(306, 20);
			this.edtDescription.TabIndex = 13;
			this.edtDescription.Text = "Demo company description";
			// 
			// edtCopyright
			// 
			this.edtCopyright.Location = new System.Drawing.Point(94, 90);
			this.edtCopyright.Name = "edtCopyright";
			this.edtCopyright.Size = new System.Drawing.Size(306, 20);
			this.edtCopyright.TabIndex = 17;
			this.edtCopyright.Text = "Copyright 2010 Company Inc.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 16;
			this.label1.Text = "Copyright";
			// 
			// edtLanguage
			// 
			this.edtLanguage.Location = new System.Drawing.Point(94, 116);
			this.edtLanguage.Name = "edtLanguage";
			this.edtLanguage.Size = new System.Drawing.Size(306, 20);
			this.edtLanguage.TabIndex = 19;
			this.edtLanguage.Text = "en-US";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Language";
			// 
			// edtWebMaster
			// 
			this.edtWebMaster.Location = new System.Drawing.Point(94, 142);
			this.edtWebMaster.Name = "edtWebMaster";
			this.edtWebMaster.Size = new System.Drawing.Size(306, 20);
			this.edtWebMaster.TabIndex = 21;
			this.edtWebMaster.Text = "webmaster@sample.com";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Web Master";
			// 
			// edtGenerator
			// 
			this.edtGenerator.Location = new System.Drawing.Point(94, 168);
			this.edtGenerator.Name = "edtGenerator";
			this.edtGenerator.Size = new System.Drawing.Size(306, 20);
			this.edtGenerator.TabIndex = 23;
			this.edtGenerator.Text = "Clever Internet Suite 7.2 RSS Component";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Generator";
			// 
			// edtImageUrl
			// 
			this.edtImageUrl.Location = new System.Drawing.Point(94, 194);
			this.edtImageUrl.Name = "edtImageUrl";
			this.edtImageUrl.Size = new System.Drawing.Size(306, 20);
			this.edtImageUrl.TabIndex = 25;
			this.edtImageUrl.Text = "http://www.sample.com/image.gif";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 197);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 16);
			this.label9.TabIndex = 24;
			this.label9.Text = "Image";
			// 
			// lbNews
			// 
			this.lbNews.FormattingEnabled = true;
			this.lbNews.Location = new System.Drawing.Point(19, 227);
			this.lbNews.Name = "lbNews";
			this.lbNews.Size = new System.Drawing.Size(287, 173);
			this.lbNews.TabIndex = 26;
			this.lbNews.DoubleClick += new System.EventHandler(this.lbNews_DoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(325, 227);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 27;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(325, 256);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 28;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(325, 317);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 29;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(325, 347);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 30;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(325, 376);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 31;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// rss1
			// 
			this.rss1.Channel.LastBuildDate = new System.DateTime(((long)(0)));
			this.rss1.Channel.PubDate = new System.DateTime(((long)(0)));
			this.rss1.CharSet = null;
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "RSS Files (*.xml)|*.xml|All Files (*.*)|*.*";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "RSS Files (*.xml)|*.xml|All Files (*.*)|*.*";
			this.saveFileDialog.OverwritePrompt = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 421);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbNews);
			this.Controls.Add(this.edtImageUrl);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.edtGenerator);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtWebMaster);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtLanguage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtCopyright);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edtDescription);
			this.Controls.Add(this.edtLink);
			this.Controls.Add(this.edtTitle);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "RSS Feed demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(new ExceptionHandler().OnThreadException);
			Application.Run(new Form1());
		}

		private void LoadControls() {
			edtTitle.Text = rss1.Channel.Title;
			edtLink.Text = rss1.Channel.Link;
			edtDescription.Text = rss1.Channel.Description;
			edtCopyright.Text = rss1.Channel.Copyright;
			edtLanguage.Text = rss1.Channel.Language;
			edtWebMaster.Text = rss1.Channel.WebMaster;
			edtGenerator.Text = rss1.Channel.Generator;

			edtImageUrl.Text = rss1.Channel.Image.Url;

			lbNews.Items.Clear();

			foreach (RssItem item in rss1.Items) {
				lbNews.Items.Add(item.Title);
			}

			if (lbNews.Items.Count > 0) {
				lbNews.SelectedIndex = 0;
			}
		}

		private void SaveControls() {
			rss1.Channel.Title = edtTitle.Text;
			rss1.Channel.Link = edtLink.Text;
			rss1.Channel.Description = edtDescription.Text;
			rss1.Channel.Copyright = edtCopyright.Text;
			rss1.Channel.Language = edtLanguage.Text;
			rss1.Channel.WebMaster = edtWebMaster.Text;
			rss1.Channel.Generator = edtGenerator.Text;

			rss1.Channel.Image.Url = edtImageUrl.Text;
			rss1.Channel.Image.Title = edtTitle.Text;
			rss1.Channel.Image.Link = edtLink.Text;

			rss1.Channel.PubDate = DateTime.Now;
			rss1.Channel.LastBuildDate = DateTime.Now;
		}

		private void SaveItem(EditItemForm dlg, RssItem item) {
			item.Title = dlg.edtTitle.Text;
			item.Link = dlg.edtLink.Text;
			item.Description = dlg.edtDescription.Text;
			item.Guid.Value = dlg.edtGuid.Text;
			item.PubDate = dlg.edtPubDate.Value;
		}

		private void LoadItem(EditItemForm dlg, RssItem item) {
			dlg.edtTitle.Text = item.Title;
			dlg.edtLink.Text = item.Link;
			dlg.edtDescription.Text = item.Description;
			dlg.edtGuid.Text = item.Guid.Value;
			dlg.edtPubDate.Value = item.PubDate;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			using (EditItemForm dlg = new EditItemForm()) {
				dlg.edtPubDate.Value = DateTime.Now;

				if (dlg.ShowDialog() == DialogResult.OK) {
					RssItem item = new RssItem();
					rss1.Items.Insert(0, item);
					SaveItem(dlg, item);
					lbNews.Items.Insert(0, item.Title);
					lbNews.SelectedIndex = 0;
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e) {
			if (lbNews.SelectedIndex > -1) {
				rss1.Items.RemoveAt(lbNews.SelectedIndex);
				lbNews.Items.RemoveAt(lbNews.SelectedIndex);
			}
		}

		private void btnClear_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Do you wish to clean news feeds?", "Delete news",
				MessageBoxButtons.YesNo) == DialogResult.Yes) {
				rss1.Clear();
				LoadControls();
			}
		}

		private void btnLoad_Click(object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				using (Stream stream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) {
					rss1.Load(stream);

					LoadControls();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e) {
			if (saveFileDialog.ShowDialog() == DialogResult.OK) {
				if ((!File.Exists(saveFileDialog.FileName)) ||
					(MessageBox.Show("File " + saveFileDialog.FileName + " already exists. Do you want to replace?", "File exists",
				MessageBoxButtons.YesNo) == DialogResult.Yes)) {

					using (Stream stream = new FileStream(saveFileDialog.FileName, FileMode.Create)) {
						SaveControls();

						rss1.Save(stream);

						MessageBox.Show("Done");
					}
				}
			}
		}

		private void lbNews_DoubleClick(object sender, EventArgs e) {
			if (lbNews.SelectedIndex > -1) {
				using (EditItemForm dlg = new EditItemForm()) {
					RssItem item = rss1.Items[lbNews.SelectedIndex];

					LoadItem(dlg, item);

					if (dlg.ShowDialog() == DialogResult.OK) {
						SaveItem(dlg, item);
					}
				}
			}
		}
	}

	public class ExceptionHandler {
		public void OnThreadException(object sender, System.Threading.ThreadExceptionEventArgs t) {
			MessageBox.Show(t.Exception.Message);
		}
	}
}
