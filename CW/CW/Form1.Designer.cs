namespace CW
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.SubjectsTextBox = new System.Windows.Forms.TextBox();
            this.FullTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.WorkingHoursTextBox = new System.Windows.Forms.TextBox();
            this.CurrentSubjectsTextBox = new System.Windows.Forms.TextBox();
            this.PreviousSubjectsTextBox = new System.Windows.Forms.TextBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.ViewByRoleButton = new System.Windows.Forms.Button();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(12, 38);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelephoneTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(12, 64);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextBox.TabIndex = 2;
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "teacher",
            "admin",
            "student"});
            this.RoleComboBox.Location = new System.Drawing.Point(12, 90);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(121, 24);
            this.RoleComboBox.TabIndex = 3;
            this.RoleComboBox.SelectedIndexChanged += new System.EventHandler(this.RoleComboBox_SelectedIndexChanged);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(12, 117);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.SalaryTextBox.TabIndex = 4;
            this.SalaryTextBox.Visible = false;
            // 
            // SubjectsTextBox
            // 
            this.SubjectsTextBox.Location = new System.Drawing.Point(12, 143);
            this.SubjectsTextBox.Name = "SubjectsTextBox";
            this.SubjectsTextBox.Size = new System.Drawing.Size(100, 22);
            this.SubjectsTextBox.TabIndex = 5;
            this.SubjectsTextBox.Visible = false;
            // 
            // FullTimeCheckBox
            // 
            this.FullTimeCheckBox.AutoSize = true;
            this.FullTimeCheckBox.Location = new System.Drawing.Point(12, 169);
            this.FullTimeCheckBox.Name = "FullTimeCheckBox";
            this.FullTimeCheckBox.Size = new System.Drawing.Size(84, 20);
            this.FullTimeCheckBox.TabIndex = 6;
            this.FullTimeCheckBox.Text = "Full Time";
            this.FullTimeCheckBox.UseVisualStyleBackColor = true;
            this.FullTimeCheckBox.Visible = false;
            this.FullTimeCheckBox.CheckedChanged += new System.EventHandler(this.FullTimeCheckBox_CheckedChanged);
            // 
            // WorkingHoursTextBox
            // 
            this.WorkingHoursTextBox.Location = new System.Drawing.Point(12, 192);
            this.WorkingHoursTextBox.Name = "WorkingHoursTextBox";
            this.WorkingHoursTextBox.Size = new System.Drawing.Size(100, 22);
            this.WorkingHoursTextBox.TabIndex = 7;
            this.WorkingHoursTextBox.Visible = false;
            // 
            // CurrentSubjectsTextBox
            // 
            this.CurrentSubjectsTextBox.Location = new System.Drawing.Point(12, 218);
            this.CurrentSubjectsTextBox.Name = "CurrentSubjectsTextBox";
            this.CurrentSubjectsTextBox.Size = new System.Drawing.Size(100, 22);
            this.CurrentSubjectsTextBox.TabIndex = 8;
            this.CurrentSubjectsTextBox.Visible = false;
            // 
            // PreviousSubjectsTextBox
            // 
            this.PreviousSubjectsTextBox.Location = new System.Drawing.Point(12, 244);
            this.PreviousSubjectsTextBox.Name = "PreviousSubjectsTextBox";
            this.PreviousSubjectsTextBox.Size = new System.Drawing.Size(100, 22);
            this.PreviousSubjectsTextBox.TabIndex = 9;
            this.PreviousSubjectsTextBox.Visible = false;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(417, 415);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(75, 23);
            this.AddUserButton.TabIndex = 10;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(521, 415);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(75, 23);
            this.EditUserButton.TabIndex = 11;
            this.EditUserButton.Text = "Edit User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Location = new System.Drawing.Point(622, 415);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteUserButton.TabIndex = 12;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // ViewByRoleButton
            // 
            this.ViewByRoleButton.Location = new System.Drawing.Point(713, 415);
            this.ViewByRoleButton.Name = "ViewByRoleButton";
            this.ViewByRoleButton.Size = new System.Drawing.Size(75, 23);
            this.ViewByRoleButton.TabIndex = 13;
            this.ViewByRoleButton.Text = "View by Role";
            this.ViewByRoleButton.UseVisualStyleBackColor = true;
            this.ViewByRoleButton.Click += new System.EventHandler(this.ViewByRoleButton_Click);
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(139, 12);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowHeadersWidth = 51;
            this.UsersDataGridView.Size = new System.Drawing.Size(649, 368);
            this.UsersDataGridView.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsersDataGridView);
            this.Controls.Add(this.ViewByRoleButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.PreviousSubjectsTextBox);
            this.Controls.Add(this.CurrentSubjectsTextBox);
            this.Controls.Add(this.WorkingHoursTextBox);
            this.Controls.Add(this.FullTimeCheckBox);
            this.Controls.Add(this.SubjectsTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "Form1";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox SubjectsTextBox;
        private System.Windows.Forms.CheckBox FullTimeCheckBox;
        private System.Windows.Forms.TextBox WorkingHoursTextBox;
        private System.Windows.Forms.TextBox CurrentSubjectsTextBox;
        private System.Windows.Forms.TextBox PreviousSubjectsTextBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button ViewByRoleButton;
        private System.Windows.Forms.DataGridView UsersDataGridView;
    }
}
