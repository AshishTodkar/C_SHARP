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
    public partial class frm_Add_New_Employee_Details : Form
    {
        public frm_Add_New_Employee_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\Sqlexpress;Initial Catalog=HP_MANAGEMENT_SYSTEM_DB;Integrated Security=True");

        void Con_Open()
        {
            if ( Con.State != ConnectionState.Open)
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

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand Cmd = new SqlCommand("Select Count(*) From Employee_Details",Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Emp_ID) From Employee_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1001;
            }

            Con_Close();

            return Cnt;
        }

        void Clear_Controls()
        {
            tb_Emp_ID.Text = Convert.ToString(Auto_Incr());

            tb_Name.Clear();
            tb_Address.Clear();
            tb_Mobile_No.Clear();
            tb_Adhar_No.Clear();
        }

        private void frm_Add_New_Employee_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Emp_ID.Text != "" && tb_Name.Text != "" && tb_Address.Text != "" && tb_Mobile_No.Text != "" && tb_Mobile_No.TextLength == 10 && tb_Adhar_No.Text != "" && tb_Adhar_No.TextLength == 12)
            {
                SqlCommand Cmd = new SqlCommand("Insert into Employee_Details values(@Emp_ID,@Nm,@Add,@MNo,@ANo)", Con);

                Cmd.Parameters.Add("Emp_ID",SqlDbType.Int).Value = tb_Emp_ID.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Add", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("ANo", SqlDbType.Decimal).Value = tb_Adhar_No.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }

            else
            {
                MessageBox.Show("First Fill All Compulsary Fields","Failed",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            Con_Close();
        }

        private void btn_Search_Emp_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Emp_Details obj = new frm_Search_Emp_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_View_All_Employee_Details_Click(object sender, EventArgs e)
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
