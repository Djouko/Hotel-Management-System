﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
        int startPoint = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            myprogressBar.Value = startPoint;
            if (myprogressBar.Value == 100)
            {
                timer.Stop();
                myprogressBar.Value = 0;
                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();
            }
        }
    }
}
