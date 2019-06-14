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
    public partial class Frm_Sach : Form
    {
        public Frm_Sach()
        {
            InitializeComponent();
        }

        BUS_Sach s = new BUS_Sach();

        private void Frm_Sach_Load(object sender, EventArgs e)
        {
            string sql = " Select *From Sach ";
            dataGridView1.DataSource = s.Load2(sql);
            txtMaS.Text = "";
            txtTieuDe.Text = "";
            txtTacGia.Text = "";
            txtNhaXB.Text = "";
            txtSoLuong.Text = "";
            txtGiaBan.Text = "";
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach(txtMaS.Text, txtTieuDe.Text, txtTacGia.Text, txtNhaXB.Text, Convert.ToInt32(txtSoLuong.Text), float.Parse(txtGiaBan.Text));
            s.Insert(ob);
            Frm_Sach_Load(sender, e);
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach(txtMaS.Text, txtTieuDe.Text, txtTacGia.Text, txtNhaXB.Text, Convert.ToInt32(txtSoLuong.Text), float.Parse(txtGiaBan.Text));
            s.Update(ob);
            Frm_Sach_Load(sender, e);
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            Sach ob = new Sach(txtMaS.Text, txtTieuDe.Text, txtTacGia.Text, txtNhaXB.Text, Convert.ToInt32(txtSoLuong.Text), float.Parse(txtGiaBan.Text));
            s.Delete(ob);
            Frm_Sach_Load(sender, e);
        }

        private void dt(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaS.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTieuDe.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTacGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtNhaXB.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSoLuong.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtGiaBan.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
        }
    }
}
