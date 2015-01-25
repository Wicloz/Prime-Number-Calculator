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
using System.IO;

namespace Prime_Number_Calculator
{
    public partial class Form1 : Form
    {
        public bool running = false;
        Thread searchP;
        int number = 0;
        int mNumber = 0;
        string foundNumbers = "";

        public Form1()
        {
            InitializeComponent();
            numberIn.Text = "1";
            mNumberIn.Text = "0";
            stop.Enabled = false;
            saveFile.Enabled = false;
            searchP = new Thread(pCalculator);
        }

        private void start_Click(object sender, EventArgs e)
        {
            foundNumbers = "";
            start.Enabled = false;
            numberIn.Enabled = false;
            mNumberIn.Enabled = false;
            saveFile.Enabled = false;
            addText.Enabled = false;
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
                startFail();
            }

            try
            {
                mNumber = Convert.ToInt32(mNumberIn.Text);
            }
            catch
            {
                MessageBox.Show("Enter a number!", "Error");
                failConvert = true;
                startFail();
            }

            if (number > 0)
            {
                running = true;
                searchP = new Thread(pCalculator);
                stop.Enabled = true;
                pNumberOut.Text = "Current Number: " + number.ToString();
                if (mNumber == 0)
                {
                    searchP.Start(number);
                }
                else
                {
                    pCalculator(number);
                    stopSearch();
                }
            }
            else if (failConvert != true)
            {
                MessageBox.Show("Invalid number!", "Error");
                startFail();
            }
        }

        public void pCalculator(object sNumber)
        {
            number = Convert.ToInt32(sNumber);

            while (running == true && (number < mNumber || mNumber == 0))
            {
                if (isPrime(number))
                {
                    foundNumbers += number.ToString();
                    if (addText.Checked)
                    {
                        foundNumbers += " is a prime number.";
                    }
                    foundNumbers += "\r\n";
                }

                number++;
            }
            searchP.Abort();
        }

        public bool isPrime(int n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private void addText_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {
            stopSearch();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save List of Prime Numbers";
            sfd.Filter = "Text File|*.txt|All Files|*.*";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                BinaryWriter pw = new BinaryWriter(File.Create(path));
                pw.Write(foundNumbers);
                pw.Dispose();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            pNumberOut.Text = "Current Number: " + number.ToString();
            if (number == mNumber)
            {
                stopSearch();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            searchP.Abort();
        }

        public void stopSearch()
        {
            running = false;
            stop.Enabled = false;
            start.Enabled = true;
            numberIn.Enabled = true;
            mNumberIn.Enabled = true;
            saveFile.Enabled = true;
            addText.Enabled = true;
            searchP.Abort();
            pNumberOut.Text = foundNumbers;
            if (autoSave.Checked)
            {
                BinaryWriter pw = new BinaryWriter(File.Create("Prime Numbers.txt"));
                pw.Write(foundNumbers);
                pw.Dispose();
            }
        }

        public void startFail()
        {
            start.Enabled = true;
            numberIn.Enabled = true;
            mNumberIn.Enabled = true;
            addText.Enabled = true;
            if (foundNumbers != "")
            {
                saveFile.Enabled = true;
            }
        }
    }
}
