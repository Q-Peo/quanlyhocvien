using qlhv.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace qlhv
{
    public partial class frmSystem : Form
    {
        string txt = "";
        public frmSystem(string txt) : this()
        {
            this.txt = txt;
            //label6.Text = string.Format("", txt);
        }

        public frmSystem()
        {
            InitializeComponent();
            customizeDesing();
        }
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                                        Database=qlhv;
                                                                        Trusted_connection=True;");
        private void frmSystem_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Xin chào User có ID là: " + loginn.ID_User);
            lbusername.Text = string.Format($"{txt}");
            listtk = List_per(id_per(loginn.ID_User));
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        #region phan quyen
        string UID = loginn.ID_User;
        List<string> listtk;
        private Boolean checkper(string code)
        {
            Boolean check = false;
            foreach (string item in listtk) 
            {
                if (item == code)
                {
                    check = true;
                }
            }
            return check;
        }

        private string id_per(string id_user)
        {
            string id = "";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE MaND ='" + id_user + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["suspended"].ToString() == "False")
                        {
                            id = dr["MaLoaiND"].ToString();
                        }
                    }
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

            return id;
        }

        private List<string> List_per(string idper)
        {
            //string idper = id_per();
            List<string> termlist = new List<string>();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Quyen WHERE [id-nd] ='" + idper + "'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        termlist.Add(dr["action"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("có lỗi xảy ra");
            }
            finally
            {
                conn.Close();
            }
            return termlist;
        }
        #endregion

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region menu dong
        private void customizeDesing()
        {
            //
            //panelnhanvien.Visible = false;
            panellop.Visible = false;
            panelhocvien.Visible = false;
            panelquantri.Visible = false;
        }
        //an menu khi nhan vao
        private void hideSubmenu()
        {
            /*if (panelnhanvien.Visible == true)
                panelnhanvien.Visible = false;*/
            if (panellop.Visible == true)
                panellop.Visible = false;
            if (panelhocvien.Visible == true)
                panelhocvien.Visible = false;
            if (panelquantri.Visible == true)
                panelquantri.Visible = false;
        }
        //hien menu nho
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void addForm(Form f)
        {
            f.TopLevel = false;
            f.AutoScroll = true;
            f.Dock = DockStyle.Fill;
            panelform.Controls.Add(f);
            f.Show();
        }

        #endregion
        //menu con
        #region panel lop-giaovien
        private void btnlop_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmlop frmChild = new form.frmlop();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
        }

        private void btngiaovien_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmgiaovien frmChild = new form.frmgiaovien();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
        }
        #endregion
        #region panel hocvien
        private void btnqlhocvien_Click(object sender, EventArgs e)
        {
                this.panelform.Controls.Clear();
                form.frmtiepnhanhocvien frmChild = new form.frmtiepnhanhocvien();
                //background.
                frmChild.TopLevel = false;
                // Gắn vào panel
                this.panelform.Controls.Add(frmChild);
                frmChild.Dock = DockStyle.Fill;
                // Hiển thị form
                frmChild.Show();
                //hideSubmenu();
        }

        private void btnhocphi_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmquanlyhocvien frmChild = new form.frmquanlyhocvien();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
        }

        private void btnbangdiem_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmhocphi frmChild = new form.frmhocphi();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
        }
        private void btndiem_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmdiemhv frmChild = new form.frmdiemhv();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
        }
        #endregion
        #region panel quan tri
        private void btnbaocaothongke_Click(object sender, EventArgs e)
        {
                this.panelform.Controls.Clear();
                form.frmthongkenohocvien frmChild = new form.frmthongkenohocvien();
                //background.
                frmChild.TopLevel = false;
                // Gắn vào panel
                this.panelform.Controls.Add(frmChild);
                frmChild.Dock = DockStyle.Fill;
                // Hiển thị form
                frmChild.Show();
                //hideSubmenu();
        }

        private void btntiepnhanhocvien_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmbchvtheothang frmChild = new form.frmbchvtheothang();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
        }

        private void btnthaydoi_Click(object sender, EventArgs e)
        {
            this.panelform.Controls.Clear();
            form.frmtrang frmChild = new form.frmtrang();
            //background.
            frmChild.TopLevel = false;
            // Gắn vào panel
            this.panelform.Controls.Add(frmChild);
            frmChild.Dock = DockStyle.Fill;
            // Hiển thị form
            frmChild.Show();
            //hideSubmenu();
            hideSubmenu();
        }
        #endregion  

        //menu big
        #region menu big

        private void btnlopgiaovien_Click(object sender, EventArgs e)
        {
            showSubmenu(panellop);
        }
        
        private void btnhocvien_Click(object sender, EventArgs e)
        {
            showSubmenu(panelhocvien);
        }

        private void btnquantri_Click(object sender, EventArgs e)
        {
            showSubmenu(panelquantri);
        }
        private void btnqlnhanvien_Click(object sender, EventArgs e)
        {
            if (checkper("qlnv") == false)
            {
                this.panelform.Controls.Clear();
                form.frmcapnhatthongtin frmChild = new form.frmcapnhatthongtin();
                //background.
                frmChild.TopLevel = false;
                // Gắn vào panel
                this.panelform.Controls.Add(frmChild);
                frmChild.Dock = DockStyle.Fill;
                // Hiển thị form
                frmChild.Show();
            //hideSubmenu();
            }
            else
            {
                MessageBox.Show("Ban k co quyen thuc hien hanh dong nay!!");
            }
}
        #endregion

        //chinh sua mat khau
        private void button3_Click(object sender, EventArgs e)
        {
            form.frmdoimatkhau frmChild = new form.frmdoimatkhau();
            frmChild.Show();
        }

        #region minimum
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= WS_MINIMIZEBOX;
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }
        #endregion
        #region chuyen ra background
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (!panelform.Controls.Contains(background.Instance))
            {
                panelform.Controls.Add(background.Instance);
                background.Instance.Dock = DockStyle.Fill;
                background.Instance.BringToFront();
            }
            else
                background.Instance.BringToFront();
        }




        #endregion

        /*
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
        */



    }
}
