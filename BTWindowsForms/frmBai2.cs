﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsForms
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = cbbTenHang.SelectedIndex;
            switch (stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "2000000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;

            }
        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            int donGia=int.Parse(txtDonGia.Text);
            int soluong=int.Parse(txtSoLuong.Text);
            double thanhTien = donGia * soluong;

            if (rdChuyenkhoan.Checked)
                thanhTien =donGia*soluong*0.95;
          
            lblSotien.Text = thanhTien.ToString();
        }

    }
}
