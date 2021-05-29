
namespace Contact_Tracing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.dateAndTime = new System.Windows.Forms.DateTimePicker();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Tracing";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(35, 78);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 31);
            this.lastNameTextBox.TabIndex = 1;
            this.lastNameTextBox.Text = "Last Name";
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Location = new System.Drawing.Point(191, 78);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(150, 31);
            this.firstNameTextbox.TabIndex = 2;
            this.firstNameTextbox.Text = "First Name";
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(35, 152);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(150, 31);
            this.eMailTextBox.TabIndex = 5;
            this.eMailTextBox.Text = "Email";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(191, 152);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(150, 31);
            this.phoneNumberTextBox.TabIndex = 6;
            this.phoneNumberTextBox.Text = "Contact Number";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(35, 189);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(306, 31);
            this.addressTextBox.TabIndex = 7;
            this.addressTextBox.Text = "Address";
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.Location = new System.Drawing.Point(35, 226);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(150, 31);
            this.temperatureTextBox.TabIndex = 8;
            this.temperatureTextBox.Text = "Temperature";
            // 
            // dateAndTime
            // 
            this.dateAndTime.Location = new System.Drawing.Point(35, 263);
            this.dateAndTime.Name = "dateAndTime";
            this.dateAndTime.Size = new System.Drawing.Size(325, 31);
            this.dateAndTime.TabIndex = 9;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(35, 115);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(150, 31);
            this.ageTextBox.TabIndex = 3;
            this.ageTextBox.Text = "Age";
            // 
            // sexTextBox
            // 
            this.sexTextBox.Location = new System.Drawing.Point(191, 115);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(150, 31);
            this.sexTextBox.TabIndex = 4;
            this.sexTextBox.Text = "Sex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sexTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.dateAndTime);
            this.Controls.Add(this.temperatureTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.DateTimePicker dateAndTime;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
    }
}

