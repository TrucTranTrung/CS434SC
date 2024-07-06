namespace HR_Department_Project.GUI
{
    partial class frm_staff_informations
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_so_luong = new System.Windows.Forms.TextBox();
            this.txt_marriage = new System.Windows.Forms.ComboBox();
            this.txt_expiry_date = new System.Windows.Forms.DateTimePicker();
            this.txt_singing_date = new System.Windows.Forms.DateTimePicker();
            this.txt_day_of_work = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.combox_departmet = new System.Windows.Forms.ComboBox();
            this.combo_personal_information = new System.Windows.Forms.ComboBox();
            this.txt_contract_type = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cb_pos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_pos);
            this.groupBox1.Controls.Add(this.txt_so_luong);
            this.groupBox1.Controls.Add(this.txt_marriage);
            this.groupBox1.Controls.Add(this.txt_expiry_date);
            this.groupBox1.Controls.Add(this.txt_singing_date);
            this.groupBox1.Controls.Add(this.txt_day_of_work);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.combox_departmet);
            this.groupBox1.Controls.Add(this.combo_personal_information);
            this.groupBox1.Controls.Add(this.txt_contract_type);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1299, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff information";
            // 
            // txt_so_luong
            // 
            this.txt_so_luong.Location = new System.Drawing.Point(652, 212);
            this.txt_so_luong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_so_luong.Name = "txt_so_luong";
            this.txt_so_luong.Size = new System.Drawing.Size(257, 22);
            this.txt_so_luong.TabIndex = 31;
            // 
            // txt_marriage
            // 
            this.txt_marriage.FormattingEnabled = true;
            this.txt_marriage.Items.AddRange(new object[] {
            "ĐÃ KẾT HÔN",
            "CHƯA KẾT HÔN"});
            this.txt_marriage.Location = new System.Drawing.Point(144, 33);
            this.txt_marriage.Margin = new System.Windows.Forms.Padding(4);
            this.txt_marriage.Name = "txt_marriage";
            this.txt_marriage.Size = new System.Drawing.Size(257, 24);
            this.txt_marriage.TabIndex = 30;
            // 
            // txt_expiry_date
            // 
            this.txt_expiry_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_expiry_date.Location = new System.Drawing.Point(652, 89);
            this.txt_expiry_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_expiry_date.Name = "txt_expiry_date";
            this.txt_expiry_date.Size = new System.Drawing.Size(257, 22);
            this.txt_expiry_date.TabIndex = 28;
            // 
            // txt_singing_date
            // 
            this.txt_singing_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_singing_date.Location = new System.Drawing.Point(652, 30);
            this.txt_singing_date.Margin = new System.Windows.Forms.Padding(4);
            this.txt_singing_date.Name = "txt_singing_date";
            this.txt_singing_date.Size = new System.Drawing.Size(257, 22);
            this.txt_singing_date.TabIndex = 27;
            // 
            // txt_day_of_work
            // 
            this.txt_day_of_work.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_day_of_work.Location = new System.Drawing.Point(144, 213);
            this.txt_day_of_work.Margin = new System.Windows.Forms.Padding(4);
            this.txt_day_of_work.Name = "txt_day_of_work";
            this.txt_day_of_work.Size = new System.Drawing.Size(257, 22);
            this.txt_day_of_work.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1072, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 24;
            // 
            // combox_departmet
            // 
            this.combox_departmet.FormattingEnabled = true;
            this.combox_departmet.Location = new System.Drawing.Point(652, 156);
            this.combox_departmet.Margin = new System.Windows.Forms.Padding(4);
            this.combox_departmet.Name = "combox_departmet";
            this.combox_departmet.Size = new System.Drawing.Size(257, 24);
            this.combox_departmet.TabIndex = 22;
            // 
            // combo_personal_information
            // 
            this.combo_personal_information.FormattingEnabled = true;
            this.combo_personal_information.Location = new System.Drawing.Point(1080, 32);
            this.combo_personal_information.Margin = new System.Windows.Forms.Padding(4);
            this.combo_personal_information.Name = "combo_personal_information";
            this.combo_personal_information.Size = new System.Drawing.Size(195, 24);
            this.combo_personal_information.TabIndex = 20;
            // 
            // txt_contract_type
            // 
            this.txt_contract_type.Location = new System.Drawing.Point(144, 151);
            this.txt_contract_type.Margin = new System.Windows.Forms.Padding(4);
            this.txt_contract_type.Name = "txt_contract_type";
            this.txt_contract_type.Size = new System.Drawing.Size(257, 22);
            this.txt_contract_type.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(931, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Identification Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Department name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Expiry date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Signing date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Day of work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contract type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marriage";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_count);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.btn_exit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_create);
            this.groupBox2.Controls.Add(this.btn_refresh);
            this.groupBox2.Location = new System.Drawing.Point(16, 298);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1299, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(988, 25);
            this.btn_count.Margin = new System.Windows.Forms.Padding(4);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(100, 28);
            this.btn_count.TabIndex = 6;
            this.btn_count.Text = "Count";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(453, 23);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 28);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(811, 23);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 28);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1148, 23);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 28);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(640, 25);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 28);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(280, 25);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(100, 28);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(87, 25);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(100, 28);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 388);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1299, 290);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // cb_pos
            // 
            this.cb_pos.FormattingEnabled = true;
            this.cb_pos.Items.AddRange(new object[] {
            "ĐÃ KẾT HÔN",
            "CHƯA KẾT HÔN"});
            this.cb_pos.Location = new System.Drawing.Point(144, 89);
            this.cb_pos.Margin = new System.Windows.Forms.Padding(4);
            this.cb_pos.Name = "cb_pos";
            this.cb_pos.Size = new System.Drawing.Size(257, 24);
            this.cb_pos.TabIndex = 32;
            // 
            // frm_staff_informations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 685);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_staff_informations";
            this.Text = "frm_staff_informations";
            this.Load += new System.EventHandler(this.frm_staff_informations_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button btn_refresh;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox txt_contract_type;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox combox_departmet;
        public System.Windows.Forms.ComboBox combo_personal_information;
        public System.Windows.Forms.Button btn_count;
        public System.Windows.Forms.Button btn_update;
        public System.Windows.Forms.Button btn_search;
        public System.Windows.Forms.Button btn_exit;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_create;
        public System.Windows.Forms.DateTimePicker txt_expiry_date;
        public System.Windows.Forms.DateTimePicker txt_singing_date;
        public System.Windows.Forms.DateTimePicker txt_day_of_work;
        public System.Windows.Forms.ComboBox txt_marriage;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txt_so_luong;
        public System.Windows.Forms.ComboBox cb_pos;
    }
}