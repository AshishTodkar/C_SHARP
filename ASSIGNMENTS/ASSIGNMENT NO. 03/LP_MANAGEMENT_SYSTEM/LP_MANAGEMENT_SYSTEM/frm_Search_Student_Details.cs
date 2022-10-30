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
    public partial class frm_Search_Student_Details : Form
    {
        public frm_Search_Student_Details()
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

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            dtp_DOB.Text = "31/12/2007";
            cmb_Course.SelectedIndex = -1;
        }

        private void Only_Numric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void frm_Search_Student_Details_Load(object sender, EventArgs e)
        {
            lbl_User_Login.Text = Shared_Class.Username;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select * From LP_Student_Details where Roll_No = @RNo", Con);

            Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader DR = Cmd.ExecuteReader();

            if (DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                dtp_DOB.Text = (DR["DOB"].ToString());
                tb_Mobile_No.Text = (DR["Mobile_No"].ToString());
                cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));  
            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Roll No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Roll_No.Clear();
            }

            Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Add_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details Obj = new frm_Add_New_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_View_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Student_Details_List Obj = new frm_Student_Details_List();
            Obj.Show();
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