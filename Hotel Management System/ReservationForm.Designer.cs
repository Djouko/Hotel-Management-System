
namespace Hotel_Management_System
{
    partial class ReservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView_reserv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_exit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_guestId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_reservId = new System.Windows.Forms.TextBox();
            this.panel_button = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.comboBox_roomNo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dateIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateOut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.SuspendLayout();
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
            this.button_save.Text = "Add";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dataGridView_reserv
            // 
            this.dataGridView_reserv.AllowUserToAddRows = false;
            this.dataGridView_reserv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_reserv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_reserv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_reserv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_reserv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_reserv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reserv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_reserv.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_reserv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_reserv.EnableHeadersVisualStyles = false;
            this.dataGridView_reserv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_reserv.Name = "dataGridView_reserv";
            this.dataGridView_reserv.ReadOnly = true;
            this.dataGridView_reserv.RowHeadersVisible = false;
            this.dataGridView_reserv.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView_reserv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_reserv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_reserv.Size = new System.Drawing.Size(916, 301);
            this.dataGridView_reserv.TabIndex = 0;
            this.dataGridView_reserv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView_reserv.ThemeStyle.ReadOnly = true;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_reserv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_reserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_reserv_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_reserv);
            this.panel2.Location = new System.Drawing.Point(12, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 301);
            this.panel2.TabIndex = 25;
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
            this.label6.Location = new System.Drawing.Point(376, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Manage Reservation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_exit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 74);
            this.panel1.TabIndex = 24;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date In:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Room Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Guest Id:";
            // 
            // textBox_guestId
            // 
            this.textBox_guestId.Location = new System.Drawing.Point(247, 439);
            this.textBox_guestId.Name = "textBox_guestId";
            this.textBox_guestId.Size = new System.Drawing.Size(141, 27);
            this.textBox_guestId.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Reserv Id:";
            // 
            // textBox_reservId
            // 
            this.textBox_reservId.Location = new System.Drawing.Point(247, 395);
            this.textBox_reservId.Name = "textBox_reservId";
            this.textBox_reservId.Size = new System.Drawing.Size(141, 27);
            this.textBox_reservId.TabIndex = 14;
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
            this.panel_button.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Room No:";
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(247, 485);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(141, 29);
            this.comboBox_roomType.TabIndex = 26;
            this.comboBox_roomType.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomType_SelectedIndexChanged);
            // 
            // comboBox_roomNo
            // 
            this.comboBox_roomNo.FormattingEnabled = true;
            this.comboBox_roomNo.Location = new System.Drawing.Point(247, 527);
            this.comboBox_roomNo.Name = "comboBox_roomNo";
            this.comboBox_roomNo.Size = new System.Drawing.Size(141, 29);
            this.comboBox_roomNo.TabIndex = 26;
            // 
            // dateTimePicker_dateIn
            // 
            this.dateTimePicker_dateIn.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker_dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateIn.Location = new System.Drawing.Point(636, 395);
            this.dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            this.dateTimePicker_dateIn.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_dateIn.TabIndex = 27;
            // 
            // dateTimePicker_dateOut
            // 
            this.dateTimePicker_dateOut.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker_dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateOut.Location = new System.Drawing.Point(636, 439);
            this.dateTimePicker_dateOut.Name = "dateTimePicker_dateOut";
            this.dateTimePicker_dateOut.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_dateOut.TabIndex = 27;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(940, 700);
            this.Controls.Add(this.dateTimePicker_dateOut);
            this.Controls.Add(this.dateTimePicker_dateIn);
            this.Controls.Add(this.comboBox_roomNo);
            this.Controls.Add(this.comboBox_roomType);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_guestId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_reservId);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_reserv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_guestId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_reservId;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.ComboBox comboBox_roomNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateIn;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOut;
    }
}