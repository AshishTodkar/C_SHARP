using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HP_MANAGEMENT_SYSTEM
{
    public partial class frm_Search_Emp_Details : Form
    {
        public frm_Search_Emp_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\Sqlexpress;Initial Catalog=HP_MANAGEMENT_SYSTEM_DB;Integrated Security=True");

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

        private void Only_Numric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        void Clear_Controls()
        {
            tb_Emp_ID.Clear();
            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_No.Clear();
            tb_Adhar_No.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From Employee_Details where Emp_ID = @Emp_ID", Con);

            Cmd.Parameters.Add("Emp_ID", SqlDbType.Int).Value = tb_Emp_ID.Text;

            SqlDataReader DR = Cmd.ExecuteReader();

            if (DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                tb_Address.Text = DR.GetString(DR.GetOrdinal("Address"));
                tb_Mobile_No.Text = (DR["Mobile_No"].ToString());
                tb_Adhar_No.Text = (DR["Adhar_No"].ToString());
            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Emp ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Emp_ID.Clear();
            }

            Con_Close();

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_Emp_Details_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee_Details obj = new frm_Add_New_Employee_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_View_Emp_Details_Click(object sender, EventArgs e)
        {
            frm_Employee_Details_List obj = new frm_Employee_Details_List();
            obj.Show();
            this.Hide();
        }
       
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure.... You Want To Logout ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login_Page obj = new frm_Login_Page();
                obj.Show();
                this.Hide();
            }
        }
    }
}
