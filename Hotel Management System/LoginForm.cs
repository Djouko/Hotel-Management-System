using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    public partial class LoginForm : Form
    {
        DBConnect connect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Orange;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Button_login_Click(object sender, EventArgs e)
        {

            if (TextBox_username.Text.Trim().Equals("") || TextBox_password.Text == "")
            {
                MessageBox.Show("Enter your username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectquery = "SELECT * FROM `users` WHERE `username` = @usn AND `password`=@pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBox_password.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);


                //if the user name and the password exists
                if (table.Rows.Count > 0)
                {
                    // Show the main form
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("your username and Password doen's exists", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }

        }
    }
}
