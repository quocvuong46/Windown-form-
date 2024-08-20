namespace BaiTapThietKeForm
{
	partial class frmBai3
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtTuMoi = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNghia = new System.Windows.Forms.TextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbTuMoi = new System.Windows.Forms.ListBox();
			this.txtHienThiNghia = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(88, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Từ mới:";
			// 
			// txtTuMoi
			// 
			this.txtTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTuMoi.Location = new System.Drawing.Point(178, 47);
			this.txtTuMoi.Name = "txtTuMoi";
			this.txtTuMoi.Size = new System.Drawing.Size(218, 27);
			this.txtTuMoi.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nghĩa của từ:";
			// 
			// txtNghia
			// 
			this.txtNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNghia.Location = new System.Drawing.Point(178, 90);
			this.txtNghia.Name = "txtNghia";
			this.txtNghia.Size = new System.Drawing.Size(250, 27);
			this.txtNghia.TabIndex = 3;
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(159, 142);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(124, 34);
			this.btnThem.TabIndex = 4;
			this.btnThem.Text = "Thêm từ mới";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(137, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(173, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "DANH SÁCH TỪ MỚI";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(538, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "NGHĨA CỦA TỪ";
			// 
			// lbTuMoi
			// 
			this.lbTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTuMoi.FormattingEnabled = true;
			this.lbTuMoi.ItemHeight = 20;
			this.lbTuMoi.Location = new System.Drawing.Point(92, 223);
			this.lbTuMoi.Name = "lbTuMoi";
			this.lbTuMoi.Size = new System.Drawing.Size(269, 184);
			this.lbTuMoi.TabIndex = 7;
			this.lbTuMoi.SelectedIndexChanged += new System.EventHandler(this.lbTuMoi_SelectedIndexChanged);
			// 
			// txtHienThiNghia
			// 
			this.txtHienThiNghia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHienThiNghia.Location = new System.Drawing.Point(465, 224);
			this.txtHienThiNghia.Multiline = true;
			this.txtHienThiNghia.Name = "txtHienThiNghia";
			this.txtHienThiNghia.Size = new System.Drawing.Size(273, 183);
			this.txtHienThiNghia.TabIndex = 8;
			// 
			// frmBai3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtHienThiNghia);
			this.Controls.Add(this.lbTuMoi);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.txtNghia);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTuMoi);
			this.Controls.Add(this.label1);
			this.Name = "frmBai3";
			this.Text = "Từ điển Anh-Việt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTuMoi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNghia;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lbTuMoi;
		private System.Windows.Forms.TextBox txtHienThiNghia;
	}
}