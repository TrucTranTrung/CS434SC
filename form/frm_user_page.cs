using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Department_Project.GUI
{
    public partial class frm_user_page : Form
    {
        DAL.ConnectDatabase2 ketnoi;
        BLL.BLLPersonal_information bll_cn_person;
        string username = BLL.BLL_login.SESSION.username;
        public static int session_role;
        int person_id;
        int user_id;

        public frm_user_page()
        {
            bll_cn_person = new BLL.BLLPersonal_information(this);
            ketnoi = new DAL.ConnectDatabase2();
            InitializeComponent();
        }

        private void frm_user_page_Load(object sender, EventArgs e)
        {
            DataTable dt_user = ketnoi.loadData($"SELECT * FROM role_users, roles, users WHERE role_users.role_id = roles.id AND role_users.user_id = users.id AND users.username = '{username}'");
            DataTable dt_admin = ketnoi.loadData($"SELECT * FROM admins WHERE admins.username = N'{username}'");

            TextBox[] textBoxArray = new TextBox[]
            {
                txt_num_iden, txt_fullname, txt_birthplace, txt_birthday, txt_gender,
                txt_image, txt_address, txt_phone_num, txt_ethnicity, txt_religion,
                txt_national, txt_education, txt_note
            };

            if (dt_admin.Rows.Count > 0)
            {
                session_role = 2023;
                tabPage2.Text = session_role.ToString();

            }


            if (dt_user.Rows.Count > 0)
            {
                string role_name = dt_user.Rows[0]["name"].ToString();
                int role_id = Convert.ToInt32(dt_user.Rows[0]["role_id"].ToString());
                user_id = Convert.ToInt32(dt_user.Rows[0]["user_id"].ToString());

                DataTable dt_user_info = ketnoi.loadData($"SELECT * FROM personal_informations WHERE personal_informations.user_id={user_id}");
                if (dt_user_info.Rows.Count > 0)
                {
                    person_id = Convert.ToInt32(dt_user_info.Rows[0]["id"].ToString());
                    int gender = Convert.ToInt32(dt_user_info.Rows[0]["gender"].ToString());
                    string fullname = dt_user_info.Rows[0]["fullname"].ToString();
                    string identification_num = dt_user_info.Rows[0]["identification_num"].ToString();
                    string Birthplace = dt_user_info.Rows[0]["Birthplace"].ToString();
                    string Birthday = dt_user_info.Rows[0]["Birthday"].ToString();
                    string image = dt_user_info.Rows[0]["image"].ToString();
                    string Address = dt_user_info.Rows[0]["Address"].ToString();
                    string phone_num = dt_user_info.Rows[0]["phone_num"].ToString();
                    string ethnicity = dt_user_info.Rows[0]["ethnicity"].ToString();
                    string religion = dt_user_info.Rows[0]["religion"].ToString();
                    string nationality = dt_user_info.Rows[0]["nationality"].ToString();
                    string education = dt_user_info.Rows[0]["education"].ToString();
                    string note = dt_user_info.Rows[0]["note"].ToString();
                    string gt = gender == 1 ? "Nam" : "Nữ";
                    txt_num_iden.Text = identification_num;
                    txt_fullname.Text = fullname;
                    txt_birthplace.Text = Birthplace;
                    txt_birthday.Text = Birthday;
                    txt_gender.Text = gt.ToString();
                    txt_image.Text = image;
                    txt_address.Text = Address;
                    txt_phone_num.Text = phone_num;
                    txt_ethnicity.Text = ethnicity;
                    txt_religion.Text = religion;
                    txt_national.Text = nationality;
                    txt_education.Text = education;
                    txt_note.Text = note;
                    img_user.ImageLocation = Application.StartupPath + $@"\\Resources\\{image}";

                }


                tabPage2.Text = $"{role_name.ToUpper()} {username.ToUpper()}";
                lb_username.Text = $"{username} chúc vụ {role_name}";

                session_role = role_id;


            }
            else
            {
                try
                {
                    lb_username.Text = username;
                    tabPage2.Text = $"{username.ToUpper()} Undefined User";
                    img_user.ImageLocation = Application.StartupPath + $@"\\Resources\\user1.png";
                }
                catch
                {
                    return;
                }
               

                for (int i = 0; i < textBoxArray.Length; i++)
                {
                    textBoxArray[i].Text = "Đang xét duyệt chưa phải là nhân viên!!!";
                }
            }



            for (int i = 0; i < textBoxArray.Length; i++)
            {
                textBoxArray[i].Enabled = false;
                textBoxArray[i].BackColor = SystemColors.Control;
                textBoxArray[i].TabStop = false;
                textBoxArray[i].TextAlign = HorizontalAlignment.Center;

            }



        }
        private void btn_change_img_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Hãy chọn ảnh";
            ofd.Filter = "Tất cả đuôi ảnh|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg|GIF|*.gif";

            switch (ofd.ShowDialog())
            {
                case DialogResult.OK:
                    img_user.Image = Image.FromFile(ofd.FileName);
                    string fileName = Path.GetFileName(ofd.FileName);
                    bll_cn_person.bll_update_user_img(person_id, fileName);
                    break;
            }
            DataTable dt_user_info = ketnoi.loadData($"SELECT * FROM personal_informations WHERE personal_informations.user_id={user_id}");
            if (dt_user_info.Rows.Count > 0)
            {
                txt_image.Text = dt_user_info.Rows[0]["image"].ToString();

            }
            else
            {
                txt_image.Text = "user1.png";

            }
            img_user.ImageLocation = Application.StartupPath + $@"\\Resources\\{txt_image.Text}";
        }

        private void btn_open_form_person_Click(object sender, EventArgs e)
        {
            frm_personal_information form_person = new frm_personal_information();
            this.Hide();
            form_person.Show();
        }

      

        private void btn_logout_Click(object sender, EventArgs e)
        {
            session_role = 0;
            frm_login login = new frm_login();
            this.Hide();
            login.Show();
        }

      

        private void frm_user_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();


        }

        


    }
}
