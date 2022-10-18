namespace HP_MANAGEMENT_SYSTEM
{
    partial class frm_Employee_Details_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Employee_Details_List));
            this.lbl_Employee_Details_List = new System.Windows.Forms.Label();
            this.btn_Add_Emp_Details = new System.Windows.Forms.Button();
            this.dgv_View_Employee_Details = new System.Windows.Forms.DataGridView();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adharNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hP_MANAGEMENT_SYSTEM_DBDataSet = new HP_MANAGEMENT_SYSTEM.HP_MANAGEMENT_SYSTEM_DBDataSet();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Search_Emp_Details = new System.Windows.Forms.Button();
            this.employee_DetailsTableAdapter = new HP_MANAGEMENT_SYSTEM.HP_MANAGEMENT_SYSTEM_DBDataSetTableAdapters.Employee_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hP_MANAGEMENT_SYSTEM_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Details_List
            // 
            this.lbl_Employee_Details_List.AutoSize = true;
            this.lbl_Employee_Details_List.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Employee_Details_List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Employee_Details_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Details_List.Location = new System.Drawing.Point(310, 22);
            this.lbl_Employee_Details_List.Name = "lbl_Employee_Details_List";
            this.lbl_Employee_Details_List.Size = new System.Drawing.Size(599, 69);
            this.lbl_Employee_Details_List.TabIndex = 0;
            this.lbl_Employee_Details_List.Text = "Employee Details List";
            // 
            // btn_Add_Emp_Details
            // 
            this.btn_Add_Emp_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add_Emp_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Emp_Details.Location = new System.Drawing.Point(711, 603);
            this.btn_Add_Emp_Details.Name = "btn_Add_Emp_Details";
            this.btn_Add_Emp_Details.Size = new System.Drawing.Size(372, 62);
            this.btn_Add_Emp_Details.TabIndex = 3;
            this.btn_Add_Emp_Details.Text = "Add Emp Details";
            this.btn_Add_Emp_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Emp_Details.Click += new System.EventHandler(this.btn_Add_New_Employee_Details_Click);
            // 
            // dgv_View_Employee_Details
            // 
            this.dgv_View_Employee_Details.AllowUserToAddRows = false;
            this.dgv_View_Employee_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Employee_Details.AutoGenerateColumns = false;
            this.dgv_View_Employee_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Employee_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Employee_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Employee_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.adharNoDataGridViewTextBoxColumn});
            this.dgv_View_Employee_Details.DataSource = this.employeeDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_View_Employee_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_View_Employee_Details.Location = new System.Drawing.Point(47, 116);
            this.dgv_View_Employee_Details.Name = "dgv_View_Employee_Details";
            this.dgv_View_Employee_Details.ReadOnly = true;
            this.dgv_View_Employee_Details.RowTemplate.Height = 24;
            this.dgv_View_Employee_Details.Size = new System.Drawing.Size(1150, 450);
            this.dgv_View_Employee_Details.TabIndex = 1;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID";
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adharNoDataGridViewTextBoxColumn
            // 
            this.adharNoDataGridViewTextBoxColumn.DataPropertyName = "Adhar_No";
            this.adharNoDataGridViewTextBoxColumn.HeaderText = "Adhar_No";
            this.adharNoDataGridViewTextBoxColumn.Name = "adharNoDataGridViewTextBoxColumn";
            this.adharNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.hP_MANAGEMENT_SYSTEM_DBDataSet;
            // 
            // hP_MANAGEMENT_SYSTEM_DBDataSet
            // 
            this.hP_MANAGEMENT_SYSTEM_DBDataSet.DataSetName = "HP_MANAGEMENT_SYSTEM_DBDataSet";
            this.hP_MANAGEMENT_SYSTEM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Logout.Location = new System.Drawing.Point(1111, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(117, 50);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Search_Emp_Details
            // 
            this.btn_Search_Emp_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Search_Emp_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_Emp_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Search_Emp_Details.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Search_Emp_Details.Location = new System.Drawing.Point(219, 603);
            this.btn_Search_Emp_Details.Name = "btn_Search_Emp_Details";
            this.btn_Search_Emp_Details.Size = new System.Drawing.Size(379, 60);
            this.btn_Search_Emp_Details.TabIndex = 2;
            this.btn_Search_Emp_Details.Text = "Search Emp Details";
            this.btn_Search_Emp_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Emp_Details.Click += new System.EventHandler(this.btn_Search_Emp_Details_Click);
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Employee_Details_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1240, 711);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search_Emp_Details);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dgv_View_Employee_Details);
            this.Controls.Add(this.btn_Add_Emp_Details);
            this.Controls.Add(this.lbl_Employee_Details_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Employee_Details_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Employee Details";
            this.Load += new System.EventHandler(this.frm_Employee_Details_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Employee_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hP_MANAGEMENT_SYSTEM_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Details_List;
        private System.Windows.Forms.Button btn_Add_Emp_Details;
        private System.Windows.Forms.DataGridView dgv_View_Employee_Details;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Search_Emp_Details;
        private HP_MANAGEMENT_SYSTEM_DBDataSet hP_MANAGEMENT_SYSTEM_DBDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private HP_MANAGEMENT_SYSTEM_DBDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adharNoDataGridViewTextBoxColumn;
    }
}