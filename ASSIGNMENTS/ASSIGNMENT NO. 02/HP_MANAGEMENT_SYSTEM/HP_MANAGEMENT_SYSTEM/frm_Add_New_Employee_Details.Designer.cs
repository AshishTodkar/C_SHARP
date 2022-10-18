namespace HP_MANAGEMENT_SYSTEM
{
    partial class frm_Add_New_Employee_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Employee_Details));
            this.lbl_Add_New_Employee_Details = new System.Windows.Forms.Label();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_View_Emp_Details = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.tb_Adhar_No = new System.Windows.Forms.TextBox();
            this.btn_Search_Emp_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Add_New_Employee_Details
            // 
            resources.ApplyResources(this.lbl_Add_New_Employee_Details, "lbl_Add_New_Employee_Details");
            this.lbl_Add_New_Employee_Details.BackColor = System.Drawing.Color.Plum;
            this.lbl_Add_New_Employee_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Add_New_Employee_Details.Name = "lbl_Add_New_Employee_Details";
            // 
            // lbl_Emp_ID
            // 
            resources.ApplyResources(this.lbl_Emp_ID, "lbl_Emp_ID");
            this.lbl_Emp_ID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Emp_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            // 
            // lbl_Name
            // 
            resources.ApplyResources(this.lbl_Name, "lbl_Name");
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Name.Name = "lbl_Name";
            // 
            // lbl_Address
            // 
            resources.ApplyResources(this.lbl_Address, "lbl_Address");
            this.lbl_Address.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Address.Name = "lbl_Address";
            // 
            // lbl_Mobile_No
            // 
            resources.ApplyResources(this.lbl_Mobile_No, "lbl_Mobile_No");
            this.lbl_Mobile_No.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Mobile_No.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            // 
            // tb_Emp_ID
            // 
            resources.ApplyResources(this.tb_Emp_ID, "tb_Emp_ID");
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // tb_Name
            // 
            resources.ApplyResources(this.tb_Name, "tb_Name");
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Address
            // 
            resources.ApplyResources(this.tb_Address, "tb_Address");
            this.tb_Address.Name = "tb_Address";
            // 
            // tb_Mobile_No
            // 
            resources.ApplyResources(this.tb_Mobile_No, "tb_Mobile_No");
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_View_Emp_Details
            // 
            this.btn_View_Emp_Details.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_View_Emp_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_View_Emp_Details, "btn_View_Emp_Details");
            this.btn_View_Emp_Details.Name = "btn_View_Emp_Details";
            this.btn_View_Emp_Details.UseVisualStyleBackColor = false;
            this.btn_View_Emp_Details.Click += new System.EventHandler(this.btn_View_All_Employee_Details_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Logout, "btn_Logout");
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Adhar_No
            // 
            resources.ApplyResources(this.lbl_Adhar_No, "lbl_Adhar_No");
            this.lbl_Adhar_No.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Adhar_No.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            // 
            // tb_Adhar_No
            // 
            resources.ApplyResources(this.tb_Adhar_No, "tb_Adhar_No");
            this.tb_Adhar_No.Name = "tb_Adhar_No";
            this.tb_Adhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // btn_Search_Emp_Details
            // 
            this.btn_Search_Emp_Details.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Search_Emp_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_Search_Emp_Details, "btn_Search_Emp_Details");
            this.btn_Search_Emp_Details.Name = "btn_Search_Emp_Details";
            this.btn_Search_Emp_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Emp_Details.Click += new System.EventHandler(this.btn_Search_Emp_Details_Click);
            // 
            // frm_Add_New_Employee_Details
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search_Emp_Details);
            this.Controls.Add(this.tb_Adhar_No);
            this.Controls.Add(this.lbl_Adhar_No);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Emp_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Controls.Add(this.lbl_Add_New_Employee_Details);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Employee_Details";
            this.Load += new System.EventHandler(this.frm_Add_New_Employee_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_New_Employee_Details;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_View_Emp_Details;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.TextBox tb_Adhar_No;
        private System.Windows.Forms.Button btn_Search_Emp_Details;
    }
}