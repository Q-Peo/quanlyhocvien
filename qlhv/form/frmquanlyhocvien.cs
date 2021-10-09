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
    public partial class frmquanlyhocvien : Form
    {
        public frmquanlyhocvien()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        public void hienthi()
        {
            cn.myconnect();
            string sql = "SELECT * FROM [qlhv].[dbo].[HocVien]";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                if ((chkid.Checked == false && chkGioiTinh.Checked == false && chkTen.Checked == false) || (chkid.Checked == true && chkGioiTinh.Checked == true && chkTen.Checked == true) || (chkGioiTinh.Checked == true && chkid.Checked == true) || (chkGioiTinh.Checked == true && chkTen.Checked == true) || (chkid.Checked == true && chkTen.Checked == true))
                {
                    MessageBox.Show("Chon 1 cach tim kiem!!");
                }
                else
                {
                    if (chkTen.Checked == true)
                    {
                        string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where [TenHV] LIKE N'%" + txttimkiemten.Text + "%'";
                        cn.timkiemthongtintheoTenhv(txttimkiemten.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                    if (chkid.Checked == true)
                    {
                        string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where MaHV = '" + txttkid.Text + "'";
                        cn.timkiemthongtintheoIdhv(txttkid.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }

                    if (chkGioiTinh.Checked == true)
                    {
                        string sql = "SELECT [MaHV],[TenHV],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiLop],[MaLop] FROM [qlhv].[dbo].[HocVien] where [GioiTinh] LIKE N'" + @cbtimkiemgioitinh.Text + "'";
                        cn.timkiemthongtintheoGioiTinhhv(cbtimkiemgioitinh.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi!!");
            }
            cn.myclose();
        }

        private void frmquanlyhocvien_Load(object sender, EventArgs e)
        {
            hienthi();
            txttkid.Enabled = txttimkiemten.Enabled = cbtimkiemgioitinh.Enabled = false;
        }

        #region checkbox
        private void chkid_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkid.Checked == true)
                txttkid.Enabled = true;
            else txttkid.Enabled = false;
        }

        private void chkTen_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
                txttimkiemten.Enabled = true;
            else txttimkiemten.Enabled = false;
        }

        private void chkGioiTinh_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkGioiTinh.Checked == true)
                cbtimkiemgioitinh.Enabled = true;
            else cbtimkiemgioitinh.Enabled = false;
        }
        #endregion

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txttkid.Text = txttimkiemten.Text = cbtimkiemgioitinh.Text = "";
            chkid.Checked = chkTen.Checked = chkGioiTinh.Checked = false;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT * FROM [qlhv].[dbo].[HocVien] where MaHV = '" + txtid.Text + "'";
                    cn.xoathongtinhvformqlhv(txtid.Text);
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv.DataSource;
            idx = dgv.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            txtid.Text = hang["MaHV"].ToString();
        }


    }
}
