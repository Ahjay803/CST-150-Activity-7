
namespace Approximate_PI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.termsLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsLabel.Location = new System.Drawing.Point(150, 109);
            this.termsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(169, 24);
            this.termsLabel.TabIndex = 0;
            this.termsLabel.Text = "Enter # of terms: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(563, 101);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 29);
            this.textBox1.TabIndex = 1;
            // 
            // calButton
            // 
            this.calButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.calButton.Location = new System.Drawing.Point(153, 218);
            this.calButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(138, 57);
            this.calButton.TabIndex = 2;
            this.calButton.Text = "CALCULATE ";
            this.calButton.UseVisualStyleBackColor = false;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(149, 356);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(0, 24);
            this.inputLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 534);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.termsLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Approximate PI ";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label inputLabel;
    }
}

