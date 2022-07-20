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
    public partial class RoomForm : Form
    {
        RoomClass room = new RoomClass();
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //To Show a room type in combobox
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "Label";
            comboBox_roomType.ValueMember = "category_id";

            //To show  a room list in Datagridview 
            getRoomList();

            dataGridView_room.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string no = textBox_id.Text;
            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            string ph = textBox_phone.Text;
            string status = radioButton_free.Checked ? "Free" : "Busy";

            try
            {
                if (room.addRoom(no, type, ph, status))
                {
                    MessageBox.Show("Room Added Successfuly", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            comboBox_roomType.SelectedIndex = 0;
            textBox_phone.Clear();
        }

        private void getRoomList()
        {
            dataGridView_room.DataSource = room.getRoomList();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string no = textBox_id.Text;
            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            string ph = textBox_phone.Text;
            string status = radioButton_free.Checked ? "Free" : "Busy";

            try
            {
                if (room.editRoom(no, type, ph, status))
                {
                    MessageBox.Show("Room Update Successfuly", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Update", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_room.CurrentRow.Cells[0].Value.ToString();
            comboBox_roomType.SelectedValue = dataGridView_room.CurrentRow.Cells[1].Value.ToString();
            textBox_phone.Text = dataGridView_room.CurrentRow.Cells[2].Value.ToString();
            //for radio button
            string rButton = dataGridView_room.CurrentRow.Cells[3].Value.ToString();
            if (rButton.Equals("Free"))
            {
                radioButton_free.Checked = true;
            }
            else
            {
                radioButton_busy.Checked = true;
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("Required Field - Room No", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_id.Text;
                    Boolean deleteGuest = room.removeRoom(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("Room remove successfuly", "Room Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                        // you can clear all text after the delete action
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("ERROR - room not Remove", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
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
