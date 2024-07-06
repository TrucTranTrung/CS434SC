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
    public partial class frm_employee_quits : Form
    {
        string id;
        DAL.ConnectDatabase2 ketnoi;
        BLL.BLL_employee_quit bll_cn;
        bool c = false;
     
        public frm_employee_quits()
        {
            InitializeComponent();
            bll_cn = new BLL.BLL_employee_quit(this);
            ketnoi = new DAL.ConnectDatabase2();
        }

        private void frm_employee_quits_Load(object sender, EventArgs e)
        {
            bll_cn.BLL_employee_quit_loadData();
            bll_cn.BLL_loadData_personal_id();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                c = true;

                txt_day_of_work.Text = dataGridView1.CurrentRow.Cells["day_off_work"].Value.ToString();
                txt_fullname.Text = dataGridView1.CurrentRow.Cells["fullname"].Value.ToString();
                txt_reason.Text = dataGridView1.CurrentRow.Cells["reason"].Value.ToString();
                cb_staff_id.Text = dataGridView1.Rows[e.RowIndex].Cells["personal_information_id"].Value.ToString();

                c = false;
            }
            catch
            {
                return;
            }

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_create_employee_quit();
            bll_cn.BLL_employee_quit_loadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_edit_employee_quit();
            bll_cn.BLL_employee_quit_loadData();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_delete_employee_quit();
            bll_cn.BLL_employee_quit_loadData();
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_employee_quit_loadData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }
    }
}
