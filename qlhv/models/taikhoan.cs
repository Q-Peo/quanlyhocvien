using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace qlhv.models
{
    public class taikhoan
    {
        private string tk;
        private string mk;

        public taikhoan()
        {
            tk = mk = "";
        }

        public taikhoan(string tk, string mk)
        {
            
            Tk = tk;
            Mk = mk;
        }

        public string Tk { get => tk; set => tk = value; }
        public string Mk { get => mk; set => mk = value; }
    }
}
