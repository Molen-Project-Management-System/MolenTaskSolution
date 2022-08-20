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
    public partial class Login : Form
    {

        molendbContext userdb = new molendbContext();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {


            IEnumerable<String> emails = from p in userdb.ProjectUsers
                                                 select p.Email;


            IEnumerable<String> passwords = from p in userdb.ProjectUsers
                                         select p.Password;


            Boolean isEmail=false;
            foreach (String email in emails)
            {
                if (email == textBoxemail.Text)
                   
                     isEmail = true;

                
                

            }

            Boolean isPassword=false;
            foreach(String password in passwords)
            {
                if (password == textBoxpassword.Text)
                    isPassword = true;
               
            }

            if (isEmail == true&&isPassword==true)
            {
                new Frm_Main().Show();
                this.Close();
            }
            else MessageBox.Show("Please enter valid email and password");




            //List<ProjectUser>? projectUsers = userdb.ProjectUsers.ToList();

            /*foreach (ProjectUser user in projectUsers)
            {
                if (textBoxemail.Text == user.Email && textBoxpassword.Text == user.Password)
                {
                    new Frm_Main().Show();
                    this.Close();

                }
                else MessageBox.Show("Please enter valid email and password");

            }*/




        }
    }
}
