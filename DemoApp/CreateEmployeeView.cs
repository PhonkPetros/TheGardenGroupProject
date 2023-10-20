using Logic;
using Model;
using Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public class CreateEmployeeView
    {
        EmployeeController employeeController = new EmployeeController();
        TextBox firstNameTextBox;
        Employee employee;
        TextBox lastNameTextBox;
        ComboBox typeOfUserComboBox;
        TextBox emailAddressTextBox;
        TextBox phoneNumberTextBox;
        TextBox locationTextBox;
        TextBox passwordTextBox;

        public CreateEmployeeView(TextBox FirstName, TextBox LastName, ComboBox TypeOfUser, TextBox EmailAddress, TextBox PhoneNumber, TextBox Location, TextBox Password, Employee employee)
        {
            this.firstNameTextBox = FirstName;
            this.lastNameTextBox = LastName;
            this.typeOfUserComboBox = TypeOfUser;
            this.emailAddressTextBox = EmailAddress;
            this.phoneNumberTextBox = PhoneNumber;
            this.locationTextBox = Location;
            this.passwordTextBox = Password;
            this.employee = employee;
        }

        public void PopulateComboBoxes()
        {
            typeOfUserComboBox.DataSource = Enum.GetValues(typeof(UserType));
        }

        public void ReadInput()
        {
            employee.FirstName = firstNameTextBox.Text;
            employee.LastName = lastNameTextBox.Text;
            employee.UserType = ((UserType)typeOfUserComboBox.SelectedValue);
            employee.Email = emailAddressTextBox.Text;
            employee.Phone = phoneNumberTextBox.Text;
            employee.Branch = locationTextBox.Text;
            employee.Password = passwordTextBox.Text;
        }

        public void addEmployeeToDatabase()
        {
            ReadInput();
            if ((!string.IsNullOrEmpty(employee.FirstName) && !string.IsNullOrEmpty(employee.LastName) && !string.IsNullOrEmpty(employee.Email) && !string.IsNullOrEmpty(employee.Phone) && !string.IsNullOrEmpty(employee.Branch) && !string.IsNullOrEmpty(employee.Password)))
            {
                employeeController.CreateNewEmployee(employee);
                MessageBox.Show("The employee was successfully added.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields of the form to add a user");
            }
        }
    }
}
