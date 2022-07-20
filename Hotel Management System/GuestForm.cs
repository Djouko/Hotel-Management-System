using System;
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
    public partial class GuestForm : Form
    {
        GuestClass guest = new GuestClass();
        public GuestForm()
        {
            InitializeComponent();
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_fName.Clear();
            textBox_lName.Clear();
            textBox_phone.Clear();
            textBox_city.Clear();
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_fName.Text == "" || textBox_phone.Text == "")
            {
                MessageBox.Show("Required Field - Id no, first name and phone no:", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_id.Text;
                    string fname = textBox_fName.Text;
                    string lname = textBox_lName.Text;
                    string phone = textBox_phone.Text;
                    string city = textBox_city.Text;

                    Boolean insertGuest = guest.insertGuest(id, fname, lname, phone, city);
                    if (insertGuest)
                    {
                        MessageBox.Show("New guest save successfuly", "Guest Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        // you can clear all text after the save action
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest not inserted", "Error Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Required Field - Id no", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_id.Text;
                    Boolean deleteGuest = guest.removeGuest(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("guest data remove successfuly", "Guest Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        // you can clear all text after the delete action
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest not Remove", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            dataGridView_guest.DefaultCellStyle.ForeColor = Color.Black;
            getTable();
        }

        private void getTable()
        {
            dataGridView_guest.DataSource = guest.getGuest();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_fName.Text == "" || textBox_phone.Text == "")
            {
                MessageBox.Show("Required Field - Id no, first name and phone no:", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_id.Text;
                    string fname = textBox_fName.Text;
                    string lname = textBox_lName.Text;
                    string phone = textBox_phone.Text;
                    string city = textBox_city.Text;

                    Boolean editGuest = guest.editGuest(id, fname, lname, phone, city);
                    if (editGuest)
                    {
                        MessageBox.Show("Guest data Update successfuly", "Update Successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - guest data not update", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     
        //Display the selectet cell data from datagridview to textboxes;
        private void dataGridView_guest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_guest.CurrentRow.Cells[0].Value.ToString();
            textBox_fName.Text = dataGridView_guest.CurrentRow.Cells[1].Value.ToString();
            textBox_phone.Text = dataGridView_guest.CurrentRow.Cells[2].Value.ToString();
            textBox_city.Text = dataGridView_guest.CurrentRow.Cells[3].Value.ToString();
            textBox_lName.Text = dataGridView_guest.CurrentRow.Cells[4].Value.ToString();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.White;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
