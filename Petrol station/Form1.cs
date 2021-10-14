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
    }
}
