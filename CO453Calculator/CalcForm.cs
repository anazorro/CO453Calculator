using System;
using System.Windows.Forms;

namespace CO453Forms
{
    public partial class CalcForm : Form
    {
        private double number1;
        private double number2;
        private double result;

        public CalcForm()
        {
            InitializeComponent();
        }

        private void AddNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            result = number1 + number2;
            ShowResult();
        }

        private void GetNumbers()
        {
            number1 = Convert.ToDouble(firstNumberTextBox.Text);
            number2 = Convert.ToDouble(secondNumberTextBox.Text);
        }

        private void QuitForm(object sender, EventArgs e)
        {
            //Close();
            QuitForm quit = new QuitForm();
            quit.Show();
        }

        private void SubtractNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            result = number1 - number2;
            ShowResult();
        }

        private void ShowResult()
        {
            resultTextBox.Text = result.ToString("0.##");
        }

        private void MultiplyNumbers(object sender, EventArgs e)
        {
            GetNumbers();

            result = number1 * number2;
            ShowResult();
        }

        private void DivisionNumbers(object sender, EventArgs e)
        {
            GetNumbers();
            if(number2 == 0)
            {
                messageLabel.Text = "You can't devide by zero.";
            }
            else
            {
                result = number1 / number2;
                messageLabel.Text = "";
                ShowResult();
            }
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            SplashForm splash = new SplashForm();
            splash.ShowDialog();
            //System.Threading.Thread.Sleep(2000);
            //splash.Close();
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            GetNumbers();

            result = Math.Pow(number1, number2);
            resultTextBox.Text = result.ToString();
        }
    }
}