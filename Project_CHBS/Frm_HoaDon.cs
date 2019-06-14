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
    public partial class Frm_HoaDon : Form
    {
        public Frm_HoaDon()
        {
            InitializeComponent();
        }

        BUS_HoaDon hd = new BUS_HoaDon();

        private void Frm_HoaDon_Load(object sender, EventArgs e)
        {
            string sql = " Select *From HoaDon";
            DataTable dt = new DataTable();
            dt = hd.Load2(sql);
            dataGridView1.DataSource = hd.Load2(sql);
            txtSoHD.Text = "";
            dtNgayMua.Text = "";
            dtNgayHetHanBaoHanh.Text = "";

            string sql1 = " Select *From Sach";
            //DataTable dt = new DataTable();
            dt = hd.Load2(sql1);
            comMaS.DataSource = dt;
            comMaS.DisplayMember = "MaS";
            comMaS.ValueMember = "MaS";

            string sql2 = " Select *From KhachHang";
            //DataTable dt = new DataTable();
            dt = hd.Load2(sql2);
            comMaKH.DataSource = dt;
            comMaKH.DisplayMember = "MaKH";
            comMaKH.ValueMember = "MaKH";

            string sql3 = " Select *From NhanVien";
            //DataTable dt = new DataTable();
            dt = hd.Load2(sql3);
            comMaNV.DataSource = dt;
            comMaNV.DisplayMember = "MaNV";
            comMaNV.ValueMember = "MaNV";

            txtMucGiamGia.Text = "";

            string sql4 = " Select *From Sach";
            //DataTable dt = new DataTable();
            dt = hd.Load2(sql4);
            comGiaBan.DataSource = dt;
            comGiaBan.DisplayMember = "GiaBan";
            comGiaBan.ValueMember = "GiaBan";

            txtSoLuong.Text = "";
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(txtSoHD.Text, Convert.ToDateTime(dtNgayMua.Value), Convert.ToDateTime(dtNgayHetHanBaoHanh.Value), comMaS.Text, comMaKH.Text, comMaNV.Text, float.Parse(txtMucGiamGia.Text),float.Parse(comGiaBan.Text), Convert.ToInt32(txtSoLuong.Text));
            hd.Insert(ob);
            Frm_HoaDon_Load(sender, e);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(txtSoHD.Text, Convert.ToDateTime(dtNgayMua.Value), Convert.ToDateTime(dtNgayHetHanBaoHanh.Value), comMaS.Text, comMaKH.Text, comMaNV.Text, float.Parse(txtMucGiamGia.Text), float.Parse(comGiaBan.Text), Convert.ToInt32(txtSoLuong.Text));
            hd.Update(ob);
            Frm_HoaDon_Load(sender, e);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            HoaDon ob = new HoaDon(txtSoHD.Text, Convert.ToDateTime(dtNgayMua.Value), Convert.ToDateTime(dtNgayHetHanBaoHanh.Value), comMaS.Text, comMaKH.Text, comMaNV.Text, float.Parse(txtMucGiamGia.Text), float.Parse(comGiaBan.Text), Convert.ToInt32(txtSoLuong.Text));
            hd.Delete(ob);
            Frm_HoaDon_Load(sender, e);
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtSoHD.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            dtNgayMua.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dtNgayHetHanBaoHanh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comMaS.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            comMaKH.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            comMaNV.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtMucGiamGia.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            comGiaBan.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
        }
    }
}
