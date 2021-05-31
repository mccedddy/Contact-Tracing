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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // WHen form2 opens, open Contact Tracing List text file
            StreamReader inputFile;
            inputFile = File.OpenText("Contact Tracing List.txt");

            // While stream is not at the end
            while (inputFile.EndOfStream == false)
            {
                // Add lines from inputFile to displayList
                displayList.Items.Add(inputFile.ReadLine());
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Hide this form and open Form1
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
