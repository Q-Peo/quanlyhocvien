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
    public partial class frmcapnhatthongtin : Form
    {
        public frmcapnhatthongtin()
        {
            InitializeComponent();
        }
        connect cn = new connect();
        private void frmcapnhatthongtin_Load(object sender, EventArgs e)
        {
            //DateTime dt = DateTime.Now;
            //dtns.Format.ToString("{0:MM/dd/yyyy}");
            //dtns.Format = DateTimePickerFormat.Custom;
            //dtns.CustomFormat = "MM-dd-yyyy";
            //dgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            //dgv.Columns["NgaySinh"].DefaultCellStyle.Format = "MM/dd/yyyy";
            //dtns.Value.ToString("yyyy/MM/dd");
            hienthi(); 
            txttkid.Enabled = txttimkiemten.Enabled = cbtimkiemgioitinh.Enabled = false;
            btnSua.Enabled = btnthem.Enabled = btnXoa.Enabled=txtsdt.Enabled = txtTen.Enabled = txtdiachi.Enabled = cbgioitinh.Enabled = cbmlnd.Enabled = dtns.Enabled = false;
        }

        public void hienthi()
        {
            cn.myconnect();
            string sql = "SELECT [MaND] ,[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND],TenTK,MatKhau FROM [qlhv].[dbo].[NguoiDung]";
            dgv.DataSource = cn.Taobang(sql);
            cn.myclose();
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            hienthi();
        }
        
        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} kết quả", dgv.Rows.Count);
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTongCong.Text = string.Format("Tổng cộng: {0} kết quả", dgv.Rows.Count);
        }
        
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = -1;
            DataTable bang = new DataTable();
            bang = (DataTable)dgv.DataSource;
            idx = dgv.SelectedCells[0].RowIndex;
            DataRow hang = bang.Rows[idx];
            txtId.Text = hang["MaND"].ToString();
            txtTen.Text = hang["TenND"].ToString();
            cbgioitinh.Text = hang["GioiTinh"].ToString();
            dtns.Value = Convert.ToDateTime(hang["NgaySinh"].ToString());
            //nt.Text = hang["NgaySinh"].ToString();
            txtdiachi.Text = hang["DiaChi"].ToString();
            txtsdt.Text = hang["SDT"].ToString();
            cbmlnd.Text = hang["MaLoaiND"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon thay doi ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT [MaND] ,[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND] FROM [qlhv].[dbo].[NguoiDung] where MaND = '" + txtId.Text + "'";
                    cn.suathongtin(txtId.Text, txtTen.Text, cbgioitinh.Text, dtns.Value, txtdiachi.Text, txtsdt.Text, cbmlnd.Text);
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            
                try
                {
                    cn.myconnect();
                    string sql = "SELECT [MaND] ,[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND] FROM [qlhv].[dbo].[NguoiDung] where MaND = '" + txtId.Text + "'";
                    cn.themthongtin(txtId.Text, txtTen.Text, cbgioitinh.Text, dtns.Value, txtdiachi.Text, txtsdt.Text, cbmlnd.Text);
                    MessageBox.Show("them thanh cong");
                    dgv.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("them khong thanh cong!!");
                }
                cn.myclose();
                hienthi();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cn.myconnect();
                    string sql = "SELECT * FROM [qlhv].[dbo].[NguoiDung] where MaND = '" + txtId.Text + "'";
                    cn.xoathongtin(txtId.Text);
                    MessageBox.Show("xoa thanh cong");
                    dgv.DataSource = cn.Taobang(sql);
                }
                catch
                {
                    MessageBox.Show("xoa khong thanh cong!!");
                }
                cn.myclose();
                hienthi();
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtId.Text = txtsdt.Text = txtTen.Text = txtdiachi.Text = "";
            cbgioitinh.SelectedIndex = cbmlnd.SelectedIndex =  0;
            dtns.Value = DateTime.Now;
            txttkid.Text = txttimkiemten.Text = cbtimkiemgioitinh.Text = "";
            chkid.Checked = chkTen.Checked = chkGioiTinh.Checked = false;
            hienthi();
        }
        #region button tim kiem
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                cn.myconnect();

                if ((chkid.Checked == true && chkGioiTinh.Checked == true && chkTen.Checked == true)||(chkid.Checked == true && chkGioiTinh.Checked == true) ||(chkGioiTinh.Checked == true && chkTen.Checked == true) ||(chkid.Checked == true &&  chkTen.Checked == true)|| (chkid.Checked == false && chkGioiTinh.Checked == false && chkTen.Checked == false)) {
                    MessageBox.Show("Chon 1 cach tim kiem!!");
                }
                else
                {
                    if (chkTen.Checked == true) {
                        string sql = "Select [MaND],[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND],TenTK,MatKhau from [qlhv].[dbo].[NguoiDung] where [TenND] LIKE N'%" + txttimkiemten.Text+"%'";
                        cn.timkiemthongtintheoTen(txtTen.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }    
                    if (chkid.Checked == true)
                    {
                        string sql = "SELECT [MaND] ,[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND],TenTK,MatKhau FROM [qlhv].[dbo].[NguoiDung] where MaND = '" + txttkid.Text + "'";
                        cn.timkiemthongtintheoId(txtId.Text);
                        dgv.DataSource = cn.Taobang(sql);
                    }
                    
                    if(chkGioiTinh.Checked == true)
                    {
                        string sql = "Select [MaND],[TenND],[GioiTinh],[NgaySinh],[DiaChi],[SDT],[MaLoaiND],TenTK,MatKhau from [qlhv].[dbo].[NguoiDung] where [GioiTinh] LIKE N'" + @cbtimkiemgioitinh.Text+"'";
                        cn.timkiemthongtintheoGioiTinh(cbgioitinh.Text);
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
        #endregion
        #region checkbox tim kiem
        private void chkid_CheckedChanged(object sender, EventArgs e)
        {
            if (chkid.Checked == true)
                txttkid.Enabled = true;
            else txttkid.Enabled = false;
        }

        private void chkTen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTen.Checked == true)
                txttimkiemten.Enabled = true;
            else txttimkiemten.Enabled = false;
        }

        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGioiTinh.Checked == true)
                cbtimkiemgioitinh.Enabled = true;
            else cbtimkiemgioitinh.Enabled = false;
        }
        #endregion

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                btnSua.Enabled = btnthem.Enabled = btnXoa.Enabled = txtsdt.Enabled = txtTen.Enabled = txtdiachi.Enabled = dtns.Enabled = cbgioitinh.Enabled = cbmlnd.Enabled = dtns.Enabled = false;
            }  
            else btnSua.Enabled = btnthem.Enabled = btnXoa.Enabled = txtsdt.Enabled = txtTen.Enabled = txtdiachi.Enabled = dtns.Enabled = cbgioitinh.Enabled = cbmlnd.Enabled = dtns.Enabled = true;
        }

    }
}
