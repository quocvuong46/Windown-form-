﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
	public partial class frmBai3 : Form
	{
		List<string> list = new List<string>();
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var tu = txtTuMoi.Text;
			var nghia = txtNghia.Text;
			lbTuMoi.Items.Add(tu);
			list.Add(nghia);
			txtTuMoi.Focus();
			txtTuMoi.Text = "";
			txtNghia.Text = "";
			lbTuMoi.SelectedIndex = lbTuMoi.Items.Count - 1;
			txtHienThiNghia.Text = nghia;

		}

		private void lbTuMoi_SelectedIndexChanged(object sender, EventArgs e)
		{
			var stt = lbTuMoi.SelectedIndex;

			txtHienThiNghia.Text = list[stt];
		}
	}
}
