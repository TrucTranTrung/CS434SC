namespace HR_Department_Project.GUI
{
    partial class frm_user_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.img_user = new System.Windows.Forms.PictureBox();
            this.btn_change_img = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_education = new System.Windows.Forms.TextBox();
            this.txt_religion = new System.Windows.Forms.TextBox();
            this.txt_ethnicity = new System.Windows.Forms.TextBox();
            this.lb_ethnicity = new System.Windows.Forms.Label();
            this.lb_education = new System.Windows.Forms.Label();
            this.lb_religion = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_national = new System.Windows.Forms.TextBox();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.txt_phone_num = new System.Windows.Forms.TextBox();
            this.lb_phone_num = new System.Windows.Forms.Label();
            this.lb_image = new System.Windows.Forms.Label();
            this.lb_nationality = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_birthplace = new System.Windows.Forms.TextBox();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_num_iden = new System.Windows.Forms.TextBox();
            this.lb_iden_num = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_birthday = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label.Location = new System.Drawing.Point(82, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(200, 32);
            this.label.TabIndex = 35;
            this.label.Text = "Your Username";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_username.Location = new System.Drawing.Point(32, 366);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(108, 27);
            this.lb_username.TabIndex = 36;
            this.lb_username.Text = "Username";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // img_user
            // 
            this.img_user.BackgroundImage = global::HR_Department_Project.Properties.Resources.user1;
            this.img_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_user.InitialImage = null;
            this.img_user.Location = new System.Drawing.Point(56, 77);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(252, 232);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_user.TabIndex = 37;
            this.img_user.TabStop = false;
            // 
            // btn_change_img
            // 
            this.btn_change_img.Location = new System.Drawing.Point(56, 306);
            this.btn_change_img.Name = "btn_change_img";
            this.btn_change_img.Size = new System.Drawing.Size(252, 35);
            this.btn_change_img.TabIndex = 38;
            this.btn_change_img.Text = "Thay đổi ảnh đại diện";
            this.btn_change_img.UseVisualStyleBackColor = true;
            this.btn_change_img.Click += new System.EventHandler(this.btn_change_img_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1055, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin cá nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txt_note);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(28, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(998, 606);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Person information";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txt_education);
            this.groupBox6.Controls.Add(this.txt_religion);
            this.groupBox6.Controls.Add(this.txt_ethnicity);
            this.groupBox6.Controls.Add(this.lb_ethnicity);
            this.groupBox6.Controls.Add(this.lb_education);
            this.groupBox6.Controls.Add(this.lb_religion);
            this.groupBox6.Location = new System.Drawing.Point(477, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(500, 194);
            this.groupBox6.TabIndex = 57;
            this.groupBox6.TabStop = false;
            // 
            // txt_education
            // 
            this.txt_education.Location = new System.Drawing.Point(168, 91);
            this.txt_education.Multiline = true;
            this.txt_education.Name = "txt_education";
            this.txt_education.Size = new System.Drawing.Size(269, 27);
            this.txt_education.TabIndex = 57;
            // 
            // txt_religion
            // 
            this.txt_religion.Location = new System.Drawing.Point(168, 144);
            this.txt_religion.Multiline = true;
            this.txt_religion.Name = "txt_religion";
            this.txt_religion.Size = new System.Drawing.Size(269, 27);
            this.txt_religion.TabIndex = 60;
            // 
            // txt_ethnicity
            // 
            this.txt_ethnicity.Location = new System.Drawing.Point(168, 38);
            this.txt_ethnicity.Multiline = true;
            this.txt_ethnicity.Name = "txt_ethnicity";
            this.txt_ethnicity.Size = new System.Drawing.Size(269, 27);
            this.txt_ethnicity.TabIndex = 58;
            // 
            // lb_ethnicity
            // 
            this.lb_ethnicity.AutoSize = true;
            this.lb_ethnicity.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ethnicity.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lb_ethnicity.Location = new System.Drawing.Point(6, 34);
            this.lb_ethnicity.Name = "lb_ethnicity";
            this.lb_ethnicity.Size = new System.Drawing.Size(100, 27);
            this.lb_ethnicity.TabIndex = 51;
            this.lb_ethnicity.Text = "Ethnicity";
            this.lb_ethnicity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_education
            // 
            this.lb_education.AutoSize = true;
            this.lb_education.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_education.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lb_education.Location = new System.Drawing.Point(6, 91);
            this.lb_education.Name = "lb_education";
            this.lb_education.Size = new System.Drawing.Size(110, 27);
            this.lb_education.TabIndex = 43;
            this.lb_education.Text = "Education";
            this.lb_education.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_religion
            // 
            this.lb_religion.AutoSize = true;
            this.lb_religion.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_religion.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lb_religion.Location = new System.Drawing.Point(6, 144);
            this.lb_religion.Name = "lb_religion";
            this.lb_religion.Size = new System.Drawing.Size(92, 27);
            this.lb_religion.TabIndex = 46;
            this.lb_religion.Text = "Religion";
            this.lb_religion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_national);
            this.groupBox5.Controls.Add(this.txt_image);
            this.groupBox5.Controls.Add(this.txt_phone_num);
            this.groupBox5.Controls.Add(this.lb_phone_num);
            this.groupBox5.Controls.Add(this.lb_image);
            this.groupBox5.Controls.Add(this.lb_nationality);
            this.groupBox5.Location = new System.Drawing.Point(19, 271);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(437, 194);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            // 
            // txt_national
            // 
            this.txt_national.Location = new System.Drawing.Point(162, 144);
            this.txt_national.Multiline = true;
            this.txt_national.Name = "txt_national";
            this.txt_national.Size = new System.Drawing.Size(243, 27);
            this.txt_national.TabIndex = 57;
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(162, 87);
            this.txt_image.Multiline = true;
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(243, 27);
            this.txt_image.TabIndex = 56;
            // 
            // txt_phone_num
            // 
            this.txt_phone_num.Location = new System.Drawing.Point(162, 34);
            this.txt_phone_num.Multiline = true;
            this.txt_phone_num.Name = "txt_phone_num";
            this.txt_phone_num.Size = new System.Drawing.Size(243, 27);
            this.txt_phone_num.TabIndex = 55;
            // 
            // lb_phone_num
            // 
            this.lb_phone_num.AutoSize = true;
            this.lb_phone_num.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone_num.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_phone_num.Location = new System.Drawing.Point(6, 34);
            this.lb_phone_num.Name = "lb_phone_num";
            this.lb_phone_num.Size = new System.Drawing.Size(152, 27);
            this.lb_phone_num.TabIndex = 44;
            this.lb_phone_num.Text = "Phone number";
            this.lb_phone_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_image
            // 
            this.lb_image.AutoSize = true;
            this.lb_image.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_image.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_image.Location = new System.Drawing.Point(6, 87);
            this.lb_image.Name = "lb_image";
            this.lb_image.Size = new System.Drawing.Size(71, 27);
            this.lb_image.TabIndex = 47;
            this.lb_image.Text = "Image";
            this.lb_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nationality
            // 
            this.lb_nationality.AutoSize = true;
            this.lb_nationality.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nationality.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_nationality.Location = new System.Drawing.Point(6, 144);
            this.lb_nationality.Name = "lb_nationality";
            this.lb_nationality.Size = new System.Drawing.Size(119, 27);
            this.lb_nationality.TabIndex = 49;
            this.lb_nationality.Text = "Nationality";
            this.lb_nationality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_birthplace);
            this.groupBox4.Controls.Add(this.txt_gender);
            this.groupBox4.Controls.Add(this.txt_fullname);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(19, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 201);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            // 
            // txt_birthplace
            // 
            this.txt_birthplace.Location = new System.Drawing.Point(162, 143);
            this.txt_birthplace.Multiline = true;
            this.txt_birthplace.Name = "txt_birthplace";
            this.txt_birthplace.Size = new System.Drawing.Size(243, 27);
            this.txt_birthplace.TabIndex = 54;
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(162, 86);
            this.txt_gender.Multiline = true;
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(243, 27);
            this.txt_gender.TabIndex = 53;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(162, 30);
            this.txt_fullname.Multiline = true;
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(243, 27);
            this.txt_fullname.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 51;
            this.label3.Text = "Birthplace";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 27);
            this.label2.TabIndex = 50;
            this.label2.Text = "Gender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "Full name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_birthday);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.txt_num_iden);
            this.groupBox1.Controls.Add(this.lb_iden_num);
            this.groupBox1.Controls.Add(this.lb_Address);
            this.groupBox1.Controls.Add(this.lb_birthday);
            this.groupBox1.Location = new System.Drawing.Point(477, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 201);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Location = new System.Drawing.Point(168, 86);
            this.txt_birthday.Multiline = true;
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(269, 27);
            this.txt_birthday.TabIndex = 56;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(168, 143);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(269, 27);
            this.txt_address.TabIndex = 59;
            // 
            // txt_num_iden
            // 
            this.txt_num_iden.Location = new System.Drawing.Point(168, 30);
            this.txt_num_iden.Multiline = true;
            this.txt_num_iden.Name = "txt_num_iden";
            this.txt_num_iden.Size = new System.Drawing.Size(269, 27);
            this.txt_num_iden.TabIndex = 55;
            // 
            // lb_iden_num
            // 
            this.lb_iden_num.AutoSize = true;
            this.lb_iden_num.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_iden_num.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_iden_num.Location = new System.Drawing.Point(6, 30);
            this.lb_iden_num.Name = "lb_iden_num";
            this.lb_iden_num.Size = new System.Drawing.Size(103, 27);
            this.lb_iden_num.TabIndex = 37;
            this.lb_iden_num.Text = "Iden num";
            this.lb_iden_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lb_Address.Location = new System.Drawing.Point(6, 144);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(90, 27);
            this.lb_Address.TabIndex = 50;
            this.lb_Address.Text = "Address";
            this.lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_birthday
            // 
            this.lb_birthday.AutoSize = true;
            this.lb_birthday.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birthday.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lb_birthday.Location = new System.Drawing.Point(6, 86);
            this.lb_birthday.Name = "lb_birthday";
            this.lb_birthday.Size = new System.Drawing.Size(96, 27);
            this.lb_birthday.TabIndex = 38;
            this.lb_birthday.Text = "Birthday";
            this.lb_birthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(19, 496);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(958, 85);
            this.txt_note.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1415, 207);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 22);
            this.textBox1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1415, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 188);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(384, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1063, 655);
            this.tabControl1.TabIndex = 0;
            // 
            // frm_user_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 652);
            this.Controls.Add(this.btn_change_img);
            this.Controls.Add(this.img_user);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_user_page";
            this.Text = "frm_user_page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_user_page_FormClosing);
            this.Load += new System.EventHandler(this.frm_user_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string user_name_employee = BLL.BLL_login.SESSION.username;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lb_username;
        public System.Windows.Forms.PictureBox img_user;
        private System.Windows.Forms.Button btn_change_img;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_education;
        private System.Windows.Forms.TextBox txt_religion;
        private System.Windows.Forms.TextBox txt_ethnicity;
        private System.Windows.Forms.Label lb_ethnicity;
        private System.Windows.Forms.Label lb_education;
        private System.Windows.Forms.Label lb_religion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_national;
        public System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.TextBox txt_phone_num;
        private System.Windows.Forms.Label lb_phone_num;
        private System.Windows.Forms.Label lb_image;
        private System.Windows.Forms.Label lb_nationality;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_birthplace;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_num_iden;
        private System.Windows.Forms.Label lb_iden_num;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_birthday;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}