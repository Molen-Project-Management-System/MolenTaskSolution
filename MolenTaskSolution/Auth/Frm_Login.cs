using Microsoft.Data.SqlClient;
using MolenTaskSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MolenTaskSolution.Auth
{
    
    public partial class Frm_Login : Form
    {
        molendbContext userdb = new molendbContext();
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            IEnumerable<String> emails = from p in userdb.Users
            select p.Email;


            IEnumerable<String> passwords = from p in userdb.Users
                                            select p.Password;


            Boolean isEmail = false;
            foreach (String email in emails)
            {
                if (email == textBoxEmail.Text)

                    isEmail = true;




            }

            Boolean isPassword = false;
            foreach (String password in passwords)
            {
                if (password == textBoxPassword.Text)
                    isPassword = true;

            }

            if (isEmail == true && isPassword == true)
            {
                new Frm_Main().Show();
                this.Hide();
            }
            else MessageBox.Show("Please enter valid email and password");

          
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
