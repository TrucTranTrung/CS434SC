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
    public partial class frm_admin_page : Form
    {
        DAL.ConnectDatabase2 ketnoi;
        BLL.BLL_user BLL_USER;
        BLL.BLL_role BLL_ROLE;
        bool c = false;
        public frm_admin_page()
        {

            ketnoi = new DAL.ConnectDatabase2();
            BLL_USER = new BLL.BLL_user(this);
            BLL_ROLE = new BLL.BLL_role(this);

            InitializeComponent();
        }

        private void frm_admin_page_Load(object sender, EventArgs e)
        {
            GridView_userData.DataSource = BLL_ROLE.bll_loadData_role_user();

            GridView_userData.Columns["admin_id"].Visible = false;
            GridView_userData.Columns["id1"].Visible = false;
            GridView_userData.Columns["id2"].Visible = false;
            txt_role_id.Visible = false;

            dataGridView_role.DataSource = BLL_ROLE.bll_loadData_role();

            cb_user_role_id.DataSource = BLL_ROLE.bll_loadData_role_user();
            cb_user_role_id.DisplayMember = "id";
            cb_user_role_id.ValueMember = "id";

            cb_role_id.DataSource = BLL_ROLE.bll_loadData_role();
            cb_role_id.DisplayMember = "name";
            cb_role_id.ValueMember = "id";

            cb_role_id_p.DataSource = BLL_ROLE.bll_loadData_role();
            cb_role_id_p.DisplayMember = "name";
            cb_role_id_p.ValueMember = "id";

            cb_user_id.DataSource = BLL_USER.bll_user_loadData();
            cb_user_id.DisplayMember = "username";
            cb_user_id.ValueMember = "id";

        }
        

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_user_page.session_role = 0;
            frm_login login = new frm_login();
            this.Hide();
            login.Show();
        }

        private void btn_add_role_Click(object sender, EventArgs e)
        {
            if (frm_user_page.session_role == 7)
            {
                MessageBox.Show("Không đủ quyền!!!");
            }
            else
            {
                try
                {
                    BLL_ROLE.bll_create_role();

                }
                catch
                {
                    string sql = $@"insert into roles values (1, '{txt_role.Text}')";
                    ketnoi.changeDB(sql);
                }
            }
           

            dataGridView_role.DataSource = BLL_ROLE.bll_loadData_role();
            cb_role_id.DataSource = BLL_ROLE.bll_loadData_role();
            cb_role_id.DisplayMember = "name";
            cb_role_id.ValueMember = "id";
        }

        private void btn_add_permission_Click(object sender, EventArgs e)
        {
            string admin_id = "NULL";
            int user_id = (int)((DataRowView)cb_user_id.SelectedItem)["id"];
            int role_id = (int)((DataRowView)cb_role_id_p.SelectedItem)["id"];

            try
            {
                BLL_ROLE.bll_create_role_user();

            }
            catch
            {
                string sql = $@"insert into role_users values (1, {admin_id}, {user_id}, {role_id})";

                ketnoi.changeDB(sql);
            }

            GridView_userData.DataSource = BLL_ROLE.bll_loadData_role_user();
            GridView_userData.Columns["admin_id"].Visible = false;
            GridView_userData.Columns["id1"].Visible = false;
            GridView_userData.Columns["id2"].Visible = false;

            cb_user_role_id.DataSource = BLL_ROLE.bll_loadData_role_user();
            cb_user_role_id.DisplayMember = "id";
            cb_user_role_id.ValueMember = "id";

        }

        private void btn_edit_role_Click(object sender, EventArgs e)
        {

           
            if (frm_user_page.session_role == 7)
            {
                MessageBox.Show("Không đủ quyền!!!");
            }
            else
            {
                int id = (int)((DataRowView)cb_role_id.SelectedItem)["id"];
                string name = txt_role.Text;
                BLL_ROLE.bll_edit_role(id, name);
                dataGridView_role.DataSource = BLL_ROLE.bll_loadData_role();
                cb_role_id.DataSource = BLL_ROLE.bll_loadData_role();
                cb_role_id.DisplayMember = "name";
                cb_role_id.ValueMember = "id";
            }

            

        }

        private void btn_edit_permission_Click(object sender, EventArgs e)
        {
            int roleID = Convert.ToInt32(txt_role_id.Text);
            int role_id_value = Convert.ToInt32(cb_role_id_p.SelectedValue);

            if (frm_user_page.session_role == roleID)
            {
                MessageBox.Show("Bạn không được phép đổi quyền của chính bạn hoặc người có quyền ngang bạn!!!");
            }
            else
            {
                if (frm_user_page.session_role == role_id_value)
                {
                    MessageBox.Show("Bạn không được phép đổi quyền cao hơn cho người này!!!");

                }
                else
                {
                    try
                    {
                        string admin_id = "NULL";
                        int user_id = (int)((DataRowView)cb_user_id.SelectedItem)["id"];
                        int role_id = (int)((DataRowView)cb_role_id_p.SelectedItem)["id"];
                        int id = (int)((DataRowView)cb_user_role_id.SelectedItem)["id"];

                        BLL_ROLE.bll_edit_role_user(id, admin_id, user_id, role_id);

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Thay đổi quyền thất bại{err}");
                    }
                }
            }

            GridView_userData.DataSource = BLL_ROLE.bll_loadData_role_user();
            GridView_userData.Columns["admin_id"].Visible = false;
            GridView_userData.Columns["id1"].Visible = false;
            GridView_userData.Columns["id2"].Visible = false;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (frm_user_page.session_role == 7)
            {
                MessageBox.Show("Không đủ quyền!!!");
            }
            else
            {
                int id = int.Parse(GridView_userData.CurrentRow.Cells["id"].Value.ToString());
                ketnoi.changeDB($"DELETE FROM role_users WHERE role_users.id = {id}");

            }

            GridView_userData.DataSource = BLL_ROLE.bll_loadData_role_user();

        }


        private void btn_delete_role_Click(object sender, EventArgs e)
        {
            if (frm_user_page.session_role == 7)
            {
                MessageBox.Show("Không đủ quyền!!!");
            }
            else
            {
                int id = (int)((DataRowView)cb_role_id.SelectedItem)["id"];
                BLL_ROLE.bll_delete_role(id);
            }
            
            dataGridView_role.DataSource = BLL_ROLE.bll_loadData_role();
            cb_role_id.DataSource = BLL_ROLE.bll_loadData_role();
            cb_role_id.DisplayMember = "name";
            cb_role_id.ValueMember = "id";
           
            
        }

        private void GridView_userData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                c = true;

                int id = (int)GridView_userData.Rows[e.RowIndex].Cells["id"].Value;
                DataTable dt_role_user = ketnoi.loadData($"SELECT * FROM role_users WHERE role_users.id = {id}");
                int role_id = Convert.ToInt32(dt_role_user.Rows[0]["role_id"]);
                int user_id = Convert.ToInt32(dt_role_user.Rows[0]["user_id"]);
                txt_role_id.Text = role_id.ToString();
                cb_user_role_id.SelectedValue = id.ToString();
                cb_role_id_p.SelectedValue = role_id;
                cb_user_id.SelectedValue = user_id;

                c = false;
            }
            catch
            {
                return;
            }
        }

        private void dataGridView_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                c = true;

                int id = (int)dataGridView_role.Rows[e.RowIndex].Cells["id"].Value;
                DataTable dt_role = ketnoi.loadData($"SELECT * FROM roles WHERE roles.id = {id}");
                string name = dt_role.Rows[0]["name"].ToString();
                int ID = Convert.ToInt32(dt_role.Rows[0]["id"]);
                txt_role.Text = name;
                cb_role_id.SelectedValue = ID;

                c = false;
            }
            catch
            {
                return;
            }
        }


        private void cb_role_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (c)
            {
                case false:

                    int id = (int)((DataRowView)cb_role_id.SelectedItem)["id"];
                    DataTable dt_role = ketnoi.loadData($"SELECT * FROM roles WHERE roles.id = {id}");
                    string name = dt_role.Rows[0]["name"].ToString();
                    txt_role.Text = name;
                    int ID = (int)((DataRowView)cb_role_id.SelectedItem)["id"];
                    ID = id;

                    break;
            }
        }

        private void cb_user_id_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (c)
            {
                case false:
                    int id = (int)((DataRowView)cb_user_id.SelectedItem)["id"];
                    DataTable dt_user = ketnoi.loadData($"SELECT * FROM users WHERE users.id = {id}");
                    int ID = (int)((DataRowView)cb_user_id.SelectedItem)["id"];
                    ID = id;

                    break;
            }

        }

        private void cb_role_id_p_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (c)
            {
                case false:

                    int id = (int)((DataRowView)cb_role_id_p.SelectedItem)["id"];
                    DataTable dt_role = ketnoi.loadData($"SELECT * FROM role_users WHERE role_users.id = {id}");
                    int ID = (int)((DataRowView)cb_role_id_p.SelectedItem)["id"];
                    ID = id;

                    break;
            }

        }

        
    }
}
