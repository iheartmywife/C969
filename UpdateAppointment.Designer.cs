namespace Chermak_PA_C969
{
    partial class UpdateAppointment
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
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.apptDayLabel = new System.Windows.Forms.Label();
            this.AppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveAppointmentButton = new System.Windows.Forms.Button();
            this.EndLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.ErrorTextLabel = new System.Windows.Forms.Label();
            this.SelectCustomerLabel = new System.Windows.Forms.Label();
            this.AppointmentTypeLabel = new System.Windows.Forms.Label();
            this.AppointmentTypeTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CustomerListDGV = new System.Windows.Forms.DataGridView();
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentlyEditingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndESTLabel = new System.Windows.Forms.Label();
            this.StartESTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimePicker.Location = new System.Drawing.Point(207, 250);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(275, 20);
            this.EndTimePicker.TabIndex = 41;
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.EndTimePicker_ValueChanged);
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimePicker.Location = new System.Drawing.Point(207, 224);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.ShowUpDown = true;
            this.StartTimePicker.Size = new System.Drawing.Size(275, 20);
            this.StartTimePicker.TabIndex = 40;
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Selected Customer Address ID";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.IndianRed;
            this.textBox5.Location = new System.Drawing.Point(207, 303);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(275, 20);
            this.textBox5.TabIndex = 38;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(50, 333);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(96, 13);
            this.SelectedCustomerLabel.TabIndex = 37;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.IndianRed;
            this.textBox4.Location = new System.Drawing.Point(207, 333);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(275, 20);
            this.textBox4.TabIndex = 36;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // apptDayLabel
            // 
            this.apptDayLabel.AutoSize = true;
            this.apptDayLabel.Location = new System.Drawing.Point(49, 282);
            this.apptDayLabel.Name = "apptDayLabel";
            this.apptDayLabel.Size = new System.Drawing.Size(88, 13);
            this.apptDayLabel.TabIndex = 35;
            this.apptDayLabel.Text = "Appointment Day";
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.Location = new System.Drawing.Point(207, 275);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(275, 20);
            this.AppointmentDate.TabIndex = 34;
            this.AppointmentDate.ValueChanged += new System.EventHandler(this.AppointmentDate_ValueChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(173, 482);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(119, 22);
            this.CancelButton.TabIndex = 31;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveAppointmentButton
            // 
            this.SaveAppointmentButton.Location = new System.Drawing.Point(48, 482);
            this.SaveAppointmentButton.Name = "SaveAppointmentButton";
            this.SaveAppointmentButton.Size = new System.Drawing.Size(119, 22);
            this.SaveAppointmentButton.TabIndex = 30;
            this.SaveAppointmentButton.Text = "Save Appointment";
            this.SaveAppointmentButton.UseVisualStyleBackColor = true;
            this.SaveAppointmentButton.Click += new System.EventHandler(this.SaveAppointmentButton_Click);
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(52, 256);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(137, 13);
            this.EndLabel.TabIndex = 29;
            this.EndLabel.Text = "End Time in Your Timezone";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(52, 230);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(136, 13);
            this.StartLabel.TabIndex = 28;
            this.StartLabel.Text = "Start Time in Your timezone";
            // 
            // ErrorTextLabel
            // 
            this.ErrorTextLabel.AutoSize = true;
            this.ErrorTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTextLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorTextLabel.Location = new System.Drawing.Point(298, 484);
            this.ErrorTextLabel.Name = "ErrorTextLabel";
            this.ErrorTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ErrorTextLabel.Size = new System.Drawing.Size(0, 20);
            this.ErrorTextLabel.TabIndex = 27;
            // 
            // SelectCustomerLabel
            // 
            this.SelectCustomerLabel.AutoSize = true;
            this.SelectCustomerLabel.Location = new System.Drawing.Point(530, 33);
            this.SelectCustomerLabel.Name = "SelectCustomerLabel";
            this.SelectCustomerLabel.Size = new System.Drawing.Size(142, 13);
            this.SelectCustomerLabel.TabIndex = 26;
            this.SelectCustomerLabel.Text = "Select Customer From Below";
            // 
            // AppointmentTypeLabel
            // 
            this.AppointmentTypeLabel.AutoSize = true;
            this.AppointmentTypeLabel.Location = new System.Drawing.Point(49, 200);
            this.AppointmentTypeLabel.Name = "AppointmentTypeLabel";
            this.AppointmentTypeLabel.Size = new System.Drawing.Size(93, 13);
            this.AppointmentTypeLabel.TabIndex = 25;
            this.AppointmentTypeLabel.Text = "Appointment Type";
            // 
            // AppointmentTypeTextBox
            // 
            this.AppointmentTypeTextBox.BackColor = System.Drawing.Color.IndianRed;
            this.AppointmentTypeTextBox.Location = new System.Drawing.Point(207, 197);
            this.AppointmentTypeTextBox.Name = "AppointmentTypeTextBox";
            this.AppointmentTypeTextBox.Size = new System.Drawing.Size(275, 20);
            this.AppointmentTypeTextBox.TabIndex = 24;
            this.AppointmentTypeTextBox.TextChanged += new System.EventHandler(this.AppointmentTypeTextBox_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(43, 34);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(207, 25);
            this.TitleLabel.TabIndex = 23;
            this.TitleLabel.Text = "Update Appointment";
            // 
            // CustomerListDGV
            // 
            this.CustomerListDGV.AllowUserToAddRows = false;
            this.CustomerListDGV.AllowUserToDeleteRows = false;
            this.CustomerListDGV.AllowUserToResizeColumns = false;
            this.CustomerListDGV.AllowUserToResizeRows = false;
            this.CustomerListDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerListDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerListDGV.Location = new System.Drawing.Point(533, 49);
            this.CustomerListDGV.MultiSelect = false;
            this.CustomerListDGV.Name = "CustomerListDGV";
            this.CustomerListDGV.ReadOnly = true;
            this.CustomerListDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerListDGV.ShowRowErrors = false;
            this.CustomerListDGV.Size = new System.Drawing.Size(408, 218);
            this.CustomerListDGV.TabIndex = 22;
            this.CustomerListDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerListDGV_CellContentClick);
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.Location = new System.Drawing.Point(533, 286);
            this.AppointmentsDGV.MultiSelect = false;
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDGV.Size = new System.Drawing.Size(408, 155);
            this.AppointmentsDGV.TabIndex = 32;
            this.AppointmentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Current Appointments";
            // 
            // CurrentlyEditingLabel
            // 
            this.CurrentlyEditingLabel.AutoSize = true;
            this.CurrentlyEditingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentlyEditingLabel.Location = new System.Drawing.Point(52, 463);
            this.CurrentlyEditingLabel.Name = "CurrentlyEditingLabel";
            this.CurrentlyEditingLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CurrentlyEditingLabel.Size = new System.Drawing.Size(0, 16);
            this.CurrentlyEditingLabel.TabIndex = 42;
            this.CurrentlyEditingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "End Time in EST";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Start Time in EST";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EndESTLabel
            // 
            this.EndESTLabel.AutoSize = true;
            this.EndESTLabel.Location = new System.Drawing.Point(204, 162);
            this.EndESTLabel.Name = "EndESTLabel";
            this.EndESTLabel.Size = new System.Drawing.Size(0, 13);
            this.EndESTLabel.TabIndex = 46;
            this.EndESTLabel.Click += new System.EventHandler(this.EndESTLabel_Click);
            // 
            // StartESTLabel
            // 
            this.StartESTLabel.AutoSize = true;
            this.StartESTLabel.Location = new System.Drawing.Point(204, 136);
            this.StartESTLabel.Name = "StartESTLabel";
            this.StartESTLabel.Size = new System.Drawing.Size(0, 13);
            this.StartESTLabel.TabIndex = 45;
            this.StartESTLabel.Click += new System.EventHandler(this.StartESTLabel_Click);
            // 
            // UpdateAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 536);
            this.Controls.Add(this.EndESTLabel);
            this.Controls.Add(this.StartESTLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrentlyEditingLabel);
            this.Controls.Add(this.EndTimePicker);
            this.Controls.Add(this.StartTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.SelectedCustomerLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.apptDayLabel);
            this.Controls.Add(this.AppointmentDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AppointmentsDGV);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveAppointmentButton);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.ErrorTextLabel);
            this.Controls.Add(this.SelectCustomerLabel);
            this.Controls.Add(this.AppointmentTypeLabel);
            this.Controls.Add(this.AppointmentTypeTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CustomerListDGV);
            this.Name = "UpdateAppointment";
            this.Text = "UpdateAppointment";
            this.Load += new System.EventHandler(this.UpdateAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label apptDayLabel;
        private System.Windows.Forms.DateTimePicker AppointmentDate;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveAppointmentButton;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Label ErrorTextLabel;
        private System.Windows.Forms.Label SelectCustomerLabel;
        private System.Windows.Forms.Label AppointmentTypeLabel;
        private System.Windows.Forms.TextBox AppointmentTypeTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.DataGridView CustomerListDGV;
        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentlyEditingLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label EndESTLabel;
        private System.Windows.Forms.Label StartESTLabel;
    }
}