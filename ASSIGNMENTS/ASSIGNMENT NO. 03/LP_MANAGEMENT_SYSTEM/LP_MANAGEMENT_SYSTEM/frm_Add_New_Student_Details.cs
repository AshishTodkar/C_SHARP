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
    public partial class frm_Add_New_Student_Details : Form
    {
        public frm_Add_New_Student_Details()
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

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) From LP_Student_Details", Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No) From LP_Student_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());

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

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void frm_Add_New_Student_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            lbl_User_Login.Text = Shared_Class.Username;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into LP_Student_Details ( Roll_No , Name ,DOB , Mobile_No , Course ) values (@RNo , @Nm , @DOB , @MNo , @Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show(" Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Compulsary Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();
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
