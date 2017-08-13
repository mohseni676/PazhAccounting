using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data;
using System.Data.Common;
using System.Data.Linq.Mapping;

namespace PazhHesabdari
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new dblinqDataContext();
            var tb_user = db.tb_users;
            int cnt = (from u in tb_user where u.username == textBox1.Text && u.password == maskedTextBox1.Text  select u).Count();
            //MessageBox.Show(cnt.ToString());
            if (cnt > 0)
            {
                forms.frm_main main_frm =new forms.frm_main();
                this.Hide();
                main_frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام و نام کاربری اشتباه است");
            }
        }
    }
}
