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
using qlhv.models;


namespace qlhv.form
{
    public partial class frmchinhsuathongtin : Form
    {
        string txt = "";
        public frmchinhsuathongtin()
        {
            string txt = "";
            InitializeComponent();
            this.txt = txt;
        }
        
        SqlConnection conn = new SqlConnection(@"Server=DESKTOP-LQGSM6R\PEO;
                                                        Database=QLDA;
                                                        Trusted_connection=True;");

        private void frmchinhsuathongtin_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {

        }
    }
}
