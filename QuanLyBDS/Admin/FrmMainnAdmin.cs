﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.Admin
{
    public partial class FrmMainnAdmin : Form
    {
        public FrmMainnAdmin()
        {
            InitializeComponent();
        }
        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnNhanvien.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmQLNhanVien"))
            {
                FrmQLNhanVien nv = new FrmQLNhanVien();
                nv.TopLevel = false;
                panelAdmin.Controls.Add(nv);
                nv.Show();
                nv.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmQLNhanVien");
            }
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnKhachhang.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmQLKhachHang_Admin"))
            {
                FrmQLKhachHang_Admin kh = new FrmQLKhachHang_Admin();
                kh.TopLevel = false;
                panelAdmin.Controls.Add(kh);
                kh.Show();
                kh.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmQLKhachHang_Admin");
            }
        }

        private void btnDuyetbai_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDuyetbai.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDuyetbai_Admin"))
            {
                FrmDuyetbai_Admin duyetbai = new FrmDuyetbai_Admin();
                duyetbai.TopLevel = false;
                panelAdmin.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDuyetbai_Admin");
            }
        }

        private void btnDaduyet_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDaduyet.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDaduyet_Admin"))
            {
                FrmDaduyet_Admin duyetbai = new FrmDaduyet_Admin();
                duyetbai.TopLevel = false;
                panelAdmin.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDaduyet_Admin");
            }
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnHotro.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmHotro_Admin"))
            {
                FrmHotro_Admin duyetbai = new FrmHotro_Admin();
                duyetbai.TopLevel = false;
                panelAdmin.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmHotro_Admin");
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnThongke.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmThongKe"))
            {
                FrmThongKe duyetbai = new FrmThongKe();
                duyetbai.TopLevel = false;
                panelAdmin.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmThongKe");
            }
        }

        private void btnDoimatkhau_Click(object sender, EventArgs e)
        {
            ResetButton();
            btnDoimatkhau.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDoimatkhau_Admin"))
            {
                FrmDoimatkhau_Admin duyetbai = new FrmDoimatkhau_Admin();
                duyetbai.TopLevel = false;
                panelAdmin.Controls.Add(duyetbai);
                duyetbai.Show();
                duyetbai.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmDoimatkhau_Admin");
            }
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Quản lý bất động sản";
            FrmMain.session = 0;
            this.Close();
        }
        #region UI
        void ResetButton()
        {
            btnNhanvien.BackColor = SystemColors.Highlight;
            btnKhachhang.BackColor = SystemColors.Highlight;
            btnDuyetbai.BackColor = SystemColors.Highlight;
            btnDaduyet.BackColor = SystemColors.Highlight;
            btnHotro.BackColor = SystemColors.Highlight;
            btnDoimatkhau.BackColor = SystemColors.Highlight;
            btnThongke.BackColor = SystemColors.Highlight;
        }
        private bool CheckExistForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            var check = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // Show form lên trên cùng của form cha
        private void ActiveChildForm(string name)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == name)
                {
                    frm.BringToFront();
                    break;
                }
            }
        }
        #endregion
    }
}
