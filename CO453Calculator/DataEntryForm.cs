using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CO453Forms
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void QuitApplication(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "Hi " + firstNameTextBox.Text + " " + 
                surnameTextBox.Text + " \nHappy Programming!!!";
        }

        private void ClearMessage(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messageLabel.Text = messageLabel.Text.ToLower();
        }

        private void messageLabel_Click(object sender, EventArgs e)
        {
            messageLabel.BackColor = Color.Red;
            firstNameTextBox.BackColor = Color.RoyalBlue;
            surnameLabel.BackColor = Color.RoyalBlue;
            messageLabel.Text += " Get on with it " + firstNameTextBox.Text;
        }
    }
}