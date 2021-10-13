using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using CleverComponents.InetSuite;

namespace HtmlParser {
	public class MainForm : System.Windows.Forms.Form {
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabLinks;
		private System.Windows.Forms.TabPage tabImages;
		private System.Windows.Forms.TabPage tabForms;
		private System.Windows.Forms.TabPage tabText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lbLinks;
		private System.Windows.Forms.TextBox edtUrlHref;
		private System.Windows.Forms.TextBox edtUrlTarget;
		private System.Windows.Forms.TextBox edtUrlName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox edtImageSrc;
		private System.Windows.Forms.TextBox edtImageAlt;
		private System.Windows.Forms.TextBox edtImageWidth;
		private System.Windows.Forms.TextBox edtImageHeight;
		private System.Windows.Forms.ListBox lbImages;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ListBox lbForms;
		private System.Windows.Forms.ListBox lbFormControls;
		private System.Windows.Forms.TextBox edtFormMethod;
		private System.Windows.Forms.TextBox edtFormName;
		private System.Windows.Forms.TextBox edtFormEncType;
		private System.Windows.Forms.TextBox edtFormAction;
		private System.Windows.Forms.ListBox lbText;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private CleverComponents.InetSuite.HtmlParser htmlParser1;
		private System.ComponentModel.Container components = null;

		public MainForm() {
			InitializeComponent();
		}

		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
		private void InitializeComponent() {
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabLinks = new System.Windows.Forms.TabPage();
			this.edtUrlName = new System.Windows.Forms.TextBox();
			this.edtUrlTarget = new System.Windows.Forms.TextBox();
			this.edtUrlHref = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbLinks = new System.Windows.Forms.ListBox();
			this.tabImages = new System.Windows.Forms.TabPage();
			this.edtImageHeight = new System.Windows.Forms.TextBox();
			this.edtImageWidth = new System.Windows.Forms.TextBox();
			this.edtImageAlt = new System.Windows.Forms.TextBox();
			this.edtImageSrc = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbImages = new System.Windows.Forms.ListBox();
			this.tabForms = new System.Windows.Forms.TabPage();
			this.edtFormMethod = new System.Windows.Forms.TextBox();
			this.edtFormName = new System.Windows.Forms.TextBox();
			this.edtFormEncType = new System.Windows.Forms.TextBox();
			this.edtFormAction = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lbFormControls = new System.Windows.Forms.ListBox();
			this.lbForms = new System.Windows.Forms.ListBox();
			this.tabText = new System.Windows.Forms.TabPage();
			this.lbText = new System.Windows.Forms.ListBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.htmlParser1 = new CleverComponents.InetSuite.HtmlParser();
			this.tabControl.SuspendLayout();
			this.tabLinks.SuspendLayout();
			this.tabImages.SuspendLayout();
			this.tabForms.SuspendLayout();
			this.tabText.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabLinks);
			this.tabControl.Controls.Add(this.tabImages);
			this.tabControl.Controls.Add(this.tabForms);
			this.tabControl.Controls.Add(this.tabText);
			this.tabControl.Location = new System.Drawing.Point(16, 16);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(480, 272);
			this.tabControl.TabIndex = 0;
			// 
			// tabLinks
			// 
			this.tabLinks.Controls.Add(this.edtUrlName);
			this.tabLinks.Controls.Add(this.edtUrlTarget);
			this.tabLinks.Controls.Add(this.edtUrlHref);
			this.tabLinks.Controls.Add(this.label4);
			this.tabLinks.Controls.Add(this.label3);
			this.tabLinks.Controls.Add(this.label2);
			this.tabLinks.Controls.Add(this.label1);
			this.tabLinks.Controls.Add(this.lbLinks);
			this.tabLinks.Location = new System.Drawing.Point(4, 22);
			this.tabLinks.Name = "tabLinks";
			this.tabLinks.Size = new System.Drawing.Size(472, 246);
			this.tabLinks.TabIndex = 0;
			this.tabLinks.Text = "Links";
			// 
			// edtUrlName
			// 
			this.edtUrlName.Location = new System.Drawing.Point(368, 216);
			this.edtUrlName.Name = "edtUrlName";
			this.edtUrlName.ReadOnly = true;
			this.edtUrlName.Size = new System.Drawing.Size(88, 20);
			this.edtUrlName.TabIndex = 3;
			// 
			// edtUrlTarget
			// 
			this.edtUrlTarget.Location = new System.Drawing.Point(272, 216);
			this.edtUrlTarget.Name = "edtUrlTarget";
			this.edtUrlTarget.ReadOnly = true;
			this.edtUrlTarget.Size = new System.Drawing.Size(88, 20);
			this.edtUrlTarget.TabIndex = 2;
			// 
			// edtUrlHref
			// 
			this.edtUrlHref.Location = new System.Drawing.Point(16, 216);
			this.edtUrlHref.Name = "edtUrlHref";
			this.edtUrlHref.ReadOnly = true;
			this.edtUrlHref.Size = new System.Drawing.Size(248, 20);
			this.edtUrlHref.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(368, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Name";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(272, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Target";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "URL";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Link Tags";
			// 
			// lbLinks
			// 
			this.lbLinks.Location = new System.Drawing.Point(16, 32);
			this.lbLinks.Name = "lbLinks";
			this.lbLinks.Size = new System.Drawing.Size(440, 160);
			this.lbLinks.TabIndex = 0;
			this.lbLinks.SelectedIndexChanged += new System.EventHandler(this.lbLinks_SelectedIndexChanged);
			// 
			// tabImages
			// 
			this.tabImages.Controls.Add(this.edtImageHeight);
			this.tabImages.Controls.Add(this.edtImageWidth);
			this.tabImages.Controls.Add(this.edtImageAlt);
			this.tabImages.Controls.Add(this.edtImageSrc);
			this.tabImages.Controls.Add(this.label9);
			this.tabImages.Controls.Add(this.label8);
			this.tabImages.Controls.Add(this.label7);
			this.tabImages.Controls.Add(this.label6);
			this.tabImages.Controls.Add(this.label5);
			this.tabImages.Controls.Add(this.lbImages);
			this.tabImages.Location = new System.Drawing.Point(4, 22);
			this.tabImages.Name = "tabImages";
			this.tabImages.Size = new System.Drawing.Size(472, 246);
			this.tabImages.TabIndex = 1;
			this.tabImages.Text = "Images";
			// 
			// edtImageHeight
			// 
			this.edtImageHeight.Location = new System.Drawing.Point(328, 216);
			this.edtImageHeight.Name = "edtImageHeight";
			this.edtImageHeight.ReadOnly = true;
			this.edtImageHeight.Size = new System.Drawing.Size(128, 20);
			this.edtImageHeight.TabIndex = 4;
			// 
			// edtImageWidth
			// 
			this.edtImageWidth.Location = new System.Drawing.Point(328, 168);
			this.edtImageWidth.Name = "edtImageWidth";
			this.edtImageWidth.ReadOnly = true;
			this.edtImageWidth.Size = new System.Drawing.Size(128, 20);
			this.edtImageWidth.TabIndex = 2;
			// 
			// edtImageAlt
			// 
			this.edtImageAlt.Location = new System.Drawing.Point(16, 216);
			this.edtImageAlt.Name = "edtImageAlt";
			this.edtImageAlt.ReadOnly = true;
			this.edtImageAlt.Size = new System.Drawing.Size(304, 20);
			this.edtImageAlt.TabIndex = 3;
			// 
			// edtImageSrc
			// 
			this.edtImageSrc.Location = new System.Drawing.Point(16, 168);
			this.edtImageSrc.Name = "edtImageSrc";
			this.edtImageSrc.ReadOnly = true;
			this.edtImageSrc.Size = new System.Drawing.Size(304, 20);
			this.edtImageSrc.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(328, 200);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 5;
			this.label9.Text = "Height";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(328, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 4;
			this.label8.Text = "Width";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Alt";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Src";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 1;
			this.label5.Text = "Image Tags";
			// 
			// lbImages
			// 
			this.lbImages.Location = new System.Drawing.Point(16, 32);
			this.lbImages.Name = "lbImages";
			this.lbImages.Size = new System.Drawing.Size(440, 108);
			this.lbImages.TabIndex = 0;
			this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
			// 
			// tabForms
			// 
			this.tabForms.Controls.Add(this.edtFormMethod);
			this.tabForms.Controls.Add(this.edtFormName);
			this.tabForms.Controls.Add(this.edtFormEncType);
			this.tabForms.Controls.Add(this.edtFormAction);
			this.tabForms.Controls.Add(this.label15);
			this.tabForms.Controls.Add(this.label14);
			this.tabForms.Controls.Add(this.label13);
			this.tabForms.Controls.Add(this.label12);
			this.tabForms.Controls.Add(this.label11);
			this.tabForms.Controls.Add(this.label10);
			this.tabForms.Controls.Add(this.lbFormControls);
			this.tabForms.Controls.Add(this.lbForms);
			this.tabForms.Location = new System.Drawing.Point(4, 22);
			this.tabForms.Name = "tabForms";
			this.tabForms.Size = new System.Drawing.Size(472, 246);
			this.tabForms.TabIndex = 2;
			this.tabForms.Text = "Forms";
			// 
			// edtFormMethod
			// 
			this.edtFormMethod.Location = new System.Drawing.Point(312, 216);
			this.edtFormMethod.Name = "edtFormMethod";
			this.edtFormMethod.ReadOnly = true;
			this.edtFormMethod.Size = new System.Drawing.Size(144, 20);
			this.edtFormMethod.TabIndex = 5;
			// 
			// edtFormName
			// 
			this.edtFormName.Location = new System.Drawing.Point(312, 168);
			this.edtFormName.Name = "edtFormName";
			this.edtFormName.ReadOnly = true;
			this.edtFormName.Size = new System.Drawing.Size(144, 20);
			this.edtFormName.TabIndex = 3;
			// 
			// edtFormEncType
			// 
			this.edtFormEncType.Location = new System.Drawing.Point(16, 216);
			this.edtFormEncType.Name = "edtFormEncType";
			this.edtFormEncType.ReadOnly = true;
			this.edtFormEncType.Size = new System.Drawing.Size(280, 20);
			this.edtFormEncType.TabIndex = 4;
			// 
			// edtFormAction
			// 
			this.edtFormAction.Location = new System.Drawing.Point(16, 168);
			this.edtFormAction.Name = "edtFormAction";
			this.edtFormAction.ReadOnly = true;
			this.edtFormAction.Size = new System.Drawing.Size(280, 20);
			this.edtFormAction.TabIndex = 2;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(312, 200);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 7;
			this.label15.Text = "Method";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(312, 152);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 6;
			this.label14.Text = "Form Name";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(16, 200);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 5;
			this.label13.Text = "Enc Type";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(16, 152);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 4;
			this.label12.Text = "Action";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(312, 8);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 3;
			this.label11.Text = "Controls";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 8);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Form Tags";
			// 
			// lbFormControls
			// 
			this.lbFormControls.Location = new System.Drawing.Point(312, 32);
			this.lbFormControls.Name = "lbFormControls";
			this.lbFormControls.Size = new System.Drawing.Size(144, 108);
			this.lbFormControls.TabIndex = 1;
			// 
			// lbForms
			// 
			this.lbForms.Location = new System.Drawing.Point(16, 32);
			this.lbForms.Name = "lbForms";
			this.lbForms.Size = new System.Drawing.Size(280, 108);
			this.lbForms.TabIndex = 0;
			this.lbForms.SelectedIndexChanged += new System.EventHandler(this.lbForms_SelectedIndexChanged);
			// 
			// tabText
			// 
			this.tabText.Controls.Add(this.lbText);
			this.tabText.Location = new System.Drawing.Point(4, 22);
			this.tabText.Name = "tabText";
			this.tabText.Size = new System.Drawing.Size(472, 246);
			this.tabText.TabIndex = 3;
			this.tabText.Text = "Text";
			// 
			// lbText
			// 
			this.lbText.Location = new System.Drawing.Point(16, 16);
			this.lbText.Name = "lbText";
			this.lbText.Size = new System.Drawing.Size(440, 212);
			this.lbText.TabIndex = 0;
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(16, 296);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "Open File";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "Html Files|*.htm|All Files|*.*";
			// 
			// htmlParser1
			// 
			this.htmlParser1.ParseMethod = CleverComponents.InetSuite.ParseMethod.All;
			this.htmlParser1.ParseTag += new CleverComponents.InetSuite.ParseTagEventHandler(this.htmlParser1_ParseTag);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 334);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.tabControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Html Parser sample";
			this.tabControl.ResumeLayout(false);
			this.tabLinks.ResumeLayout(false);
			this.tabLinks.PerformLayout();
			this.tabImages.ResumeLayout(false);
			this.tabImages.PerformLayout();
			this.tabForms.ResumeLayout(false);
			this.tabForms.PerformLayout();
			this.tabText.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() {
			Application.Run(new MainForm());
		}

		void AssignListBox(HtmlTagList source, ListBox listBox) {
			listBox.Items.Clear();
			foreach(HtmlTag tag in source)
				listBox.Items.Add(tag.TagSource);
		}

		void btnOpen_Click(object sender, System.EventArgs e) {
			if(openFileDialog.ShowDialog() == DialogResult.OK) {
				lbText.Items.Clear();
				StreamReader reader = File.OpenText(openFileDialog.FileName);
				htmlParser1.Parse(reader.ReadToEnd());
				AssignListBox(htmlParser1.Links, lbLinks);
				AssignListBox(htmlParser1.Images, lbImages);
				AssignListBox(htmlParser1.Forms, lbForms);
			}
		}

		void lbLinks_SelectedIndexChanged(object sender, System.EventArgs e) {
			HtmlLink item = htmlParser1.Links[lbLinks.SelectedIndex];
			edtUrlHref.Text = item.Href;
			edtUrlTarget.Text = item.Target;
			edtUrlName.Text = item.Name;
		}

		void lbImages_SelectedIndexChanged(object sender, System.EventArgs e) {
			HtmlImage item = htmlParser1.Images[lbImages.SelectedIndex];
			edtImageSrc.Text = item.Src;
			edtImageAlt.Text = item.Alt;
			edtImageWidth.Text = item.Width.ToString();
			edtImageHeight.Text = item.Height.ToString();
		}

		void lbForms_SelectedIndexChanged(object sender, System.EventArgs e) {
			HtmlForm item = htmlParser1.Forms[lbForms.SelectedIndex];
			edtFormAction.Text = item.Action;
			edtFormEncType.Text = item.EncType;
			edtFormName.Text = item.FormName;
			edtFormMethod.Text = item.Method;
			AssignListBox(item.Controls, lbFormControls);
		}

		private void htmlParser1_ParseTag(object sender, CleverComponents.InetSuite.ParseTagEventArgs e) {
			if(e.Tag.IsText && !e.Tag.Text.Trim().Equals(""))
				lbText.Items.Add(e.Tag.Text);
		}
	}
}
