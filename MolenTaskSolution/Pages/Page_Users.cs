﻿using MolenTaskSolution.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MolenTaskSolution.Pages
{
    
    public partial class Page_Users : UserControl
    {
        public Page_Users()
        {
            InitializeComponent();
        }

        private void Page_Users_Load(object sender, EventArgs e)
        {
            molendbContext userdb = new molendbContext();

        }
    }
}