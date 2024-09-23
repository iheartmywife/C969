namespace Chermak_PA_C969
{
    partial class Mainscreen
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
            this.AppointmentsDGV = new System.Windows.Forms.DataGridView();
            this.CustomersDGV = new System.Windows.Forms.DataGridView();
            this.AppointmentsLabel = new System.Windows.Forms.Label();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersAddButton = new System.Windows.Forms.Button();
            this.CustomersUpdateButton = new System.Windows.Forms.Button();
            this.CustomersDeleteButton = new System.Windows.Forms.Button();
            this.AppointmentsDeleteButton = new System.Windows.Forms.Button();
            this.AppointmentsUpdateButton = new System.Windows.Forms.Button();
            this.AppointmentsAddButton = new System.Windows.Forms.Button();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsDGV
            // 
            this.AppointmentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsDGV.Location = new System.Drawing.Point(50, 55);
            this.AppointmentsDGV.MultiSelect = false;
            this.AppointmentsDGV.Name = "AppointmentsDGV";
            this.AppointmentsDGV.ReadOnly = true;
            this.AppointmentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsDGV.Size = new System.Drawing.Size(652, 247);
            this.AppointmentsDGV.TabIndex = 0;
            this.AppointmentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentsDGV_CellContentClick);
            // 
            // CustomersDGV
            // 
            this.CustomersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDGV.Location = new System.Drawing.Point(50, 382);
            this.CustomersDGV.MultiSelect = false;
            this.CustomersDGV.Name = "CustomersDGV";
            this.CustomersDGV.ReadOnly = true;
            this.CustomersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersDGV.Size = new System.Drawing.Size(652, 247);
            this.CustomersDGV.TabIndex = 1;
            this.CustomersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersDGV_CellContentClick);
            // 
            // AppointmentsLabel
            // 
            this.AppointmentsLabel.AutoSize = true;
            this.AppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsLabel.Location = new System.Drawing.Point(44, 21);
            this.AppointmentsLabel.Name = "AppointmentsLabel";
            this.AppointmentsLabel.Size = new System.Drawing.Size(192, 31);
            this.AppointmentsLabel.TabIndex = 2;
            this.AppointmentsLabel.Text = "Appointments";
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersLabel.Location = new System.Drawing.Point(44, 348);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(155, 31);
            this.CustomersLabel.TabIndex = 3;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersAddButton
            // 
            this.CustomersAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersAddButton.Location = new System.Drawing.Point(50, 635);
            this.CustomersAddButton.Name = "CustomersAddButton";
            this.CustomersAddButton.Size = new System.Drawing.Size(90, 32);
            this.CustomersAddButton.TabIndex = 7;
            this.CustomersAddButton.Text = "Add";
            this.CustomersAddButton.UseVisualStyleBackColor = true;
            this.CustomersAddButton.Click += new System.EventHandler(this.CustomersAddButton_Click);
            // 
            // CustomersUpdateButton
            // 
            this.CustomersUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersUpdateButton.Location = new System.Drawing.Point(146, 635);
            this.CustomersUpdateButton.Name = "CustomersUpdateButton";
            this.CustomersUpdateButton.Size = new System.Drawing.Size(90, 32);
            this.CustomersUpdateButton.TabIndex = 8;
            this.CustomersUpdateButton.Text = "Update";
            this.CustomersUpdateButton.UseVisualStyleBackColor = true;
            this.CustomersUpdateButton.Click += new System.EventHandler(this.CustomersUpdateButton_Click);
            // 
            // CustomersDeleteButton
            // 
            this.CustomersDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersDeleteButton.Location = new System.Drawing.Point(242, 635);
            this.CustomersDeleteButton.Name = "CustomersDeleteButton";
            this.CustomersDeleteButton.Size = new System.Drawing.Size(90, 32);
            this.CustomersDeleteButton.TabIndex = 9;
            this.CustomersDeleteButton.Text = "Delete";
            this.CustomersDeleteButton.UseVisualStyleBackColor = true;
            this.CustomersDeleteButton.Click += new System.EventHandler(this.CustomersDeleteButton_Click);
            // 
            // AppointmentsDeleteButton
            // 
            this.AppointmentsDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsDeleteButton.Location = new System.Drawing.Point(242, 306);
            this.AppointmentsDeleteButton.Name = "AppointmentsDeleteButton";
            this.AppointmentsDeleteButton.Size = new System.Drawing.Size(90, 32);
            this.AppointmentsDeleteButton.TabIndex = 10;
            this.AppointmentsDeleteButton.Text = "Delete";
            this.AppointmentsDeleteButton.UseVisualStyleBackColor = true;
            this.AppointmentsDeleteButton.Click += new System.EventHandler(this.AppointmentsDeleteButton_Click);
            // 
            // AppointmentsUpdateButton
            // 
            this.AppointmentsUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsUpdateButton.Location = new System.Drawing.Point(146, 306);
            this.AppointmentsUpdateButton.Name = "AppointmentsUpdateButton";
            this.AppointmentsUpdateButton.Size = new System.Drawing.Size(90, 32);
            this.AppointmentsUpdateButton.TabIndex = 11;
            this.AppointmentsUpdateButton.Text = "Update";
            this.AppointmentsUpdateButton.UseVisualStyleBackColor = true;
            this.AppointmentsUpdateButton.Click += new System.EventHandler(this.AppointmentsUpdateButton_Click);
            // 
            // AppointmentsAddButton
            // 
            this.AppointmentsAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsAddButton.Location = new System.Drawing.Point(50, 306);
            this.AppointmentsAddButton.Name = "AppointmentsAddButton";
            this.AppointmentsAddButton.Size = new System.Drawing.Size(90, 32);
            this.AppointmentsAddButton.TabIndex = 12;
            this.AppointmentsAddButton.Text = "Add";
            this.AppointmentsAddButton.UseVisualStyleBackColor = true;
            this.AppointmentsAddButton.Click += new System.EventHandler(this.AppointmentsAddButton_Click);
            // 
            // ReportsButton
            // 
            this.ReportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsButton.Location = new System.Drawing.Point(790, 382);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(151, 44);
            this.ReportsButton.TabIndex = 13;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(790, 585);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(151, 44);
            this.LogoutButton.TabIndex = 14;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(714, 55);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(714, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(201, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Filter Appointments for Selected Date";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(239, 363);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.ErrorLabel.TabIndex = 18;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(714, 243);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(208, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Filter Appointments for Selected Month";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 680);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.AppointmentsAddButton);
            this.Controls.Add(this.AppointmentsUpdateButton);
            this.Controls.Add(this.AppointmentsDeleteButton);
            this.Controls.Add(this.CustomersDeleteButton);
            this.Controls.Add(this.CustomersUpdateButton);
            this.Controls.Add(this.CustomersAddButton);
            this.Controls.Add(this.CustomersLabel);
            this.Controls.Add(this.AppointmentsLabel);
            this.Controls.Add(this.CustomersDGV);
            this.Controls.Add(this.AppointmentsDGV);
            this.Name = "Mainscreen";
            this.Text = "Mainscreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainscreen_FormClosed);
            this.Load += new System.EventHandler(this.Mainscreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentsDGV;
        private System.Windows.Forms.DataGridView CustomersDGV;
        private System.Windows.Forms.Label AppointmentsLabel;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Button CustomersAddButton;
        private System.Windows.Forms.Button CustomersUpdateButton;
        private System.Windows.Forms.Button CustomersDeleteButton;
        private System.Windows.Forms.Button AppointmentsDeleteButton;
        private System.Windows.Forms.Button AppointmentsUpdateButton;
        private System.Windows.Forms.Button AppointmentsAddButton;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}