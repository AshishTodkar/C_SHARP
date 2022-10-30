namespace LP_MANAGEMENT_SYSTEM
{
    partial class frm_Student_Details_List
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student_Details_List));
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Logout = new System.Windows.Forms.Button();
            this.dgv_View_Student_Details = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lPStudentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lP_MANAGEMENT_SYSTEM_DBDataSet = new LP_MANAGEMENT_SYSTEM.LP_MANAGEMENT_SYSTEM_DBDataSet();
            this.btn_Add_New_Student_Details = new System.Windows.Forms.Button();
            this.lbl_Student_Details_List = new System.Windows.Forms.Label();
            this.lP_Student_DetailsTableAdapter = new LP_MANAGEMENT_SYSTEM.LP_MANAGEMENT_SYSTEM_DBDataSetTableAdapters.LP_Student_DetailsTableAdapter();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.lbl_User_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPStudentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP_MANAGEMENT_SYSTEM_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1075, 14);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(106, 46);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // dgv_View_Student_Details
            // 
            this.dgv_View_Student_Details.AllowUserToAddRows = false;
            this.dgv_View_Student_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Student_Details.AutoGenerateColumns = false;
            this.dgv_View_Student_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Student_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Student_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Student_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_View_Student_Details.DataSource = this.lPStudentDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Student_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Student_Details.Location = new System.Drawing.Point(38, 122);
            this.dgv_View_Student_Details.Name = "dgv_View_Student_Details";
            this.dgv_View_Student_Details.ReadOnly = true;
            this.dgv_View_Student_Details.RowTemplate.Height = 24;
            this.dgv_View_Student_Details.Size = new System.Drawing.Size(1100, 450);
            this.dgv_View_Student_Details.TabIndex = 1;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lPStudentDetailsBindingSource
            // 
            this.lPStudentDetailsBindingSource.DataMember = "LP_Student_Details";
            this.lPStudentDetailsBindingSource.DataSource = this.lP_MANAGEMENT_SYSTEM_DBDataSet;
            // 
            // lP_MANAGEMENT_SYSTEM_DBDataSet
            // 
            this.lP_MANAGEMENT_SYSTEM_DBDataSet.DataSetName = "LP_MANAGEMENT_SYSTEM_DBDataSet";
            this.lP_MANAGEMENT_SYSTEM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Add_New_Student_Details
            // 
            this.btn_Add_New_Student_Details.BackColor = System.Drawing.Color.Tan;
            this.btn_Add_New_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Student_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add_New_Student_Details.Location = new System.Drawing.Point(627, 610);
            this.btn_Add_New_Student_Details.Name = "btn_Add_New_Student_Details";
            this.btn_Add_New_Student_Details.Size = new System.Drawing.Size(443, 57);
            this.btn_Add_New_Student_Details.TabIndex = 3;
            this.btn_Add_New_Student_Details.Text = "Add New Student Details";
            this.btn_Add_New_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Add_New_Student_Details.Click += new System.EventHandler(this.btn_Add_New_Student_Details_Click);
            // 
            // lbl_Student_Details_List
            // 
            this.lbl_Student_Details_List.AutoSize = true;
            this.lbl_Student_Details_List.BackColor = System.Drawing.Color.Plum;
            this.lbl_Student_Details_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Student_Details_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Details_List.Location = new System.Drawing.Point(288, 26);
            this.lbl_Student_Details_List.Name = "lbl_Student_Details_List";
            this.lbl_Student_Details_List.Size = new System.Drawing.Size(539, 69);
            this.lbl_Student_Details_List.TabIndex = 7;
            this.lbl_Student_Details_List.Text = "Student Details List";
            // 
            // lP_Student_DetailsTableAdapter
            // 
            this.lP_Student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.Color.Tan;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(147, 610);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(420, 57);
            this.btn_Search_Student_Details.TabIndex = 2;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // lbl_User_Login
            // 
            this.lbl_User_Login.AutoSize = true;
            this.lbl_User_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Login.ForeColor = System.Drawing.Color.Blue;
            this.lbl_User_Login.Location = new System.Drawing.Point(12, 14);
            this.lbl_User_Login.Name = "lbl_User_Login";
            this.lbl_User_Login.Size = new System.Drawing.Size(86, 20);
            this.lbl_User_Login.TabIndex = 30;
            this.lbl_User_Login.Text = "Username";
            // 
            // frm_Student_Details_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1194, 715);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_User_Login);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_View_Student_Details);
            this.Controls.Add(this.btn_Add_New_Student_Details);
            this.Controls.Add(this.lbl_Student_Details_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Student_Details_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details List";
            this.Load += new System.EventHandler(this.frm_Student_Details_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Student_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPStudentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lP_MANAGEMENT_SYSTEM_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.DataGridView dgv_View_Student_Details;
        private System.Windows.Forms.Button btn_Add_New_Student_Details;
        private System.Windows.Forms.Label lbl_Student_Details_List;
        private LP_MANAGEMENT_SYSTEM_DBDataSet lP_MANAGEMENT_SYSTEM_DBDataSet;
        private System.Windows.Forms.BindingSource lPStudentDetailsBindingSource;
        private LP_MANAGEMENT_SYSTEM_DBDataSetTableAdapters.LP_Student_DetailsTableAdapter lP_Student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Search_Student_Details;
        private System.Windows.Forms.Label lbl_User_Login;
    }
}