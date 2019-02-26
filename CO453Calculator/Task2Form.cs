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
    public partial class Task2Form : Form
    {
        public Task2Form()
        {
            InitializeComponent();
        }
        
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            pricesLabel.Text = "Super Dupa Computer\n Selling for £339";
            pricesLabel.BackColor = Color.SeaShell;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pricesLabel.Text = "C# .NET for Dummy's\n A real bargain at £29.99";
            pricesLabel.BackColor = Color.Tan;
        }
    }
}