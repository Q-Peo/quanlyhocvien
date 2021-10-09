using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlhv.form
{
    public partial class frmtiepnhanhocvien : Form
    {
        public frmtiepnhanhocvien()
        {
            InitializeComponent();
        }

        private void frmquanlyhocvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlhvDataSet7.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter2.Fill(this.qlhvDataSet7.Lop);
            // TODO: This line of code loads data into the 'qlhvDataSet3.LoaiLop' table. You can move, or remove it, as needed.
            this.loaiLopTableAdapter1.Fill(this.qlhvDataSet3.LoaiLop);
            // TODO: This line of code loads data into the 'qlhvDataSet2.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter1.Fill(this.qlhvDataSet2.Lop);
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = txtsdt.Enabled = txtTen.Enabled = txtdiachi.Enabled = cbml.Enabled = cbmllop.Enabled = cbgioitinh.Enabled = dtns.Enabled = false;
            hienthi();
        }
        connect cn = new connect();
        public void hienthi()
        {
            cn.myconnect();
            string sql = "SELECT * FROM [qlhv].[dbo].[HocVien]";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lbsohocvien.Text = string.Format("Số học viên: {0}", dgv.Rows.Count);
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lbsohocvien.Text = string.Format("Số học viên: {0}", dgv.Rows.Count);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv.DataSource;
            idx = dgv.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            txtmhv.Text = hang["MaHV"].ToString();
            txtTen.Text = hang["TenHV"].ToString();
            cbgioitinh.Text = hang["GioiTinh"].ToString();
            dtns.Value = Convert.ToDateTime(hang["NgaySinh"].ToString());
            txtdiachi.Text = hang["DiaChi"].ToString();
            txtsdt.Text = hang["SDT"].ToString();
            cbml.Text = hang["MaLop"].ToString();
            cbmllop.Text = hang["MaLoaiLop"].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            { 
                cn.myconnect();
                string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where MaHV = '" + txtmhv.Text + "'";
                cn.themthongtinhv(txtmhv.Text, txtTen.Text, cbgioitinh.Text, dtns.Value, txtdiachi.Text, txtsdt.Text, cbmllop.Text, cbml.Text);
                MessageBox.Show("them thanh cong");
                dgv.DataSource = cn.Taobang(sql);
            }
            catch
            {
                MessageBox.Show("them khong thanh cong");
            }
            cn.myclose();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac chan muon thay doi ?", "Thong bao",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where MaHV = '" + txtmhv.Text + "'";
                    cn.suathongtinhv(txtmhv.Text, txtTen.Text, cbgioitinh.Text, dtns.Value, txtdiachi.Text, txtsdt.Text, cbmllop.Text, cbml.Text);
                    MessageBox.Show("sua thanh cong");
                    dgv.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("sua khong thanh cong");
                }
                cn.myclose();
            }   
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where MaHV = '" + txtmhv.Text + "'";
                    cn.xoathongtinhv(txtmhv.Text, txtTen.Text, cbgioitinh.Text, dtns.Value, txtdiachi.Text, txtsdt.Text, cbmllop.Text, cbml.Text);
                    MessageBox.Show("xoa thanh cong");
                    dgv.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("xoa khong thanh cong");
                }
                cn.myclose();
                hienthi();
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtmhv.Text = txtsdt.Text = txtTen.Text = txtdiachi.Text = cbml.Text = cbmllop.Text = "";
            cbgioitinh.SelectedIndex = 0;
            dtns.Value = DateTime.Now;
            hienthi();
        }

        private void txtmhv_TextChanged(object sender, EventArgs e)
        {
            if (txtmhv.Text.Trim() == "")
            {
                btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = txtsdt.Enabled = txtTen.Enabled = txtdiachi.Enabled = cbml.Enabled = cbmllop.Enabled = cbgioitinh.Enabled = dtns.Enabled = false;
            }
            else btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = txtsdt.Enabled = txtTen.Enabled = txtdiachi.Enabled = cbml.Enabled = cbmllop.Enabled = cbgioitinh.Enabled = dtns.Enabled = true;
        }
    }
}
