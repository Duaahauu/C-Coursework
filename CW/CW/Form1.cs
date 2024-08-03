using System;
using System.Windows.Forms;

namespace CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            UsersDataGridView.Columns.Add("Name", "Name");
            UsersDataGridView.Columns.Add("Telephone", "Telephone");
            UsersDataGridView.Columns.Add("Email", "Email");
            UsersDataGridView.Columns.Add("Role", "Role");
            UsersDataGridView.Columns.Add("Salary", "Salary");
            UsersDataGridView.Columns.Add("SubjectsOrWorkingHours", "Subjects/Working Hours");
            UsersDataGridView.Columns.Add("FullTime", "Full Time");
            UsersDataGridView.Columns.Add("CurrentSubjects", "Current Subjects");
            UsersDataGridView.Columns.Add("PreviousSubjects", "Previous Subjects");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RoleComboBox.SelectedIndex = 0;  // Default to first item
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string role = RoleComboBox.SelectedItem.ToString();
            string name = NameTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string email = EmailTextBox.Text;
            string salary = SalaryTextBox.Text;
            string subjectsOrWorkingHours = "";
            string fullTime = FullTimeCheckBox.Checked ? "Yes" : "No";
            string currentSubjects = CurrentSubjectsTextBox.Text;
            string previousSubjects = PreviousSubjectsTextBox.Text;

            if (role == "teacher")
            {
                subjectsOrWorkingHours = SubjectsTextBox.Text;
            }
            else if (role == "admin")
            {
                subjectsOrWorkingHours = WorkingHoursTextBox.Text;
            }

            UsersDataGridView.Rows.Add(name, telephone, email, role, salary, subjectsOrWorkingHours, fullTime, currentSubjects, previousSubjects);
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (UsersDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = UsersDataGridView.SelectedRows[0];
                selectedRow.Cells["Name"].Value = NameTextBox.Text;
                selectedRow.Cells["Telephone"].Value = TelephoneTextBox.Text;
                selectedRow.Cells["Email"].Value = EmailTextBox.Text;
                selectedRow.Cells["Role"].Value = RoleComboBox.SelectedItem.ToString();
                selectedRow.Cells["Salary"].Value = SalaryTextBox.Text;

                if (RoleComboBox.SelectedItem.ToString() == "teacher")
                {
                    selectedRow.Cells["SubjectsOrWorkingHours"].Value = SubjectsTextBox.Text;
                }
                else if (RoleComboBox.SelectedItem.ToString() == "admin")
                {
                    selectedRow.Cells["SubjectsOrWorkingHours"].Value = WorkingHoursTextBox.Text;
                }

                selectedRow.Cells["FullTime"].Value = FullTimeCheckBox.Checked ? "Yes" : "No";
                selectedRow.Cells["CurrentSubjects"].Value = CurrentSubjectsTextBox.Text;
                selectedRow.Cells["PreviousSubjects"].Value = PreviousSubjectsTextBox.Text;
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in UsersDataGridView.SelectedRows)
            {
                UsersDataGridView.Rows.Remove(row);
            }
        }

        private void ViewByRoleButton_Click(object sender, EventArgs e)
        {
            string role = RoleComboBox.SelectedItem.ToString();
            foreach (DataGridViewRow row in UsersDataGridView.Rows)
            {
                if (row.Cells["Role"].Value != null && row.Cells["Role"].Value.ToString() == role)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hide all extra fields initially
            SalaryTextBox.Visible = false;
            SubjectsTextBox.Visible = false;
            FullTimeCheckBox.Visible = false;
            WorkingHoursTextBox.Visible = false;
            CurrentSubjectsTextBox.Visible = false;
            PreviousSubjectsTextBox.Visible = false;

            string selectedRole = RoleComboBox.SelectedItem.ToString();
            if (selectedRole == "teacher")
            {
                SalaryTextBox.Visible = true;
                SubjectsTextBox.Visible = true;
            }
            else if (selectedRole == "admin")
            {
                SalaryTextBox.Visible = true;
                FullTimeCheckBox.Visible = true;
                WorkingHoursTextBox.Visible = true;
            }
            else if (selectedRole == "student")
            {
                CurrentSubjectsTextBox.Visible = true;
                PreviousSubjectsTextBox.Visible = true;
            }
        }

        private void FullTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
