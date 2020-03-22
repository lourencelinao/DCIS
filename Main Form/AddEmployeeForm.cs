using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class AddEmployeeForm : Form
    {
        List<string> position_list;
        public AddEmployeeForm()
        {
            InitializeComponent();
            this.Text = "Add Employee";
        }

        public void setPositionComboBox(List<string> items)
        {
            foreach(var item in items)
            {
                employeePositionComboBox.Items.Add(item);
            }
        }

        private void cancelAddEmployeeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void addEmployeeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int employee_id = int.Parse(employeeIDTextBox.Text);
                int position_id = employeePositionComboBox.SelectedIndex + 1;
                string firstname = firstNameTextBox.Text;
                char mi = char.Parse(miTextBox.Text);
                string lastname = lastNameTextBox.Text;
                string sex = sexComboBox.SelectedItem.ToString();
                string birthday = birthdateDateTimePicker.Text;
                string email = emailTextBox.Text;
                long contact = long.Parse(contactTextBox.Text);
                long emergency_contact = long.Parse(emergencyTextBox.Text);
                string religion = religionTextBox.Text;
                string civil_status = civilStatusComboBox.SelectedItem.ToString();
                string nationality = nationalityTextBox.Text;
                string current_address = currentAddressTextBox.Text;
                string permanent_address = permanentAddressTextBox.Text;
                string position_startDate = positionStartDateDateTimePicker.Text;
                decimal position_incentives = decimal.Parse(incentivesTextBox.Text);
                string salary_payment = paymentComboBox.SelectedItem.ToString();
                string date_of_employment = dateOfEmploymentDateTimePicker.Text;

                //capitalize words
                firstname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(firstname.ToLower());
                mi = char.ToUpper(mi);
                lastname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lastname.ToLower());
                religion = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(religion.ToLower());
                nationality = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(nationality.ToLower());
                current_address = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(current_address.ToLower());
                permanent_address = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(permanent_address.ToLower());

                //Database queries
                string query = "INSERT INTO employee(employee_id, position_id, fname, mi," +
                    "lname, sex, birthdate, email, contact, emergency_contact, religion, civil_status," +
                    "nationality, current_address, permanent_address, date_of_employment, position_startDate, position_incentives, salary_payment) " +
                    "VALUES('" + employee_id + "', '" + position_id + "', '" + firstname + "', '" + mi + "', '" + lastname + "', '" + sex + "'," +
                    "'" + birthday + "', '" + email + "', '" + contact + "', '" + emergency_contact + "', '" + religion + "', '" + civil_status + "'," +
                    "'" + nationality + "', '" + current_address + "', '" + permanent_address + "', '" + date_of_employment + "', '" + position_startDate + "'," +
                    "'" + position_incentives + "', '" + salary_payment + "') ";
                DBConnect dbc = new DBConnect();
                dbc.query(query);
                query = "INSERT INTO users(username, email, status) VALUES('" + employee_id + "', '" + email + "', 'Active')";
                dbc.query(query);
                MessageBox.Show("Employee added!");


                //clear inputs
                employeeIDTextBox.Clear();
                firstNameTextBox.Clear();
                miTextBox.Clear();
                lastNameTextBox.Clear();
                employeePositionComboBox.Items.Clear();
                employeePositionComboBox.ResetText();
                sexComboBox.Items.Clear();
                sexComboBox.ResetText();
                emailTextBox.Clear();
                contactTextBox.Clear();
                emergencyTextBox.Clear();
                religionTextBox.Clear();
                civilStatusComboBox.Items.Clear();
                civilStatusComboBox.ResetText();
                nationalityTextBox.Clear();
                currentAddressTextBox.Clear();
                permanentAddressTextBox.Clear();
                incentivesTextBox.Clear();
                positionStartDateDateTimePicker.Value = DateTime.Now;
                birthdateDateTimePicker.Value = DateTime.Now;
                dateOfEmploymentDateTimePicker.Value = DateTime.Now;
                paymentComboBox.Items.Clear();
                paymentComboBox.ResetText();

                //update listview
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
