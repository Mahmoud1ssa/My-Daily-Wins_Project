using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Daily_Wins_Project.Properties;

namespace My_Daily_Wins_Project
{
    public partial class MDI_Form : Form
    {
        public MDI_Form()
        {
            InitializeComponent();

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr AddNewAchievementsForm = new fr();
            AddNewAchievementsForm.MdiParent = this;
            AddNewAchievementsForm.Show();
        }
    }
}
