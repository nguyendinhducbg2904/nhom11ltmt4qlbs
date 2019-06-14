using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CHBS
{
    public partial class Project_Start : Form
    {
        public Project_Start()
        {
            InitializeComponent();
        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Sach s = new Frm_Sach();
            s.Show();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_NhanVien nv = new Frm_NhanVien();
            nv.Show();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_KhachHang kh = new Frm_KhachHang();
            kh.Show();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HoaDon hd = new Frm_HoaDon();
            hd.Show();
        }

        private void thôngTinKháchHàngTheoTìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_TKTT1_KhachHang f = new Frm_TKTT1_KhachHang();
            f.Show();
        }
    }
}
