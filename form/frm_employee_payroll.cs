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
    public partial class frm_employee_payroll : Form
    {
        string id;
        DAL.ConnectDatabase2 ketnoi;
        BLL.BLL_employee_payroll bll_cn;
        bool c = false;

        public frm_employee_payroll()
        {
            InitializeComponent();
            bll_cn = new BLL.BLL_employee_payroll(this);
            ketnoi = new DAL.ConnectDatabase2();
        }
       
        private void frm_employee_payroll_Load(object sender, EventArgs e)
        {
            bll_cn.BLL_employee_payroll_loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                c = true;
                
                txt_salary_basic.Text = dataGridView1.Rows[e.RowIndex].Cells["basic_salary"].Value.ToString();
                txt_new_basic_salary.Text = dataGridView1.Rows[e.RowIndex].Cells["new_basic_salary"].Value.ToString();
                txt_salary_position_allowance.Text = dataGridView1.Rows[e.RowIndex].Cells["salary_position_allowance"].Value.ToString();
                txt_salary.Text = dataGridView1.Rows[e.RowIndex].Cells["salary"].Value.ToString();
                txt_salary_other_allowance.Text = dataGridView1.Rows[e.RowIndex].Cells["salary_other_allowance"].Value.ToString();
                txt_new_position_allowance.Text = dataGridView1.Rows[e.RowIndex].Cells["new_position_allowance"].Value.ToString();
                txt_Penalty.Text = dataGridView1.Rows[e.RowIndex].Cells["Penalty"].Value.ToString();
                txt_num_day_of_work.Text = dataGridView1.Rows[e.RowIndex].Cells["num_day_of_work"].Value.ToString();
                txt_num_day_off.Text = dataGridView1.Rows[e.RowIndex].Cells["num_day_off"].Value.ToString();
                txt_num_over_time.Text = dataGridView1.Rows[e.RowIndex].Cells["num_over_time"].Value.ToString();
                txt_correction_salary_date.Text = dataGridView1.Rows[e.RowIndex].Cells["correction_salary_date"].Value.ToString();

                c = false;

            }
            catch
            {
                return;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_edit_employee_payroll();
            bll_cn.BLL_employee_payroll_loadData();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_delete_employee_payroll();
            bll_cn.BLL_employee_payroll_loadData();
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            bll_cn.BLL_employee_payroll_loadData();

        }
    }
}
