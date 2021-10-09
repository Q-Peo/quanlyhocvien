using qlhv.pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace qlhv.form
{
    public partial class frmlop : Form
    {
        public frmlop()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        private void frmlop_Load(object sender, EventArgs e)
        {
            hienthi();
            txttimkiemmalop.Enabled = txttimkiemss.Enabled = false;
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = true;
            lblMaLop.Text = lblTenLop.Text = lblSiSo.Text = lblNgayBatDau.Text = lblgiohoc.Text = lblNgayhoc.Text = lblPhong.Text = lblMaLoaiLop.Text = lblHocphi.Text = lblMaGiaovien.Text = string.Empty;
        }
        public void hienthi()
        {
            cn.myconnect();
            string sql = "SELECT * FROM [qlhv].[dbo].[Lop]";
            dgvLop.DataSource = cn.Taobang(sql);
            cn.myclose();
        }
        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void dgvLop_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            labellop.Text = string.Format("Các lớp dạy: {0}", dgvLop.Rows.Count);
        }

        private void dgvLop_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labellop.Text = string.Format("Các lớp dạy: {0}", dgvLop.Rows.Count);
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgvLop.DataSource;
            idx = dgvLop.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            lblMaLop.Text = hang["MaLop"].ToString();
            lblTenLop.Text = hang["TenLop"].ToString();
            lblSiSo.Text = hang["SiSo"].ToString();
            lblNgayBatDau.Text = hang["NgayBatDau"].ToString();
            lblgiohoc.Text = hang["GioHoc"].ToString();
            lblNgayhoc.Text = hang["NgayHoc"].ToString();
            lblMaLoaiLop.Text = hang["MaLoaiLop"].ToString();
            lblHocphi.Text = hang["TienHP"].ToString();
            lblMaGiaovien.Text = hang["MaGV"].ToString();
            lblPhong.Text = hang["Phong"].ToString();
        }
        public static string idlop = "";

        private void btnThem_Click(object sender, EventArgs e)
        {
            //idlop = getID(lblMaLop.Text, lblTenLop.Text, lblSiSo.Text, lblNgayBatDau.Text, lblgiohoc.Text, lblNgayhoc.Text, lblPhong.Text, lblMaLoaiLop.Text, lblHocphi.Text, lblMaGiaovien.Text);
            frmlophocadd frm = new frmlophocadd();
            DialogResult rs = frm.ShowDialog();
            if(rs== DialogResult.Yes)
            {
                frmlop_Load(null, null);
            }
            //frm.Show();
           /* try
            {
                cn.myconnect();
                string sql = "SELECT [MaLop] ,[TenLop],[SiSo],[NgayBatDau],[GioHoc],[NgayHoc],[Phong],[MaLoaiLop],[TienHP],[MaGV] FROM [qlhocvien].[dbo].[Lop] where MaLop = '" + txtId.Text + "'";
                cn.themthongtinlop(txtId.Text, txttenlop.Text, txtss.Text, dtns.Value, txtgiohoc.Text, txtngayhoc.Text, txtphong.Text, cbmllop.Text,txthocphi.Text,cbmagv.Text);
                MessageBox.Show("them thanh cong");
                dgvLop.DataSource = cn.Taobang(sql);
            }
            catch
            {
                MessageBox.Show("them khong thanh cong!!");
            }
            cn.myclose();
            hienthi();*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmlophocedit frm = new frmlophocedit();
            frm.Text = "Cập nhật thông tin lớp";
            frm.Id = dgvLop.CurrentRow.Cells[0].Value.ToString();
            frm.mall = dgvLop.CurrentRow.Cells[7].Value.ToString();
            frm.tenlop = dgvLop.CurrentRow.Cells[1].Value.ToString();
            frm.siso = dgvLop.CurrentRow.Cells[2].Value.ToString();
            frm.Dtns = Convert.ToDateTime(dgvLop.CurrentRow.Cells[3].Value.ToString());
            frm.giohoc = dgvLop.CurrentRow.Cells[4].Value.ToString();
            frm.ngayhoc = dgvLop.CurrentRow.Cells[5].Value.ToString();
            frm.phong = dgvLop.CurrentRow.Cells[6].Value.ToString();
            frm.tienhoc = dgvLop.CurrentRow.Cells[8].Value.ToString();
            frm.magv = dgvLop.CurrentRow.Cells[9].Value.ToString();
            DialogResult rs = frm.ShowDialog();
            if (rs == DialogResult.Yes)
            {
                frmlop_Load(null, null);
            }

            /*if (MessageBox.Show("Ban co chac chan muon thay doi ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT [MaLop] ,[TenLop],[SiSo],[NgayBatDau],[GioHoc],[NgayHoc],[Phong],[MaLoaiLop],[TienHP],[MaGV] FROM [qlhocvien].[dbo].[Lop] where MaLop = '" + txtId.Text + "'";
                    cn.suathongtinhlop(txtId.Text, txttenlop.Text, txtss.Text, dtns.Value, txtgiohoc.Text, txtngayhoc.Text, txtphong.Text, cbmllop.Text, txthocphi.Text, cbmagv.Text);
                    MessageBox.Show("sua thanh cong");
                    dgvLop.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("sua khong thanh cong!!");
                }
                cn.myclose();
            }*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT * FROM [qlhocvien].[dbo].[Lop] where MaLop = '" + lblMaLop.Text + "'";
                    cn.xoathongtinlop(lblMaLop.Text, lblTenLop.Text, lblSiSo.Text, lblNgayBatDau.Text, lblgiohoc.Text, lblNgayhoc.Text, lblPhong.Text, lblMaLoaiLop.Text, lblHocphi.Text, lblMaGiaovien.Text);
                    MessageBox.Show("xoa thanh cong");
                    dgvLop.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("xoa khong thanh cong!!");
                }
                cn.myclose();
                hienthi();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();
                if ((chkmalop.Checked == true && chksiso.Checked == true) || (chkmalop.Checked == false && chksiso.Checked == false))
                {
                    MessageBox.Show("Chon 1 cach tim kiem!!");
                }
                else
                {
                    if (chkmalop.Checked == true)
                    {
                        string sql = "SELECT * FROM [qlhv].[dbo].[Lop] where [MaLop] LIKE N'" + txttimkiemmalop.Text + "'";
                        cn.timkiemthongtintheoIdLop(lblMaLop.Text, lblTenLop.Text, lblSiSo.Text, lblNgayBatDau.Text, lblgiohoc.Text, lblNgayhoc.Text, lblPhong.Text, lblMaLoaiLop.Text, lblHocphi.Text, lblMaGiaovien.Text);
                        dgvLop.DataSource = cn.Taobang(sql);
                    }
                    if (chksiso.Checked == true)
                    {
                        string sql = "SELECT * FROM [qlhv].[dbo].[Lop] where SiSo = '" + txttimkiemss.Text + "'";
                        cn.timkiemthongtintheoSiso(lblMaLop.Text, lblTenLop.Text, lblSiSo.Text, lblNgayBatDau.Text, lblgiohoc.Text, lblNgayhoc.Text, lblPhong.Text, lblMaLoaiLop.Text, lblHocphi.Text, lblMaGiaovien.Text);
                        dgvLop.DataSource = cn.Taobang(sql);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi!!");
            }
            cn.myclose();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            chkmalop.Checked = chksiso.Checked = false;
            lblMaLop.Text = lblTenLop.Text = lblSiSo.Text = lblNgayBatDau.Text = lblgiohoc.Text = lblPhong.Text = lblNgayhoc.Text = lblMaLoaiLop.Text = lblHocphi.Text = lblMaGiaovien.Text = txttimkiemmalop.Text = txttimkiemss.Text = "";
            hienthi();
        }

        private void chkmalop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmalop.Checked == true)
                txttimkiemmalop.Enabled = true;
            else txttimkiemmalop.Enabled = false;
        }

        private void chksiso_CheckedChanged(object sender, EventArgs e)
        {
            if (chksiso.Checked == true)
                txttimkiemss.Enabled = true;
            else txttimkiemss.Enabled = false;
        }
    }
}
