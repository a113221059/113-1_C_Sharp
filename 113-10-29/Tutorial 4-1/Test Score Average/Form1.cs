using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        private double average;

        public Form1()
        {
            InitializeComponent();
        }

        public double HIGH_SCORE { get; private set; }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;
            const double HIGHSCORE = 95.0;
           
            try
            {
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

               average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("nl");

                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("恭喜!幹的好");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and the averageLabel control.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // Reset the focus to test1.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
