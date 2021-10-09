using qlhv.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlhv.form
{
    public partial class frmgiaovien : Form
    {
        public frmgiaovien()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                        Database=qlhv;
                                                        Trusted_connection=True;");
        private void frmgiaovien_Load(object sender, EventArgs e)
        {
            hienthi();
            hienthilop();
            txttimkiemMaGV.Enabled = txttimkiemTenGV.Enabled = txttkgt.Enabled = false;
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            hienthi();
            hienthilop();
        }
        public void hienthi()
        {
            cn.myconnect();
            string sql = "SELECT * FROM [qlhv].[dbo].[GiaoVien]";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }
        public void hienthilop()
        {
            cn.myconnect();
            string sql = "SELECT [MaLop],[TenLop],[SiSo],[NgayBatDau],[MaLoaiLop] ,[GioHoc],[NgayHoc],[Phong]  FROM [qlhv].[dbo].[Lop]";
            dgvLop.DataSource = cn.Taobang(sql);
            cn.myclose();

        }
        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCongGV.Text = string.Format("Tổng cộng: {0} giáo viên", dgv.Rows.Count);
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCongGV.Text = string.Format("Tổng cộng: {0} giáo viên", dgv.Rows.Count);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv.DataSource;
            idx = dgv.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            txtId.Text = hang["MaGV"].ToString();
            /*txtTen.Text = hang["TenGV"].ToString();
            cbgioitinh.Text = hang["GioiTinh"].ToString();
            dtns.Value = Convert.ToDateTime(hang["NgaySinh"].ToString());
            txtdiachi.Text = hang["DiaChi"].ToString();
            txtsdt.Text = hang["SDT"].ToString();*/
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmgiaovienadd frm = new frmgiaovienadd();
            DialogResult rs = frm.ShowDialog();
            if (rs == DialogResult.Yes)
            {
                frmgiaovien_Load(null, null);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmgiaovienedit frm = new frmgiaovienedit();
            frm.Magv = dgv.CurrentRow.Cells[0].Value.ToString();
            frm.Tengv = dgv.CurrentRow.Cells[1].Value.ToString();
            frm.Diachi = dgv.CurrentRow.Cells[4].Value.ToString();
            frm.Gioitinh = dgv.CurrentRow.Cells[2].Value.ToString();
            frm.Dtns = Convert.ToDateTime(dgv.CurrentRow.Cells[3].Value.ToString());
            frm.SDT = dgv.CurrentRow.Cells[5].Value.ToString();
            DialogResult rs = frm.ShowDialog();
            if (rs == DialogResult.Yes)
            {
                frmgiaovien_Load(null, null);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT * FROM [qlhv].[dbo].[Lop] where MaLop = '" + txtId.Text + "'";
                    cn.xoathongtingv(txtId.Text);
                    MessageBox.Show("xoa thanh cong");
                    dgvLop.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("xoa khong thanh cong!!");
                }
                cn.myclose();
                hienthi();
                hienthilop();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                if ((chkTenGV.Checked == true && chkGioiTinh.Checked == true && chkMaGV.Checked == true) || (chkTenGV.Checked == false && chkGioiTinh.Checked == false && chkMaGV.Checked == false) || (chkTenGV.Checked == true && chkGioiTinh.Checked == true) || (chkGioiTinh.Checked == true && chkMaGV.Checked == true) || (chkTenGV.Checked == true && chkMaGV.Checked == true))
                {
                    MessageBox.Show("Chon 1 cach tim kiem!!");
                }
                else
                {
                    if (chkTenGV.Checked == true)
                    {
                        string sql = "SELECT [MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT] FROM [qlhv].[dbo].[GiaoVien] where [TenGV] LIKE N'%" + txttimkiemTenGV.Text + "%'";
                        cn.timkiemthongtintheoTengv(txttimkiemMaGV.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                    if (chkMaGV.Checked == true)
                    {
                        string sql = "SELECT [MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT] FROM [qlhv].[dbo].[GiaoVien] where MaGV = '" + txttimkiemMaGV.Text + "'";
                        cn.timkiemthongtintheoIdgv(txttimkiemMaGV.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }

                    if (chkGioiTinh.Checked == true)
                    {
                        string sql = "SELECT [MaGV],[TenGV],[GioiTinh],[NgaySinh],[DiaChi],[SDT] FROM [qlhv].[dbo].[GiaoVien] where [GioiTinh] LIKE N'" + txttkgt.Text + "'";
                        cn.timkiemthongtintheoGioiTinhgv(txttkgt.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi!!");
            }
            cn.myclose();
            hienthilop();
        }
        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txttimkiemMaGV.Text = txttimkiemTenGV.Text = txttkgt.Text = "";
            chkMaGV.Checked = chkTenGV.Checked = chkGioiTinh.Checked = false;
            hienthi();
        }
        #region check
        private void chkMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaGV.Checked == true)
                txttimkiemMaGV.Enabled = true;
            else txttimkiemMaGV.Enabled = false;
        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGioiTinh.Checked == true)
                txttkgt.Enabled = true;
            else txttkgt.Enabled = false;
        }

        private void chkTenGV_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTenGV.Checked == true)
                txttimkiemTenGV.Enabled = true;
            else txttimkiemTenGV.Enabled = false;
        }
        #endregion
        private void dgvLop_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            labellop.Text = string.Format("Các lớp dạy: {0}", dgvLop.Rows.Count);
        }

        private void dgvLop_RowsRemoved_1(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labellop.Text = string.Format("Các lớp dạy: {0}", dgvLop.Rows.Count);
        }
    }
}
