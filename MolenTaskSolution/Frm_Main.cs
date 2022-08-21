
using System;
using MolenTaskSolution.Auth;
namespace MolenTaskSolution
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void lbUserRole_Click(object sender, EventArgs e)
        {

        }

        
        private void btnMainLogin_Click(object sender, EventArgs e)
        {

            new Login().Show();
        }
    }
}