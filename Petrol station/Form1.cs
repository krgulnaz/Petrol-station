using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_station
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            petrolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            petrolComboBox.Items.Add("92");
            petrolComboBox.Items.Add("95");
            petrolComboBox.Items.Add("98");
            okButton.Enabled = false;
        }

        private void sumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!((e.KeyChar.ToString() == ",") && (sumTextBox.Text.IndexOf(",") == -1)))
                    e.Handled = true;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            double priceOfThePetrol = 1.6;
            int countOfLiter;
            double cash;
            double change;
            switch (petrolComboBox.SelectedIndex)
            {
                case 0: priceOfThePetrol = 1.6;
                    break;
                case 1: priceOfThePetrol = 2;
                    break;
                case 2: priceOfThePetrol = 2.4;
                    break;
            }
            cash = Convert.ToDouble(this.sumTextBox.Text);
            countOfLiter = (int)(cash / priceOfThePetrol);
            change = cash - countOfLiter * priceOfThePetrol;

            this.resultLabel.Text = "Litres: " + countOfLiter.ToString() +
                "\nTotal sum: " + cash.ToString("C") +
                "\nChange: " + change.ToString("C") +
                "\nThe price of the a liter: " + priceOfThePetrol.ToString("C");
        }

        private void sumTextBox_TextChanged(object sender, EventArgs e)
        {
            if(this.sumTextBox.Text!="," || this.sumTextBox.Text.Length > 0 || this.petrolComboBox.SelectedIndex != -1)
            {
                this.okButton.Enabled = true;
            }
            else
            {
                this.okButton.Enabled = false;
            }
        }

        private void petrolComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.sumTextBox.Text != "," || this.sumTextBox.TextLength > 0)
            {
                this.okButton.Enabled = true;
            }
            else
            {
                this.okButton.Enabled = false;
            }
        }
    }
}
