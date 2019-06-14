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
    public partial class Frm_KhachHang : Form
    {
        public Frm_KhachHang()
        {
            InitializeComponent();
        }

        BUS_KhachHang kh = new BUS_KhachHang();

        private void Frm_KhachHang_Load(object sender, EventArgs e)
        {
            string sql = "Select *From KhachHang";
            DataTable dt = new DataTable();
            dt = kh.Load2(sql);
            dataGridView1.DataSource = kh.Load2(sql);
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
            txtTinhTrang.Text = "";
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            KhachHang ob = new KhachHang(txtMaKH.Text, txtTenKH.Text, Convert.ToInt32(txtDienThoai.Text), txtDiaChi.Text, txtTinhTrang.Text);
            kh.Insert(ob);
            Frm_KhachHang_Load(sender, e);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            KhachHang ob = new KhachHang(txtMaKH.Text, txtTenKH.Text, Convert.ToInt32(txtDienThoai.Text), txtDiaChi.Text, txtTinhTrang.Text);
            kh.Update(ob);
            Frm_KhachHang_Load(sender, e);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            KhachHang ob = new KhachHang(txtMaKH.Text, txtTenKH.Text, Convert.ToInt32(txtDienThoai.Text), txtDiaChi.Text, txtTinhTrang.Text);
            kh.Delete(ob);
            Frm_KhachHang_Load(sender, e);
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDienThoai.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtTinhTrang.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
    }
}
