using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LP_MANAGEMENT_SYSTEM
{
    public partial class frm_Login_Page : Form
    {
        public frm_Login_Page()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\Sqlexpress;Initial Catalog=LP_MANAGEMENT_SYSTEM_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Visible = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From LP_Login_Details Where Username = @UNm And Password = @Pw";

            Cmd.Parameters.Add("UNm", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pw", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Successfully", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Shared_Class.Username = "Welcome " + tb_Username.Text;

                frm_Add_New_Student_Details Obj = new frm_Add_New_Student_Details();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Invalid Username Or Password";
                lbl_Error.ForeColor = Color.Red;
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Password.Enabled = false;
            btn_Submit.Enabled = false;
        }
    }
}
