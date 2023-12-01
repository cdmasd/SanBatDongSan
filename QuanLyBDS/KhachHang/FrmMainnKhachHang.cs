using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBDS.KhachHang
{
    public partial class FrmMainnKhachHang : Form
    {
        public FrmMainnKhachHang()
        {
            InitializeComponent();
        }

        void ResetColor()
        {
            btnThongtin.BackColor = SystemColors.Highlight;
            btnDangbds.BackColor = SystemColors.Highlight;
            btnDanhsachbaidang.BackColor = SystemColors.Highlight;
            btnHotro.BackColor = SystemColors.Highlight;
            btnDoimk.BackColor = SystemColors.Highlight;
            btnNaptien.BackColor = SystemColors.Highlight;
        }
        private void btnThongtin_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnThongtin.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmThongTin"))
            {
                FrmThongTin tt = new FrmThongTin();
                tt.TopLevel = false;
                panelKhachHang.Controls.Add(tt);
                tt.Show();
                tt.BringToFront();
            }
            else
            {
                ActiveChildForm("FrmThongTin");
            }
        }

        private void btnDangbds_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDangbds.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmBaiDang"))
            {
                FrmBaiDang bd = new FrmBaiDang();
                bd.TopLevel = false;
                panelKhachHang.Controls.Add(bd);
                bd.Show();
                bd.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmBaiDang");
            }
        }

        private void btnHotro_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnHotro.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmHoTro"))
            {
                FrmHoTro hotro = new FrmHoTro();
                hotro.TopLevel = false;
                panelKhachHang.Controls.Add(hotro);
                hotro.Show();
                hotro.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmHoTro");
            }
        }

        private void btnDoimk_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDoimk.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDoiMatKhau"))
            {
                FrmDoiMatKhau dmk = new FrmDoiMatKhau();
                dmk.TopLevel = false;
                panelKhachHang.Controls.Add(dmk);
                dmk.Show();
                dmk.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmDoiMatKhau");
            }
        }
        // Kiểm tra form đã tồn tại trước khi mở
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

        private void btnNaptien_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnNaptien.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmNapTien"))
            {
                FrmNapTien dmk = new FrmNapTien();
                dmk.TopLevel = false;
                panelKhachHang.Controls.Add(dmk);
                dmk.Show();
                dmk.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmNapTien");
            }
        }
        private void btnDanhsachbaidang_Click(object sender, EventArgs e)
        {
            ResetColor();
            btnDanhsachbaidang.BackColor = SystemColors.ActiveCaption;
            if (!CheckExistForm("FrmDanhSachBaiDang"))
            {
                FrmDanhSachBaiDang listbd = new FrmDanhSachBaiDang();
                listbd.TopLevel = false;
                panelKhachHang.Controls.Add(listbd);
                listbd.Show();
                listbd.BringToFront();

            }
            else
            {
                ActiveChildForm("FrmDanhSachBaiDang");
            }
        }
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            FrmMain.mail = "Quản lý bất động sản";
            FrmMain.session = 0;
            this.Close();
        }
    }
}
