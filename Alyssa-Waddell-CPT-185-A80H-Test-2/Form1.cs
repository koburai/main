using System;
using System.IO; // had to add this in
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace Alyssa_Waddell_CPT_185_A80H_Test_2
{
    public partial class Form1 : Form
    {
        /* alyssa waddell
         * cpt 185 a80h
         * test 2 
         */
        public Form1()
        {
            InitializeComponent();
        }
        StreamReader inputFile;// put this up here just because. yeah.
        private void Form1_Load(object sender, EventArgs e)
        {
            // i plan on populating the combo box this way as manually typing in every single year between 1900 and 2024 is yike
            for (int i = 1900; i <= 2024; i++)
            {
                cboxYear.Items.Add(i);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblAvg.Text = string.Empty;
            lblBonusAmt.Text = string.Empty;
            lblLargest.Text = string.Empty;
            lblSmallest.Text = string.Empty;
            lblRecNum.Text = string.Empty;
            lblSalTotal.Text = string.Empty;
            cboxYear.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // close
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                // if the user DOES select a file
                // open the file
                inputFile = File.OpenText(openFile.FileName); // assign the file name to inputFile
                // during troubleshooting i used the dummydata.txt file you can find in this folder
            }
            else
            {
                // if they do anything else
                MessageBox.Show("Cancelled.");
                return; // end method early so nothing breaks
            }
            double[] lines = Array.ConvertAll(File.ReadAllLines(openFile.FileName), double.Parse); // read the file. update fileName. parse to array
            int lineAmt = lines.Length; // get the amt of lines/values. this helps it so it can run with however many records are present
            lblRecNum.Text = "The total number of records: " + lineAmt;
            // now to actually. get the data
            for (int i = 0; i < lineAmt; i++)
            {
                double data = lines[i]; // populates the array with the pulled data
                // Console.WriteLine(data); leftover from making sure it pulled
            }
            minMaxSal(lines); // pass the lines data to the method
            getAvg(lines); // calc average and bonus
            inputFile.Close(); // close that file
        }

        private void getAvg(double[] data)
        {
            double sum = 0.0;  // Declare sum outside the loop

            foreach (double num in data)
            {
                sum += num;  // Add each element to sum
            }
            lblSalTotal.Text = "The total salaries: "+ sum.ToString("c"); // display total to label

            // Calculate the Bonus if the combo box year is less than 2000 for 10 % of the average, 20 % if the box is in between 2000 and 2008, otherwise it’s 0.0
            double avg = 0.0;
            if (cboxYear.SelectedItem != null)
            {
                int.TryParse(cboxYear.SelectedItem.ToString(), out int yearPick); // assign chosen year as yearPick
                if (yearPick < 2000) // less than 2000
                {
                    avg = sum / data.Length; // calc average
                    lblAvg.Text = "The average: " + avg.ToString("c"); // display average to label
                    double bonusPercentage = 0.0;

                    if (yearPick >= 2000 && yearPick <= 2008)
                    {
                        bonusPercentage = 0.2; // between 2000 and 2008
                    }
                    else if (yearPick < 2000)
                    {
                        bonusPercentage = 0.1; // before 2000
                    }
                    lblBonusAmt.Text = "The Bonus amount is: " + (avg * bonusPercentage).ToString("c");
                }
                else
                {
                    lblBonusAmt.Text = "No Bonus available."; // in case there's extraneuous values
                }
            }
            else // if they don't select a year
            {
                lblAvg.Text = string.Empty;
                lblBonusAmt.Text = string.Empty;
                lblLargest.Text = string.Empty;
                lblSmallest.Text = string.Empty;
                lblRecNum.Text = string.Empty;
                lblSalTotal.Text = string.Empty;
                cboxYear.SelectedIndex = -1; // clear everything out
                MessageBox.Show("Please select a year.");
                
            }
        }

        private void minMaxSal(double[] data) // pull the array. name here doesn't matter i think??
        {
            // Create a void Method to call to find minimum or maximum salaries and display them.	
            double minSalary = double.MaxValue;
            double maxSalary = double.MinValue;

            foreach (double salary in data) // salary is basically 'i' here. data is the array
            {
                if (salary < minSalary)
                    minSalary = salary; // update if its the smallest
                lblSmallest.Text = "The smallest salary: " + minSalary.ToString("c"); // update label

                if (salary > maxSalary)
                    maxSalary = salary; // same as above but ofr max
                lblLargest.Text = "The largest salary: " + maxSalary.ToString("c"); // same as above but for max
            }
        }
        // my head hurts.
    }
}
