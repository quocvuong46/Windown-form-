﻿namespace BTWindowsForms
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.rdTongN = new System.Windows.Forms.RadioButton();
            this.btnXemKq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số n=";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(134, 36);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(177, 20);
            this.txtSoA.TabIndex = 1;
            this.txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(134, 70);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(177, 20);
            this.txtSoB.TabIndex = 1;
            this.txtSoB.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(134, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(134, 112);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(177, 20);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongN);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Location = new System.Drawing.Point(96, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Location = new System.Drawing.Point(25, 28);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(111, 17);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng của a,b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            // 
            // rdTongN
            // 
            this.rdTongN.AutoSize = true;
            this.rdTongN.Location = new System.Drawing.Point(25, 61);
            this.rdTongN.Name = "rdTongN";
            this.rdTongN.Size = new System.Drawing.Size(124, 17);
            this.rdTongN.TabIndex = 0;
            this.rdTongN.TabStop = true;
            this.rdTongN.Text = "Tính tổng từ 1 đến n";
            this.rdTongN.UseVisualStyleBackColor = true;
            // 
            // btnXemKq
            // 
            this.btnXemKq.Location = new System.Drawing.Point(157, 327);
            this.btnXemKq.Name = "btnXemKq";
            this.btnXemKq.Size = new System.Drawing.Size(75, 23);
            this.btnXemKq.TabIndex = 3;
            this.btnXemKq.Text = "Xem kết quả";
            this.btnXemKq.UseVisualStyleBackColor = true;
            this.btnXemKq.Click += new System.EventHandler(this.btnXemKq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả là:";
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.Location = new System.Drawing.Point(187, 366);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(0, 16);
            this.lblKetqua.TabIndex = 0;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.btnXemKq);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.RadioButton rdTongN;
        private System.Windows.Forms.Button btnXemKq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetqua;
    }
}