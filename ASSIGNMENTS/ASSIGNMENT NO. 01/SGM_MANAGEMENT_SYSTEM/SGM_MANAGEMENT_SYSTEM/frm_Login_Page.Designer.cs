namespace SGM_MANAGEMENT_SYSTEM
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_SGM_Login = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SGM_Login
            // 
            this.lbl_SGM_Login.AutoSize = true;
            this.lbl_SGM_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_SGM_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SGM_Login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_SGM_Login.Location = new System.Drawing.Point(224, 37);
            this.lbl_SGM_Login.Name = "lbl_SGM_Login";
            this.lbl_SGM_Login.Size = new System.Drawing.Size(743, 76);
            this.lbl_SGM_Login.TabIndex = 0;
            this.lbl_SGM_Login.Text = "SGM  LOGIN  SYSTEM";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(168, 236);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(259, 60);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(180, 411);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(247, 60);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(715, 411);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(313, 55);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // tb_Username
            // 
            this.tb_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(715, 236);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(313, 55);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.LightPink;
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Submit.Location = new System.Drawing.Point(472, 610);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(219, 74);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Black;
            this.lbl_Error.Location = new System.Drawing.Point(397, 527);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(388, 36);
            this.lbl_Error.TabIndex = 4;
            this.lbl_Error.Text = "Please Enter Valid Username And Password";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Error.Visible = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1194, 715);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_SGM_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SGM_Login;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Error;
    }
}

