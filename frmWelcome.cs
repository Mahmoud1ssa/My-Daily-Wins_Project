using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Daily_Wins_Project
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }


        private void btnSingUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameValue.Text))
                MessageBox.Show("Invalide First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (string.IsNullOrWhiteSpace(txtLastNameValue.Text))
                MessageBox.Show("Invalide Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                if(MessageBox.Show($"Your Fullname Is {txtFirstNameValue.Text} {txtLastNameValue.Text} \nAre You Sure You Want To Continue?" , "Are You sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    MDI_Form MdiForm = new MDI_Form();
                    this.Hide();
                    MdiForm.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
