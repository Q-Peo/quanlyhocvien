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
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace qlhv
{
    public partial class loginn : Form
    {
        public loginn()
        {
            InitializeComponent();
        }
        //public delegate void delPassData(TextBox text);
        #region di chuyen form
        //di chuyen form khi k co thanh tieu de 
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        protected override void OnMouseDown(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            base.OnMouseDown(e);
        }
        //minimum form
        private void pictureBox5_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        //end
        #endregion
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
        private string getID(string username, string pass)
        {
            string id = "";

            try
            {
                
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [qlhv].[dbo].[NguoiDung] where TenTK='" + username + "' and MatKhau = '" + pass + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["MaND"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("lỗi");
            }
            finally
            {
                conn.Close();
            }

            return id;
        }

        public static string ID_User = "";
        MD5 mh = MD5.Create();

        private void btnlogin_Click(object sender, EventArgs e)
        {
            /*//Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txtpass.Text);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            MessageBox.Show(sb.ToString());
            //nếu bạn muốn các chữ cái in thường thay vì in hoa thì bạn thay chữ "X" in hoa */
            if (string.IsNullOrWhiteSpace(txtuser.Text) || string.IsNullOrWhiteSpace(txtpass.Text))
            {
                loi.Text = string.Format("*Nhập tài khoản và mật khẩu");
            }
            else
            {
                ID_User = getID(txtuser.Text, txtpass.Text);
                if (ID_User != "")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    string txt = txtuser.Text;
                    frmSystem frm = new frmSystem(txt);
                    frm.ShowDialog();
                    //this.Hide();
                }
                else
                {
                    loi.Text = string.Format("Tài khoản hoặc mật khẩu không đúng");
                }
            }
            /*try
            {
                if (string.IsNullOrWhiteSpace(txtuser.Text)|| string.IsNullOrWhiteSpace(txtpass.Text))
                {
                    loi.Text = string.Format("*Nhập đúng tài khoản mật khẩu để đăng nhập");
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\SQLEXPRESS;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
                    conn.Open();
                    string query = "SELECT count(*) FROM [qlhocvien].[dbo].[NguoiDung] where TenTK='"+txtuser.Text+"' and MatKhau = '"+txtpass.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int sl = int.Parse(cmd.ExecuteScalar().ToString());
                    conn.Close();
                    if (sl == 1)
                        {
                         MessageBox.Show("Đăng nhập thành công");
                         string txt = txtuser.Text;
                         frmSystem frm = new frmSystem(txt);
                         frm.ShowDialog();
                         this.Hide();
                         }
                    else
                    {
                        loi.Text = string.Format("*Sai tài khoản đăng nhập hoặc mật khẩu!");
                    }
                }
                
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Đóng phần mềm?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Đóng phần mềm?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Application.Exit();
            }
        }

        private void txtuser_Click(object sender, EventArgs e)
        {
            //pictureBox2.ForeColor = Color.FromArgb(107,107,107);
            txtuser.Clear();
            panel1.BackColor = Color.Black;
            panel2.BackColor = Color.White;
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtpass.PasswordChar = '*';
            panel2.BackColor = Color.Black;
            panel1.BackColor = Color.White;
        }

        private void loginn_Load(object sender, EventArgs e)
        {
            /*chkSave.Checked = Settings.Default.Login_IsSaved;

            if (chkSave.Checked)
            {
                txtTenDangNhap.Text = Settings.Default.Login_UserName;
                txtMatKhau.Text = Settings.Default.Login_Password;
            }

            lblNotification.Text = string.Empty;*/
        }
    }
}
