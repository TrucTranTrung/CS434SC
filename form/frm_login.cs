using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Department_Project.GUI
{
    public partial class frm_login : Form
    {

        BLL.BLL_login bll_lg;
        BLL.BLL_register bll_rg;
        DAL.ConnectDatabase2 ketnoi = new DAL.ConnectDatabase2();

        public frm_login()
        {
            InitializeComponent();
            bll_lg = new BLL.BLL_login(this);
            bll_rg = new BLL.BLL_register(this);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bll_lg.bll_login();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            try
            {
                bll_rg.bll_register();

            }
            catch
            {
                string sql = $@"insert into users values (1, '{txt_username_r.Text}', '{txt_password_r.Text}')";
                ketnoi.changeDB(sql);
            }
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

    }
}
