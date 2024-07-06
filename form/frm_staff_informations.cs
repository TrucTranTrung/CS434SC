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
    public partial class frm_staff_informations : Form
    {
        BLL.BLLStaff_information bll_cn;
        private ConnectDatabase commonClass;
        string check;

        public frm_staff_informations()
        {
            InitializeComponent();
            commonClass = new ConnectDatabase();
            bll_cn = new BLL.BLLStaff_information(this);
        }
        private void frm_staff_informations_Load(object sender, EventArgs e)
        {
            loadData();
            LoadDepartment();
            LoadPersionalInformation();
            bll_cn.BLL_Load_cb_pos();
        }
       

        public void loadData()
        {
            bll_cn.BllLoadGrid();
        }

        public void LoadDepartment()
        {
            bll_cn.BllLoadDepartment();
        }
        public void LoadPersionalInformation()
        {
            bll_cn.BllLoadPersonalInformation();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bll_cn.BllCreate();
            loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_marriage.Text = dataGridView1.CurrentRow.Cells["marriage_status"].Value.ToString();
            cb_pos.Text = dataGridView1.CurrentRow.Cells["position"].Value.ToString();
            txt_contract_type.Text = dataGridView1.CurrentRow.Cells["contracttype"].Value.ToString();
            txt_day_of_work.Text = dataGridView1.CurrentRow.Cells["dayofwork"].Value.ToString();
            txt_singing_date.Text = dataGridView1.CurrentRow.Cells["signing_date"].Value.ToString();
            txt_expiry_date.Text = dataGridView1.CurrentRow.Cells["expiry_date"].Value.ToString();
            combox_departmet.Text = dataGridView1.CurrentRow.Cells["department_name"].Value.ToString();
            combo_personal_information.Text  = dataGridView1.CurrentRow.Cells["personal_information_id"].Value.ToString();



        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                check = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                bll_cn.BllUpdate(int.Parse(check));
            }
            catch (Exception err)
            {
                MessageBox.Show("Fail!");
                throw err;
            }

            loadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("You may want to delete", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    check = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                    bll_cn.BllDelete(int.Parse(check));
                    loadData();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("You need to delete employee information before deleting personal information");
                throw err;
            }

            loadData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            txt_marriage.Text = "";
            cb_pos.Text = "";
            txt_contract_type.Text = "";
            txt_day_of_work.Text = "";
            txt_singing_date.Text = "";
            txt_expiry_date.Text = "";
            combox_departmet.Text = "";      
            combo_personal_information.Text = "";
            loadData();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bll_cn.BllTim();
            

        }

        private void btn_count_Click(object sender, EventArgs e)
        {
            bll_cn.BllDem();
            
        }
    }
}
