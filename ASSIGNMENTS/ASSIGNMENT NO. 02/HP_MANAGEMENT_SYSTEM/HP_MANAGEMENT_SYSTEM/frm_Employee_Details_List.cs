using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HP_MANAGEMENT_SYSTEM
{
    public partial class frm_Employee_Details_List : Form
    {
        public frm_Employee_Details_List()
        {
            InitializeComponent();
        }

        private void frm_Employee_Details_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hP_MANAGEMENT_SYSTEM_DBDataSet.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter.Fill(this.hP_MANAGEMENT_SYSTEM_DBDataSet.Employee_Details);

        } 

        private void btn_Search_Emp_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Emp_Details obj = new frm_Search_Emp_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Employee_Details_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee_Details obj = new frm_Add_New_Employee_Details();
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
