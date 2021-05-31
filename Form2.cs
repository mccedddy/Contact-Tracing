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
            inputFile = File.OpenText("Contact Tracing List.txt");
            while (inputFile.EndOfStream == false)
            {
                displayList.Items.Add(inputFile.ReadLine());
            }
        }

        // Fields
        StreamReader inputFile;
        
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
