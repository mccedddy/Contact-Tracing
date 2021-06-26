
namespace Contact_Tracing
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textContactTracing = new System.Windows.Forms.Label();
            this.textCovid19 = new System.Windows.Forms.Label();
            this.textFillUpForm = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.displayList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textContactTracing
            // 
            this.textContactTracing.AutoSize = true;
            this.textContactTracing.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textContactTracing.Location = new System.Drawing.Point(292, 65);
            this.textContactTracing.Name = "textContactTracing";
            this.textContactTracing.Size = new System.Drawing.Size(269, 47);
            this.textContactTracing.TabIndex = 12;
            this.textContactTracing.Text = "Contact Tracing";
            this.textContactTracing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textCovid19
            // 
            this.textCovid19.AutoSize = true;
            this.textCovid19.Font = new System.Drawing.Font("Tw Cen MT", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textCovid19.Location = new System.Drawing.Point(292, 9);
            this.textCovid19.Name = "textCovid19";
            this.textCovid19.Size = new System.Drawing.Size(284, 69);
            this.textCovid19.TabIndex = 11;
            this.textCovid19.Text = "COVID-19";
            this.textCovid19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textFillUpForm
            // 
            this.textFillUpForm.AutoSize = true;
            this.textFillUpForm.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textFillUpForm.Location = new System.Drawing.Point(367, 112);
            this.textFillUpForm.Name = "textFillUpForm";
            this.textFillUpForm.Size = new System.Drawing.Size(113, 33);
            this.textFillUpForm.TabIndex = 13;
            this.textFillUpForm.Text = "View List";
            this.textFillUpForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(755, 628);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(112, 34);
            this.btn_Back.TabIndex = 26;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // displayList
            // 
            this.displayList.FormattingEnabled = true;
            this.displayList.ItemHeight = 25;
            this.displayList.Location = new System.Drawing.Point(12, 164);
            this.displayList.Name = "displayList";
            this.displayList.Size = new System.Drawing.Size(855, 454);
            this.displayList.TabIndex = 27;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 674);
            this.Controls.Add(this.displayList);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.textFillUpForm);
            this.Controls.Add(this.textContactTracing);
            this.Controls.Add(this.textCovid19);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textContactTracing;
        private System.Windows.Forms.Label textCovid19;
        private System.Windows.Forms.Label textFillUpForm;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ListBox displayList;
    }
}