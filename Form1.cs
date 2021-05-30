using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        // Fields
        int age;

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
        }

        // Methods
        // Input checker
        private void checkName() { }
        private void checkAge() { }
        private void checkSex() { }
        private void checkEmail() { }
        private void checkContactNumber() { }
        private void checkAddress() { }
        private void checkTemperature() { }
    }
}
