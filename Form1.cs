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
        //
        //              frmWelcome work...
        //
        private Form frmWelcome = new frmWelcome();

        private void frmWelcome_Show()
        {
            frmWelcome.MdiParent = this;
            frmWelcome.Show();
        }

        public MDI_Form()
        {
            InitializeComponent();

            frmWelcome_Show();
        }

        private void mdiChangeBackGround()
        {

        }

        private void MdiForm_Shown(object sender, EventArgs e)
        {

        }
    }
}
