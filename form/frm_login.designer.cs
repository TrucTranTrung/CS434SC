using System.Windows.Forms;

namespace HR_Department_Project.GUI
{
    partial class frm_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.tab_register = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password_r = new System.Windows.Forms.TextBox();
            this.txt_username_r = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab_login.SuspendLayout();
            this.tab_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_login);
            this.tabControl1.Controls.Add(this.tab_register);
            this.tabControl1.Location = new System.Drawing.Point(-6, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_login
            // 
            this.tab_login.Controls.Add(this.label9);
            this.tab_login.Controls.Add(this.pictureBox2);
            this.tab_login.Controls.Add(this.label8);
            this.tab_login.Controls.Add(this.pictureBox1);
            this.tab_login.Controls.Add(this.label7);
            this.tab_login.Controls.Add(this.label6);
            this.tab_login.Controls.Add(this.label);
            this.tab_login.Controls.Add(this.label2);
            this.tab_login.Controls.Add(this.label1);
            this.tab_login.Controls.Add(this.txt_password);
            this.tab_login.Controls.Add(this.txt_username);
            this.tab_login.Controls.Add(this.btn_login);
            this.tab_login.Location = new System.Drawing.Point(4, 25);
            this.tab_login.Name = "tab_login";
            this.tab_login.Padding = new System.Windows.Forms.Padding(3);
            this.tab_login.Size = new System.Drawing.Size(803, 422);
            this.tab_login.TabIndex = 0;
            this.tab_login.Text = "Đăng nhập";
            this.tab_login.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(147, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 38);
            this.label6.TabIndex = 35;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label.Location = new System.Drawing.Point(500, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(184, 32);
            this.label.TabIndex = 34;
            this.label.Text = "ĐĂNG NHẬP";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(594, 213);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(154, 22);
            this.txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(594, 144);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(154, 22);
            this.txt_username.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Maroon;
            this.btn_login.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_login.Location = new System.Drawing.Point(506, 281);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(166, 41);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tab_register
            // 
            this.tab_register.Controls.Add(this.label5);
            this.tab_register.Controls.Add(this.label4);
            this.tab_register.Controls.Add(this.label3);
            this.tab_register.Controls.Add(this.txt_password_r);
            this.tab_register.Controls.Add(this.txt_username_r);
            this.tab_register.Controls.Add(this.btn_register);
            this.tab_register.Location = new System.Drawing.Point(4, 25);
            this.tab_register.Name = "tab_register";
            this.tab_register.Padding = new System.Windows.Forms.Padding(3);
            this.tab_register.Size = new System.Drawing.Size(803, 422);
            this.tab_register.TabIndex = 1;
            this.tab_register.Text = "Đăng ký";
            this.tab_register.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(302, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 32);
            this.label5.TabIndex = 34;
            this.label5.Text = "ĐĂNG KÝ TÀI KHOẢN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên đăng nhập";
            // 
            // txt_password_r
            // 
            this.txt_password_r.Location = new System.Drawing.Point(246, 223);
            this.txt_password_r.Name = "txt_password_r";
            this.txt_password_r.Size = new System.Drawing.Size(448, 22);
            this.txt_password_r.TabIndex = 2;
            // 
            // txt_username_r
            // 
            this.txt_username_r.Location = new System.Drawing.Point(246, 156);
            this.txt_username_r.Name = "txt_username_r";
            this.txt_username_r.Size = new System.Drawing.Size(448, 22);
            this.txt_username_r.TabIndex = 1;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(246, 301);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(448, 35);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 479);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 10);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(465, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 55);
            this.label8.TabIndex = 39;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(366, 426);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(53, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 51);
            this.label9.TabIndex = 41;
            this.label9.Text = "WELCOME";
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_login";
            this.Text = "Đăng nhập quản lý nhân sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_login_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tab_login.ResumeLayout(false);
            this.tab_login.PerformLayout();
            this.tab_register.ResumeLayout(false);
            this.tab_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_login;
        private System.Windows.Forms.TabPage tab_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_password;
        public System.Windows.Forms.TextBox txt_username;
        public TextBox txt_password_r;
        public TextBox txt_username_r;
        private Button btn_register;
        private Label label4;
        private Label label3;
        private Label label;
        private Label label5;
        public System.Windows.Forms.Panel panel_mid;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox2;

        public TextBox Txt_username_r { get => txt_username_r; set => txt_username_r = value; }
        public TextBox Txt_password_r { get => txt_password_r; set => txt_password_r = value; }

        public TextBox Txt_username { get => txt_username; set => txt_username = value; }
        public TextBox Txt_password { get => txt_password; set => txt_password = value; }
    }
}