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
    public partial class frmAddNewWins : Form
    {
        public frmAddNewWins()
        {
            
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcAddNewAchievements.SelectedIndex++;
        }

        private void tbSatisfactionValue_Scroll(object sender, EventArgs e)
        {
            lblSatisfactionValue.Text = tbSatisfactionValue.Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcAddNewAchievements.SelectedIndex--;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Submit The Record?", "Are You sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
            }

        }
    }
}
