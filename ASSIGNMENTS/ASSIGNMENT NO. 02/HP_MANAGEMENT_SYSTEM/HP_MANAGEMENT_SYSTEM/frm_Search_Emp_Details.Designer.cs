namespace HP_MANAGEMENT_SYSTEM
{
    partial class frm_Search_Emp_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Search_Emp_Details));
            this.tb_Adhar_No = new System.Windows.Forms.TextBox();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_View_Emp_Details = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Emp_ID = new System.Windows.Forms.TextBox();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_ID = new System.Windows.Forms.Label();
            this.lbl_Search_Employee_Details = new System.Windows.Forms.Label();
            this.btn_Add_Emp_Details = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Adhar_No
            // 
            this.tb_Adhar_No.Enabled = false;
            this.tb_Adhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_Adhar_No.Location = new System.Drawing.Point(611, 522);
            this.tb_Adhar_No.MaxLength = 12;
            this.tb_Adhar_No.Name = "tb_Adhar_No";
            this.tb_Adhar_No.Size = new System.Drawing.Size(349, 45);
            this.tb_Adhar_No.TabIndex = 19;
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Adhar_No.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Adhar_No.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Adhar_No.Location = new System.Drawing.Point(187, 525);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(163, 41);
            this.lbl_Adhar_No.TabIndex = 23;
            this.lbl_Adhar_No.Text = "Adhar No";
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_Logout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Logout.Location = new System.Drawing.Point(1058, 9);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(117, 50);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_View_Emp_Details
            // 
            this.btn_View_Emp_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_View_Emp_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_Emp_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btn_View_Emp_Details.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_View_Emp_Details.Location = new System.Drawing.Point(790, 611);
            this.btn_View_Emp_Details.Name = "btn_View_Emp_Details";
            this.btn_View_Emp_Details.Size = new System.Drawing.Size(339, 60);
            this.btn_View_Emp_Details.TabIndex = 5;
            this.btn_View_Emp_Details.Text = "View Emp Details";
            this.btn_View_Emp_Details.UseVisualStyleBackColor = false;
            this.btn_View_Emp_Details.Click += new System.EventHandler(this.btn_View_Emp_Details_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Refresh.Location = new System.Drawing.Point(120, 611);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(183, 60);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Enabled = false;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_Mobile_No.Location = new System.Drawing.Point(611, 427);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(349, 45);
            this.tb_Mobile_No.TabIndex = 18;
            // 
            // tb_Address
            // 
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_Address.Location = new System.Drawing.Point(611, 332);
            this.tb_Address.MaxLength = 120;
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(349, 45);
            this.tb_Address.TabIndex = 17;
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_Name.Location = new System.Drawing.Point(611, 238);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(349, 45);
            this.tb_Name.TabIndex = 16;
            // 
            // tb_Emp_ID
            // 
            this.tb_Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tb_Emp_ID.Location = new System.Drawing.Point(611, 151);
            this.tb_Emp_ID.MaxLength = 5;
            this.tb_Emp_ID.Name = "tb_Emp_ID";
            this.tb_Emp_ID.Size = new System.Drawing.Size(349, 45);
            this.tb_Emp_ID.TabIndex = 1;
            this.tb_Emp_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numric);
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Mobile_No.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Mobile_No.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(187, 430);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(173, 41);
            this.lbl_Mobile_No.TabIndex = 11;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Address.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Address.Location = new System.Drawing.Point(187, 335);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(144, 41);
            this.lbl_Address.TabIndex = 10;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Name.Location = new System.Drawing.Point(187, 241);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(110, 41);
            this.lbl_Name.TabIndex = 12;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Emp_ID
            // 
            this.lbl_Emp_ID.AutoSize = true;
            this.lbl_Emp_ID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Emp_ID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_Emp_ID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Emp_ID.Location = new System.Drawing.Point(187, 154);
            this.lbl_Emp_ID.Name = "lbl_Emp_ID";
            this.lbl_Emp_ID.Size = new System.Drawing.Size(133, 41);
            this.lbl_Emp_ID.TabIndex = 14;
            this.lbl_Emp_ID.Text = "Emp ID";
            // 
            // lbl_Search_Employee_Details
            // 
            this.lbl_Search_Employee_Details.AutoSize = true;
            this.lbl_Search_Employee_Details.BackColor = System.Drawing.Color.Black;
            this.lbl_Search_Employee_Details.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Search_Employee_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.lbl_Search_Employee_Details.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Search_Employee_Details.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Search_Employee_Details.Location = new System.Drawing.Point(233, 35);
            this.lbl_Search_Employee_Details.Name = "lbl_Search_Employee_Details";
            this.lbl_Search_Employee_Details.Size = new System.Drawing.Size(718, 69);
            this.lbl_Search_Employee_Details.TabIndex = 13;
            this.lbl_Search_Employee_Details.Text = "Search Employee Details";
            // 
            // btn_Add_Emp_Details
            // 
            this.btn_Add_Emp_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add_Emp_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Emp_Details.Location = new System.Drawing.Point(374, 611);
            this.btn_Add_Emp_Details.Name = "btn_Add_Emp_Details";
            this.btn_Add_Emp_Details.Size = new System.Drawing.Size(331, 62);
            this.btn_Add_Emp_Details.TabIndex = 4;
            this.btn_Add_Emp_Details.Text = "Add Emp Details";
            this.btn_Add_Emp_Details.UseVisualStyleBackColor = false;
            this.btn_Add_Emp_Details.Click += new System.EventHandler(this.btn_Add_Emp_Details_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Tan;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Blue;
            this.btn_Search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Search.Location = new System.Drawing.Point(1004, 143);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 61);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Search_Emp_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1194, 715);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add_Emp_Details);
            this.Controls.Add(this.tb_Adhar_No);
            this.Controls.Add(this.lbl_Adhar_No);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_View_Emp_Details);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Emp_ID);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Emp_ID);
            this.Controls.Add(this.lbl_Search_Employee_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Search_Emp_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Emp Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Adhar_No;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_View_Emp_Details;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Emp_ID;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Emp_ID;
        private System.Windows.Forms.Label lbl_Search_Employee_Details;
        private System.Windows.Forms.Button btn_Add_Emp_Details;
        private System.Windows.Forms.Button btn_Search;
    }
}