
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
            this.SuspendLayout();
            // 
            // textContactTracing
            // 
            this.textContactTracing.AutoSize = true;
            this.textContactTracing.Font = new System.Drawing.Font("Tw Cen MT", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textContactTracing.Location = new System.Drawing.Point(108, 65);
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
            this.textCovid19.Location = new System.Drawing.Point(108, 9);
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
            this.textFillUpForm.Location = new System.Drawing.Point(183, 112);
            this.textFillUpForm.Name = "textFillUpForm";
            this.textFillUpForm.Size = new System.Drawing.Size(113, 33);
            this.textFillUpForm.TabIndex = 13;
            this.textFillUpForm.Text = "View List";
            this.textFillUpForm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 674);
            this.Controls.Add(this.textFillUpForm);
            this.Controls.Add(this.textContactTracing);
            this.Controls.Add(this.textCovid19);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textContactTracing;
        private System.Windows.Forms.Label textCovid19;
        private System.Windows.Forms.Label textFillUpForm;
    }
}