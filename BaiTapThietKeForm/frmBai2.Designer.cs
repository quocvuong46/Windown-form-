﻿namespace BaiTapThietKeForm
{
	partial class frmBai2
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.btnChonHang = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnBoHang = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnTinhTien = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblTongTien = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnChonHang);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 41);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(432, 357);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Danh sách hàng hóa ";
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn Phím",
            "Máy in",
            "USB Kingmax"});
			this.listBox1.Location = new System.Drawing.Point(42, 49);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(236, 184);
			this.listBox1.TabIndex = 3;
			// 
			// btnChonHang
			// 
			this.btnChonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChonHang.Location = new System.Drawing.Point(284, 119);
			this.btnChonHang.Name = "btnChonHang";
			this.btnChonHang.Size = new System.Drawing.Size(134, 36);
			this.btnChonHang.TabIndex = 4;
			this.btnChonHang.Text = "Chọn hàng >";
			this.btnChonHang.UseVisualStyleBackColor = true;
			this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblTongTien);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.btnTinhTien);
			this.panel2.Controls.Add(this.btnBoHang);
			this.panel2.Controls.Add(this.listBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(450, 41);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(478, 357);
			this.panel2.TabIndex = 1;
			// 
			// btnBoHang
			// 
			this.btnBoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBoHang.Location = new System.Drawing.Point(14, 119);
			this.btnBoHang.Name = "btnBoHang";
			this.btnBoHang.Size = new System.Drawing.Size(125, 36);
			this.btnBoHang.TabIndex = 4;
			this.btnBoHang.Text = "< Bỏ hàng";
			this.btnBoHang.UseVisualStyleBackColor = true;
			this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Location = new System.Drawing.Point(145, 53);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(236, 164);
			this.listBox2.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(140, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Các mặt hàng khách mua ";
			// 
			// btnTinhTien
			// 
			this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTinhTien.Location = new System.Drawing.Point(201, 223);
			this.btnTinhTien.Name = "btnTinhTien";
			this.btnTinhTien.Size = new System.Drawing.Size(125, 36);
			this.btnTinhTien.TabIndex = 5;
			this.btnTinhTien.Text = "Tính tiền";
			this.btnTinhTien.UseVisualStyleBackColor = true;
			this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 319);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(218, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Tổng tiền thanh toán:";
			// 
			// lblTongTien
			// 
			this.lblTongTien.AutoSize = true;
			this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTongTien.ForeColor = System.Drawing.Color.Red;
			this.lblTongTien.Location = new System.Drawing.Point(265, 319);
			this.lblTongTien.Name = "lblTongTien";
			this.lblTongTien.Size = new System.Drawing.Size(0, 25);
			this.lblTongTien.TabIndex = 7;
			// 
			// frmBai2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(929, 442);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "frmBai2";
			this.Text = "Bán hàng";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnChonHang;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnBoHang;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTongTien;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnTinhTien;
	}
}