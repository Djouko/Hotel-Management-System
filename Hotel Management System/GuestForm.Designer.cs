
namespace Hotel_Management_System
{
    partial class GuestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_guest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_button.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 592);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(940, 108);
            this.panel_button.TabIndex = 0;
            // 
            // button_clean
            // 
            this.button_clean.FlatAppearance.BorderSize = 0;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.ForeColor = System.Drawing.Color.White;
            this.button_clean.Image = global::Hotel_Management_System.Properties.Resources.clear_formatting_40px;
            this.button_clean.Location = new System.Drawing.Point(615, 3);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(105, 78);
            this.button_clean.TabIndex = 5;
            this.button_clean.Text = "Clean";
            this.button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatAppearance.BorderSize = 0;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Image = global::Hotel_Management_System.Properties.Resources.delete_document_40px;
            this.button_delete.Location = new System.Drawing.Point(504, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(105, 78);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_update.FlatAppearance.BorderSize = 0;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Image = global::Hotel_Management_System.Properties.Resources.available_updates_40px;
            this.button_update.Location = new System.Drawing.Point(393, 3);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(105, 78);
            this.button_update.TabIndex = 3;
            this.button_update.Text = "Update";
            this.button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Black;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.ForeColor = System.Drawing.Color.White;
            this.button_save.Image = global::Hotel_Management_System.Properties.Resources.save_40px;
            this.button_save.Location = new System.Drawing.Point(283, 3);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(105, 78);
            this.button_save.TabIndex = 2;
            this.button_save.Text = "Save";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(247, 395);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(141, 27);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name :";
            // 
            // textBox_fName
            // 
            this.textBox_fName.Location = new System.Drawing.Point(247, 442);
            this.textBox_fName.Name = "textBox_fName";
            this.textBox_fName.Size = new System.Drawing.Size(141, 27);
            this.textBox_fName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name :";
            // 
            // textBox_lName
            // 
            this.textBox_lName.Location = new System.Drawing.Point(247, 489);
            this.textBox_lName.Name = "textBox_lName";
            this.textBox_lName.Size = new System.Drawing.Size(141, 27);
            this.textBox_lName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(615, 395);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(139, 27);
            this.textBox_phone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "City :";
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(615, 442);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(139, 27);
            this.textBox_city.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 74);
            this.panel1.TabIndex = 11;
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_exit.ForeColor = System.Drawing.Color.White;
            this.label_exit.Location = new System.Drawing.Point(911, 1);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(33, 31);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            this.label_exit.MouseEnter += new System.EventHandler(this.label_exit_MouseEnter);
            this.label_exit.MouseLeave += new System.EventHandler(this.label_exit_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(401, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Guest";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_guest);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 301);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView_guest
            // 
            this.dataGridView_guest.AllowUserToAddRows = false;
            this.dataGridView_guest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_guest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_guest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_guest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_guest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_guest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_guest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_guest.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_guest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_guest.EnableHeadersVisualStyles = false;
            this.dataGridView_guest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_guest.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_guest.Name = "dataGridView_guest";
            this.dataGridView_guest.ReadOnly = true;
            this.dataGridView_guest.RowHeadersVisible = false;
            this.dataGridView_guest.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView_guest.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_guest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_guest.Size = new System.Drawing.Size(916, 301);
            this.dataGridView_guest.TabIndex = 0;
            this.dataGridView_guest.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_guest.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_guest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_guest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_guest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_guest.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView_guest.ThemeStyle.ReadOnly = true;
            this.dataGridView_guest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_guest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_guest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_guest.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_guest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_guest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_guest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_guest_CellClick);
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(940, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_lName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_fName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GuestForm";
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panel_button.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_guest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_exit;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_guest;
    }
}