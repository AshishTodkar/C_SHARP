using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SGM_MANAGEMENT_SYSTEM
{
    public partial class frm_Student_Details_List : Form
    {
        public frm_Student_Details_List()
        {
            InitializeComponent();
        }

        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sGM_MANAGEMENT_SYSTEM_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.sGM_MANAGEMENT_SYSTEM_DBDataSet.Student_Details);

        }

        private void btn_Add_New_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student_Details obj = new frm_Add_New_Student_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure.... You Want To Logout ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}
