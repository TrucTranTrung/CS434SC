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
    public partial class frm_probationary_record : Form
    {
        BLL.BLLProbationaryRecord bll_cn;
        private ConnectDatabase commonClass;
        public frm_probationary_record()
        {
            InitializeComponent();
            commonClass = new ConnectDatabase();
            bll_cn = new BLL.BLLProbationaryRecord(this);
        }
        private void frm_probationary_record_Load(object sender, EventArgs e)
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
      




        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_pos.Text = "";
            txt_probationary_date.Text = "";
            txt_exprity_date.Text = "";
            txt_note.Text = "";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_pos.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_probationary_date.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_exprity_date.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_note.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combo_department.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            combox_identification_number.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();


        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            bll_cn.BllCreate();
            loadData();
        }
        string check;
        private void btn_update_Click(object sender, EventArgs e)
        {

            check = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bll_cn.BllUpdate(int.Parse(check));

           

            loadData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("You may want to delete", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    check = dataGridView1.CurrentRow.Cells[0].Value.ToString();                   
                    bll_cn.BllDelete(int.Parse(check));
                    loadData();
                }
            }
            catch(Exception err)
            {
                throw err;
            }

            loadData();
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
