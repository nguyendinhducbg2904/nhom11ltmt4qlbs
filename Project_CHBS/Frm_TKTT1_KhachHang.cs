using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DTO;
using BUS;

namespace Project_CHBS
{
    public partial class Frm_TKTT1_KhachHang : Form
    {
        public Frm_TKTT1_KhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang kh = new BUS_KhachHang();
        private void cmdKetQua_Click(object sender, EventArgs e)
        {
            string sql = "Select *From KhachHang Where TinhTrang = N'" + txtTinhTrang.Text + "'";
            DataTable dt = new DataTable();
            dt = kh.Load2(sql);
            dataGridView1.DataSource = kh.Load2(sql);
        }
    }
}
