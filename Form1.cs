using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Notes
        // Read Form

        // Fields
        int age;
        long contactNumber;
        double temperature;
        bool invalidInput = false;
        StreamWriter outputFile;

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //Check all inputs
            checkName();
            checkAge();
            checkSex();
            checkEmail();
            checkContactNumber();
            checkAddress();
            checkTemperature();

            // If invalidInput is true, show invalid input
            if (invalidInput == true)
            {
                MessageBox.Show("Invalid input!");
                invalidInput = false;
            }
            else
            {
                // Write on file
                outputFile = File.AppendText("Contact Tracing List.txt");
                outputFile.WriteLine("Name: " + lastNameTextBox.Text + ", " + firstNameTextbox.Text);
                outputFile.WriteLine("Age: " + ageTextBox.Text);
                outputFile.WriteLine("Sex: " + sexComboBox.Text);
                outputFile.WriteLine("Email: " + eMailTextBox.Text);
                outputFile.WriteLine("Contact Number: " + contactNumberTextBox.Text);
                outputFile.WriteLine("Address: " + addressTextBox.Text);
                outputFile.WriteLine("Temperature: " + temperatureTextBox.Text + " °C");
                outputFile.WriteLine("Date: " + dateAndTime.Text);
                outputFile.WriteLine("==================================================================================");
                outputFile.Close();

                // Show message
                MessageBox.Show("Input submitted!");

                // Clear textboxes
                lastNameTextBox.Text = "";
                firstNameTextbox.Text = "";
                ageTextBox.Text = "";
                sexComboBox.Text = "";
                eMailTextBox.Text = "";
                contactNumberTextBox.Text = "";
                addressTextBox.Text = "";
                temperatureTextBox.Text = "";
            }
        }
        private void btn_ViewList_Click(object sender, EventArgs e)
        {
            // Hide this form and open Form2
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        // Methods
        // Input checker
        private void checkName() 
        {
            // If textbox is not empty, input error is true and change label color to red
            if (lastNameTextBox.Text != "") 
            { 
                labelLastName.ForeColor = Color.Black;
            }

            // If textbox is empty
            else 
            {
                inputError();
                labelLastName.ForeColor = Color.Red;
            }

            // If textbox is not empty, input error is true and change label color to red
            if (firstNameTextbox.Text != "")
            {
                labelFirstName.ForeColor = Color.Black;
            }

            // If textbox is empty
            else
            {
                inputError();
                labelFirstName.ForeColor = Color.Red;
            }
        }
        private void checkAge() 
        {
            // If age is int
            try
            { 
                age = int.Parse(ageTextBox.Text); 

                // If age is less than 150
                if (age < 150) 
                {
                    labelAge.ForeColor = Color.Black;
                }

                // If age is more than 150, input error is true and change label color to red
                else
                {
                    inputError();
                    labelAge.ForeColor = Color.Red;
                }
            }
            // if age is not an int, input error is true and change label color to red
            catch
            {
                inputError();
                labelAge.ForeColor = Color.Red;
            }
        }
        private void checkSex()
        { 
            // If sex is male
            if (sexComboBox.Text == "Male") 
            {
                labelSex.ForeColor = Color.Black;
            }

            // If sex is female
            else if (sexComboBox.Text == "Female")
            {
                labelSex.ForeColor = Color.Black;
            }

            // If sex is neither male nor female, input error is true and change label color to red
            else
            { 
                inputError();
                labelSex.ForeColor = Color.Red;
            }
        }
        private void checkEmail() 
        { 
            // If Email contains @ and .
            if (eMailTextBox.Text.Contains("@") && eMailTextBox.Text.Contains("."))
            {
                labelEmail.ForeColor = Color.Black;
            }

            // If Email does not contain @ and ., input error is true and change label color to red
            else
            { 
                inputError();
                labelEmail.ForeColor = Color.Red;
            }
        }
        private void checkContactNumber() 
        {
            // If contact number is long
            try
            {
                contactNumber = long.Parse(contactNumberTextBox.Text);
                labelContactNumber.ForeColor = Color.Black;
            }

            // If contact number is not long, input error is true and change label color to red
            catch
            {
                inputError();
                labelContactNumber.ForeColor = Color.Red;
            }
        }
        private void checkAddress() 
        { 
            // If address is not empty
            if (addressTextBox.Text != "")
            {
                labelAddress.ForeColor = Color.Black;
            }

            // If address is empty, input error is true and change label color to red
            else
            {
                inputError();
                labelAddress.ForeColor = Color.Red;
            }
        }
        private void checkTemperature() 
        {
            // If temperature is double
            try
            {
                temperature = double.Parse(temperatureTextBox.Text);
                // If temperature is less than 50 and greater than 10
                if (temperature < 50 && temperature > 10)
                {
                    labelTemperature.ForeColor = Color.Black;
                }

                // If temperature is more than 50 or less than 10
                else
                {
                    inputError();
                    labelTemperature.ForeColor = Color.Red;
                }
            }

            // If temperature is not double, input error is true and change label color to red
            catch
            {
                inputError();
                labelTemperature.ForeColor = Color.Red;
            }
        }

        // Error
        private void inputError()
        {
            // If invalidInput is false, change to true
            if (invalidInput == false)
            { 
                invalidInput = true; 
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When form is closed, exit application
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}
