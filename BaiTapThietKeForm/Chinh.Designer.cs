﻿namespace BaiTapThietKeForm
{
	partial class frmChinh
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.họTênSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênSinhViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(295, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // họTênSinhViênToolStripMenuItem
            // 
            this.họTênSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bài1ToolStripMenuItem,
            this.bài2ToolStripMenuItem,
            this.bài3ToolStripMenuItem,
            this.bài4ToolStripMenuItem});
            this.họTênSinhViênToolStripMenuItem.Name = "họTênSinhViênToolStripMenuItem";
            this.họTênSinhViênToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.họTênSinhViênToolStripMenuItem.Text = "Đỗ Quốc Vương";
            // 
            // bài1ToolStripMenuItem
            // 
            this.bài1ToolStripMenuItem.Image = global::BaiTapThietKeForm.Properties.Resources.write;
            this.bài1ToolStripMenuItem.Name = "bài1ToolStripMenuItem";
            this.bài1ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bài1ToolStripMenuItem.Text = "Bài 1";
            this.bài1ToolStripMenuItem.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // bài2ToolStripMenuItem
            // 
            this.bài2ToolStripMenuItem.Image = global::BaiTapThietKeForm.Properties.Resources.notebook;
            this.bài2ToolStripMenuItem.Name = "bài2ToolStripMenuItem";
            this.bài2ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bài2ToolStripMenuItem.Text = "Bài 2";
            this.bài2ToolStripMenuItem.Click += new System.EventHandler(this.bài2ToolStripMenuItem_Click);
            // 
            // bài3ToolStripMenuItem
            // 
            this.bài3ToolStripMenuItem.Image = global::BaiTapThietKeForm.Properties.Resources.copy_book;
            this.bài3ToolStripMenuItem.Name = "bài3ToolStripMenuItem";
            this.bài3ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bài3ToolStripMenuItem.Text = "Bài 3";
            this.bài3ToolStripMenuItem.Click += new System.EventHandler(this.bài3ToolStripMenuItem_Click);
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Image = global::BaiTapThietKeForm.Properties.Resources.notes;
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.bài4ToolStripMenuItem.Text = "Bài 4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 168);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem họTênSinhViênToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài3ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
	}
}

