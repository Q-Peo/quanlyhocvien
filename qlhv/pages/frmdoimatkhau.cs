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
    public partial class frmdoimatkhau : Form
    {
        public frmdoimatkhau()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
        string UID = loginn.ID_User;
        private void frmdoimatkhau_Load(object sender, EventArgs e)
        {
            getdata();
            
        }
        
        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            matkhau();
        }
        #region event
        public void getdata()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE MaND ='" + UID + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lblUserName.Text = string.Format($"{dt.Rows[0]["TenND"]}");
                    txtTenDangNhap.Text = dt.Rows[0]["TenTK"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
        //doi mat khau
        public void matkhau()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE MaND ='" + UID + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if (txtMatKhauCu.Text == dt.Rows[0]["MatKhau"].ToString())
                    {
                        if (!string.IsNullOrEmpty(txtMatKhauMoi.Text) && txtMatKhauMoi.Text == txtMatKhauMoiAgain.Text)
                        {
                            cn.myconnect();
                            string sql = "SELECT * FROM [qlhv].[dbo].[HocVien] where MaND = '" + UID + "'";
                            cn.doimatkhau(UID, txtTenDangNhap.Text, txtMatKhauMoi.Text);
                            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Mật khẩu mới trống hoặc không khớp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Mật khẩu cũ không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
        connect cn = new connect();
        #endregion

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
