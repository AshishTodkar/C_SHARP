using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LP_MANAGEMENT_SYSTEM
{
    public partial class frm_Student_Details_List : Form
    {
        public frm_Student_Details_List()
        {
            InitializeComponent();
        }

        private void frm_Student_Details_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lP_MANAGEMENT_SYSTEM_DBDataSet.LP_Student_Details' table. You can move, or remove it, as needed.
            this.lP_Student_DetailsTableAdapter.Fill(this.lP_MANAGEMENT_SYSTEM_DBDataSet.LP_Student_Details);

            lbl_User_Login.Text = Shared_Class.Username;
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Details Obj = new frm_Search_Student_Details();
            Obj.Show();
            this.Hide();
        }

        private void btn_Add_New_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details Obj = new frm_Add_New_Student_Details();
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
