namespace Petrol_station
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.petrolComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sum: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Petrol:";
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(69, 15);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(136, 20);
            this.sumTextBox.TabIndex = 2;
            // 
            // petrolComboBox
            // 
            this.petrolComboBox.FormattingEnabled = true;
            this.petrolComboBox.Location = new System.Drawing.Point(69, 50);
            this.petrolComboBox.Name = "petrolComboBox";
            this.petrolComboBox.Size = new System.Drawing.Size(136, 21);
            this.petrolComboBox.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(20, 87);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(84, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.Location = new System.Drawing.Point(17, 128);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(188, 46);
            this.resultLabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 188);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.petrolComboBox);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Petrol station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.ComboBox petrolComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

