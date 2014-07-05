using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Prime_Number_Calculator
{
    public partial class Form1 : Form
    {
        public bool running = false;
        Thread searchP;
        string foundNumbers = "";

        public Form1()
        {
            InitializeComponent();
            numberIn.Text = "1";

        }

        private void start_Click(object sender, EventArgs e)
        {
            searchP = new Thread(pCalculator);
            numberIn.Enabled = false;
            int number = 0;
            bool failConvert = false;
            pNumberOut.Text = "";

            try
            {
                number = Convert.ToInt32(numberIn.Text);
            }
            catch
            {
                MessageBox.Show("Enter a number!", "Error");
                failConvert = true;
            }

            if (number > 0)
            {
                running = true;
                searchP.Start(number);
            }
            else if (failConvert != true)
            {
                MessageBox.Show("Invalid number!", "Error");
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            running = false;
            numberIn.Enabled = true;
            pNumberOut.Text = foundNumbers;
        }

        void pCalculator(object sNumber)
        {
            int number = Convert.ToInt32(sNumber);
            while (running == true)
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
                    foundNumbers += number.ToString();
                    if (addText.Checked)
                    {
                        foundNumbers += "  is a prime number.";
                    }
                    foundNumbers += "\r\n";
                }

            number++;
            }

        }

        private void saveFile_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchP.Abort();
        }

        private void update_Click(object sender, EventArgs e)
        {
            pNumberOut.Text = foundNumbers;
        }
    }
}
