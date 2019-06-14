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
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
        }

        BUS_NhanVien nv = new BUS_NhanVien();
        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            string sql = " Select *From NhanVien";
            DataTable dt = new DataTable();
            dt = nv.Load2(sql);
            dataGridView1.DataSource = nv.Load2(sql);
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            dtNgaySinh.Text = "";
            dtNgayLamViec.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtLuongCoBan.Text = "";
            txtPhuCap.Text = "";
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            NhanVien ob = new NhanVien(txtMaNV.Text, txtTenNV.Text, Convert.ToDateTime(dtNgaySinh.Value), Convert.ToDateTime(dtNgayLamViec.Value), txtDiaChi.Text, Convert.ToInt32(txtDienThoai.Text), float.Parse(txtLuongCoBan.Text), float.Parse(txtPhuCap.Text));
            nv.Insert(ob);
            Frm_NhanVien_Load(sender, e);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            NhanVien ob = new NhanVien(txtMaNV.Text, txtTenNV.Text, Convert.ToDateTime(dtNgaySinh.Value), Convert.ToDateTime(dtNgayLamViec.Value), txtDiaChi.Text, Convert.ToInt32(txtDienThoai.Text), float.Parse(txtLuongCoBan.Text), float.Parse(txtPhuCap.Text));
            nv.Update(ob);
            Frm_NhanVien_Load(sender, e);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            NhanVien ob = new NhanVien(txtMaNV.Text, txtTenNV.Text, Convert.ToDateTime(dtNgaySinh.Value), Convert.ToDateTime(dtNgayLamViec.Value), txtDiaChi.Text, Convert.ToInt32(txtDienThoai.Text), float.Parse(txtLuongCoBan.Text), float.Parse(txtPhuCap.Text));
            nv.Delete(ob);
            Frm_NhanVien_Load(sender, e);
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNV.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtNgaySinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dtNgayLamViec.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDienThoai.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtLuongCoBan.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtPhuCap.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }
    }
}
