using DB;
using Object_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Form
{
    public partial class EmployeesForm : Form
    {
        private List<string> position_list;
        private List<employee> employee_list;
        private string editEmail;
        int i;
        public EmployeesForm()
        {
            InitializeComponent();
            this.Text = "Employees";
            loadItemsToList();
        }

        public void positionList()
        {
            string query = "SELECT distinct position_title from companyposition";
            DBConnect dbc = new DBConnect();
            position_list = dbc.positions(query);
            foreach (var employee in position_list)
            {
                employeePositionComboBox.Items.Add(employee);
            }
        }

        //clear inputs
        public void clearInputs()
        {
            employeeIDTextBox.Clear();
            firstNameTextBox.Clear();
            miTextBox.Clear();
            lastNameTextBox.Clear();    
          
            emailTextBox.Clear();
            contactTextBox.Clear();
            emergencyTextBox.Clear();
            religionTextBox.Clear();
            nationalityTextBox.Clear();
            currentAddressTextBox.Clear();
            permanentAddressTextBox.Clear();
            incentivesTextBox.Clear();
            positionStartDateDateTimePicker.Value = DateTime.Now;
            birthdateDateTimePicker.Value = DateTime.Now;
            dateOfEmploymentDateTimePicker.Value = DateTime.Now;  
            civilStatusComboBox.SelectedIndex = -1;
            employeePositionComboBox.SelectedIndex = -1;
            paymentComboBox.SelectedIndex = -1;
            statusComboBox.SelectedIndex = -1;
            sexComboBox.SelectedIndex = -1;

            updateEmployee.Enabled = false;
            employeeIDTextBox.Enabled = true;
            addEmployee.Enabled = true;
            deleteEmployee.Enabled = false;

        }

        private void addEmployee_MouseClick(object sender, MouseEventArgs e)
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
                string status = statusComboBox.SelectedItem.ToString();

                //check if employee id and email is unique
                bool isUnique = true;
                for (int i = 0; i < listViewEmployees.Items.Count && isUnique != false; i++)
                {
                    if (listViewEmployees.Items[i].SubItems[0].Text == employee_id.ToString())
                    {
                        MessageBox.Show("Employee ID is already taken!");
                        isUnique = false;
                    }
                    else if (listViewEmployees.Items[i].SubItems[5].Text == email)
                    {
                        MessageBox.Show("Email is already taken!");
                        isUnique = false;
                    }
                }

                if (isUnique == true)
                {

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
                        "nationality, current_address, permanent_address, date_of_employment, position_startDate, position_incentives, salary_payment, status) " +
                        "VALUES('" + employee_id + "', '" + position_id + "', '" + firstname + "', '" + mi + "', '" + lastname + "', '" + sex + "'," +
                        "'" + birthday + "', '" + email + "', '" + contact + "', '" + emergency_contact + "', '" + religion + "', '" + civil_status + "'," +
                        "'" + nationality + "', '" + current_address + "', '" + permanent_address + "', '" + date_of_employment + "', '" + position_startDate + "'," +
                        "'" + position_incentives + "', '" + salary_payment + "', '" + status + "') ";
                    DBConnect dbc = new DBConnect();
                    dbc.query(query);
                    query = "INSERT INTO users(username, email, status) VALUES('" + employee_id + "', '" + email + "', 'Active')";
                    dbc.query(query);

                    //update listview
                    listViewEmployees.Items.Add(new ListViewItem(new string[] {employee_id.ToString(),
                    position_list[position_id-1], firstname, mi.ToString(), lastname, email, contact.ToString(), emergency_contact.ToString(),
                    current_address, status}));

                    MessageBox.Show("Employee added!");

                    //clear inputs
                    clearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updateEmployee_MouseClick(object sender, MouseEventArgs e)
        {           
            try
            {
                int x = i + 1;
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
                string status = statusComboBox.SelectedItem.ToString();

                //check if email is unique
                bool isUnique = true;
                for (int i = 0; i < listViewEmployees.Items.Count && isUnique != false; i++)
                {
                    if (listViewEmployees.Items[i].SubItems[5].Text == email && email != editEmail)
                    {
                        MessageBox.Show("Email is already taken!");
                        isUnique = false;
                    }
                }

                if (isUnique == true)
                {
                    //capitalize words
                    firstname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(firstname.ToLower());
                    mi = char.ToUpper(mi);
                    lastname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lastname.ToLower());
                    religion = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(religion.ToLower());
                    nationality = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(nationality.ToLower());
                    current_address = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(current_address.ToLower());
                    permanent_address = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(permanent_address.ToLower());

                    //database queries
                    string query = "UPDATE employee SET position_id = '"+position_id+ "', fname='"+firstname+"'," +
                        "mi='"+mi+"', lname='"+lastname+ "', sex='"+sex+ "', birthdate='"+birthday+"', email='"+email+"'," +
                        "contact='"+contact+"', emergency_contact='"+emergency_contact+"', religion='"+religion+"', civil_status='"+civil_status+"'," +
                        "nationality='"+nationality+"', current_address='"+current_address+"', permanent_address='"+permanent_address+"', date_of_employment='"+date_of_employment+"'," +
                        "position_startDate='"+position_startDate+"', position_incentives='"+position_incentives+"', salary_payment='"+salary_payment+"', status='"+status+"' WHERE employee_id='"+employee_id+"' ";
                    DBConnect dbc = new DBConnect();
                    dbc.query(query);

                    //update listview
                    ListViewItem item = new ListViewItem(new string[] {employee_id.ToString(),
                    lastname, firstname, mi.ToString(), position_list[position_id-1], email, contact.ToString(), emergency_contact.ToString(),
                    current_address, status});
                    listViewEmployees.Items.RemoveAt(x);
                    listViewEmployees.Items.Insert(x, item);
                    MessageBox.Show("Employee Updated!");
                    //clear inputs
                    clearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void loadItemsToList()
        {
            DBConnect dbc = new DBConnect();
            string query = "SELECT * from employee";
            employee_list = dbc.DBToListEmployee(query);
            positionList();
            foreach (var employee in employee_list)
            {
                listViewEmployees.Items.Add(new ListViewItem(new string[] { employee.Employee_ID.ToString(),
                    employee.Lname, employee.Fname, employee.Mi, position_list[employee.Position_ID-1], employee.Email, employee.Contact.ToString(),
                    employee.EmergencyContact.ToString(), employee.Current_Address, employee.Status
                }));
            }
            listViewEmployees.Refresh();
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewEmployees.SelectedItems.Count == 0 || listViewEmployees.SelectedItems.Count > 1)
            {
                updateEmployee.Enabled = false;
                employeeIDTextBox.Enabled = true;
                addEmployee.Enabled = true;
                deleteEmployee.Enabled = true;
                clearInputs();
            }
            else if(listViewEmployees.SelectedItems.Count == 1)
            {
                int checker = 0;
                for(i = listViewEmployees.Items.Count -1; i >= 0 && checker != 1; i--)
                {
                    if(listViewEmployees.Items[i].Selected == true)
                    {           
                        DBConnect dbc = new DBConnect();
                        List<employee> employee = new List<employee>();
                        string query = "SELECT * FROM employee WHERE employee_id='"+ listViewEmployees.Items[i].SubItems[0].Text + "'";
                        employee = dbc.DBToListEmployee(query);

                        employeeIDTextBox.Text = employee[0].Employee_ID.ToString();                        
                        firstNameTextBox.Text = employee[0].Fname;
                        miTextBox.Text = employee[0].Mi;
                        lastNameTextBox.Text = employee[0].Lname;                       
                        birthdateDateTimePicker.Text = employee[0].Birthdate.ToString();
                        emailTextBox.Text = employee[0].Email;
                        contactTextBox.Text = employee[0].Contact.ToString();
                        emergencyTextBox.Text = employee[0].EmergencyContact.ToString();
                        religionTextBox.Text = employee[0].Religion;                       
                        nationalityTextBox.Text = employee[0].Nationality;
                        currentAddressTextBox.Text = employee[0].Current_Address;
                        permanentAddressTextBox.Text = employee[0].Permanent_Address;
                        dateOfEmploymentDateTimePicker.Text = employee[0].DateOfEmployment.ToString();
                        positionStartDateDateTimePicker.Text = employee[0].Position_StartDate.ToString();
                        incentivesTextBox.Text = employee[0].Position_Incetives.ToString();
                        sexComboBox.SelectedIndex = sexComboBox.FindString(employee[0].Sex);
                        civilStatusComboBox.SelectedIndex = civilStatusComboBox.FindString(employee[0].Civil_Status);
                        paymentComboBox.SelectedIndex = paymentComboBox.FindString(employee[0].Salary_Payment);
                        statusComboBox.SelectedIndex = statusComboBox.FindString(employee[0].Status);
                        employeePositionComboBox.SelectedIndex = employeePositionComboBox.FindString(position_list[employee[0].Position_ID - 1]);
                        checker = 1;

                        employeeIDTextBox.Enabled = false;
                        updateEmployee.Enabled = true;
                        addEmployee.Enabled = false;
                        deleteEmployee.Enabled = true;
                        editEmail = employee[0].Email;
                    }
 
                }
            }
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            clearInputs();
            searchEmployeeTextBox.Clear();
        }

        private void searchEmployeeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(searchEmployeeTextBox.Text != "")
            {
                string search = searchEmployeeTextBox.Text;
                foreach(ListViewItem item in listViewEmployees.Items)
                {
                    if(item.SubItems[0].Text == search)
                    {                      
                        //item.BackColor = SystemColors.Highlight;
                        //item.ForeColor = SystemColors.HighlightText;
                        item.Selected = true;
                    }
                    else
                    {                        
                        //item.BackColor = SystemColors.Window;
                        //item.ForeColor = SystemColors.WindowText;
                        item.Selected = false;
                    }
                    
                    //if(listViewEmployees.SelectedItems.Count == 1)
                    //{
                    //    listViewEmployees.Focus();
                    //}
                }
                listViewEmployees.Refresh();
            }
        }

        private void deleteEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (listViewEmployees.SelectedItems.Count == 1)
                {
                    int x = i + 1;
                    DBConnect dbc = new DBConnect();
                    clearInputs();
                    string query = "DELETE FROM users where username ='" + listViewEmployees.Items[x].SubItems[0].Text + "' ";
                    dbc.query(query);
                    query = "DELETE FROM employee WHERE employee_id='" + listViewEmployees.Items[x].SubItems[0].Text + "'";
                    dbc.query(query);
                    listViewEmployees.Items.RemoveAt(x);
                    listViewEmployees.Refresh();
                    deleteEmployee.Enabled = false;
                    MessageBox.Show("Deletion successful!");
                    
                }
                else
                {
                    MessageBox.Show("Please select one employee");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
