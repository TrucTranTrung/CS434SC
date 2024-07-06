namespace HR_Department_Project.GUI
{
    partial class frm_admin_page
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add_permission = new System.Windows.Forms.Button();
            this.btn_change_permission = new System.Windows.Forms.Button();
            this.cb_user_role_id = new System.Windows.Forms.ComboBox();
            this.cb_role_id_p = new System.Windows.Forms.ComboBox();
            this.txt_role_id = new System.Windows.Forms.TextBox();
            this.cb_user_id = new System.Windows.Forms.ComboBox();
            this.GridView_userData = new System.Windows.Forms.DataGridView();
            this.txt_image = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete_role = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_edit_role = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_role = new System.Windows.Forms.Button();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.cb_role_id = new System.Windows.Forms.ComboBox();
            this.dataGridView_role = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_userData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1430, 689);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1422, 660);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cài đặt quyền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_add_permission);
            this.groupBox1.Controls.Add(this.btn_change_permission);
            this.groupBox1.Controls.Add(this.cb_user_role_id);
            this.groupBox1.Controls.Add(this.cb_role_id_p);
            this.groupBox1.Controls.Add(this.txt_role_id);
            this.groupBox1.Controls.Add(this.cb_user_id);
            this.groupBox1.Controls.Add(this.GridView_userData);
            this.groupBox1.Controls.Add(this.txt_image);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(423, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(565, 628);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User manager";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Vai trò";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Vai trò của người dùng";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(16, 565);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(531, 39);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Xóa quyền người dùng";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add_permission
            // 
            this.btn_add_permission.Location = new System.Drawing.Point(16, 475);
            this.btn_add_permission.Name = "btn_add_permission";
            this.btn_add_permission.Size = new System.Drawing.Size(531, 39);
            this.btn_add_permission.TabIndex = 14;
            this.btn_add_permission.Text = "Thêm quyền cho người dùng";
            this.btn_add_permission.UseVisualStyleBackColor = true;
            this.btn_add_permission.Click += new System.EventHandler(this.btn_add_permission_Click);
            // 
            // btn_change_permission
            // 
            this.btn_change_permission.Location = new System.Drawing.Point(16, 520);
            this.btn_change_permission.Name = "btn_change_permission";
            this.btn_change_permission.Size = new System.Drawing.Size(531, 39);
            this.btn_change_permission.TabIndex = 10;
            this.btn_change_permission.Text = "Thay đổi quyền";
            this.btn_change_permission.UseVisualStyleBackColor = true;
            this.btn_change_permission.Click += new System.EventHandler(this.btn_edit_permission_Click);
            // 
            // cb_user_role_id
            // 
            this.cb_user_role_id.FormattingEnabled = true;
            this.cb_user_role_id.Location = new System.Drawing.Point(16, 318);
            this.cb_user_role_id.Name = "cb_user_role_id";
            this.cb_user_role_id.Size = new System.Drawing.Size(531, 24);
            this.cb_user_role_id.TabIndex = 17;
            // 
            // cb_role_id_p
            // 
            this.cb_role_id_p.FormattingEnabled = true;
            this.cb_role_id_p.Location = new System.Drawing.Point(16, 419);
            this.cb_role_id_p.Name = "cb_role_id_p";
            this.cb_role_id_p.Size = new System.Drawing.Size(531, 24);
            this.cb_role_id_p.TabIndex = 13;
            this.cb_role_id_p.SelectedIndexChanged += new System.EventHandler(this.cb_role_id_p_SelectedIndexChanged);
            // 
            // txt_role_id
            // 
            this.txt_role_id.Location = new System.Drawing.Point(16, 265);
            this.txt_role_id.Name = "txt_role_id";
            this.txt_role_id.Size = new System.Drawing.Size(531, 22);
            this.txt_role_id.TabIndex = 18;
            // 
            // cb_user_id
            // 
            this.cb_user_id.FormattingEnabled = true;
            this.cb_user_id.Location = new System.Drawing.Point(16, 369);
            this.cb_user_id.Name = "cb_user_id";
            this.cb_user_id.Size = new System.Drawing.Size(531, 24);
            this.cb_user_id.TabIndex = 12;
            this.cb_user_id.SelectedIndexChanged += new System.EventHandler(this.cb_user_id_SelectedIndexChanged);
            // 
            // GridView_userData
            // 
            this.GridView_userData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_userData.Location = new System.Drawing.Point(7, 22);
            this.GridView_userData.Name = "GridView_userData";
            this.GridView_userData.RowTemplate.Height = 24;
            this.GridView_userData.Size = new System.Drawing.Size(551, 208);
            this.GridView_userData.TabIndex = 26;
            this.GridView_userData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_userData_CellClick);
            // 
            // txt_image
            // 
            this.txt_image.Location = new System.Drawing.Point(1415, 207);
            this.txt_image.Margin = new System.Windows.Forms.Padding(4);
            this.txt_image.Name = "txt_image";
            this.txt_image.Size = new System.Drawing.Size(181, 22);
            this.txt_image.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1415, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 188);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1422, 660);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bảng quyền";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete_role);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_edit_role);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_add_role);
            this.groupBox2.Controls.Add(this.txt_role);
            this.groupBox2.Controls.Add(this.cb_role_id);
            this.groupBox2.Controls.Add(this.dataGridView_role);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Location = new System.Drawing.Point(473, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(459, 563);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Role manager";
            // 
            // btn_delete_role
            // 
            this.btn_delete_role.Location = new System.Drawing.Point(0, 501);
            this.btn_delete_role.Name = "btn_delete_role";
            this.btn_delete_role.Size = new System.Drawing.Size(459, 30);
            this.btn_delete_role.TabIndex = 13;
            this.btn_delete_role.Text = "Xóa quyền";
            this.btn_delete_role.UseVisualStyleBackColor = true;
            this.btn_delete_role.Click += new System.EventHandler(this.btn_delete_role_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nhập tên vai trò";
            // 
            // btn_edit_role
            // 
            this.btn_edit_role.Location = new System.Drawing.Point(0, 445);
            this.btn_edit_role.Name = "btn_edit_role";
            this.btn_edit_role.Size = new System.Drawing.Size(459, 30);
            this.btn_edit_role.TabIndex = 12;
            this.btn_edit_role.Text = "Sửa quyền";
            this.btn_edit_role.UseVisualStyleBackColor = true;
            this.btn_edit_role.Click += new System.EventHandler(this.btn_edit_role_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vai Trò";
            // 
            // btn_add_role
            // 
            this.btn_add_role.Location = new System.Drawing.Point(0, 387);
            this.btn_add_role.Name = "btn_add_role";
            this.btn_add_role.Size = new System.Drawing.Size(459, 30);
            this.btn_add_role.TabIndex = 11;
            this.btn_add_role.Text = "Thêm quyền";
            this.btn_add_role.UseVisualStyleBackColor = true;
            this.btn_add_role.Click += new System.EventHandler(this.btn_add_role_Click);
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(0, 327);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(459, 22);
            this.txt_role.TabIndex = 16;
            // 
            // cb_role_id
            // 
            this.cb_role_id.FormattingEnabled = true;
            this.cb_role_id.Location = new System.Drawing.Point(0, 263);
            this.cb_role_id.Name = "cb_role_id";
            this.cb_role_id.Size = new System.Drawing.Size(459, 24);
            this.cb_role_id.TabIndex = 20;
            this.cb_role_id.SelectedIndexChanged += new System.EventHandler(this.cb_role_id_SelectedIndexChanged);
            // 
            // dataGridView_role
            // 
            this.dataGridView_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_role.Location = new System.Drawing.Point(7, 22);
            this.dataGridView_role.Name = "dataGridView_role";
            this.dataGridView_role.RowTemplate.Height = 24;
            this.dataGridView_role.Size = new System.Drawing.Size(445, 138);
            this.dataGridView_role.TabIndex = 26;
            this.dataGridView_role.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_role_CellClick);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(100, 28);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 24);
            this.toolStripMenuItem2.Text = "file";
            // 
            // frm_admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 690);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_admin_page";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.frm_admin_page_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_userData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridView_userData;
        private System.Windows.Forms.TextBox txt_image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_change_permission;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_role;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_add_role;
        private System.Windows.Forms.Button btn_edit_role;
        private System.Windows.Forms.Button btn_delete_role;
        public System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_role_id;
        public System.Windows.Forms.ComboBox cb_user_id;
        public System.Windows.Forms.ComboBox cb_role_id_p;
        private System.Windows.Forms.Button btn_add_permission;
        public System.Windows.Forms.ComboBox cb_user_role_id;
        private System.Windows.Forms.TextBox txt_role_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}