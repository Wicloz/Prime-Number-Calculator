using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Number_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool running;

        private void start_Click(object sender, EventArgs e)
        {
            numberIn.Enabled = false;
            int number = 0;
            bool failConvert = false;
            pNumberOut.Text = "";

            try
            {
                number = Convert.ToInt32(numberIn.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                failConvert = true;
            }

            if (number > 0)
            {
                running = true;
                pCalculator(number);
            }
            else if (failConvert != true)
            {
                MessageBox.Show("Invalid number.", "Error");
            }

            numberIn.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            running = false;
            numberIn.Enabled = true;
        }

        void pCalculator(int number)
        {
            while (number < 1000 && running == true)
            {
                int maxn = (number / 2);
                bool prime = true;

                for (int dnumber = 2; dnumber <= maxn; dnumber++)
                {
                    int rest = number % dnumber;
                    if (rest == 0)
                    {
                        prime = false;
                        break;
                    }
                }

                if (prime == true)
                {
                    pNumberOut.Text += number.ToString();
                    if (addText.Checked)
                    {
                        pNumberOut.Text += "  is a prime number.";
                    }
                    pNumberOut.Text += "    ";
                }

            number++;
            }

        }
    }
}
