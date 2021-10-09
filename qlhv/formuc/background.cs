using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlhv
{
    public partial class background : UserControl
    {
        public background()
        {
            InitializeComponent();
        }

        private void background_Load(object sender, EventArgs e)
        {
            lblAddress.Text = string.Format("Địa chỉ: {0}", "235 Hoàng Quốc Việt");
            lblLienHe.Text = string.Format("Liên hệ: {0} - {1}", "0934243567","0245684466");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private static background _instance;
        public static background Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new background();
                return _instance;
            }
        }
        private void lblAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
