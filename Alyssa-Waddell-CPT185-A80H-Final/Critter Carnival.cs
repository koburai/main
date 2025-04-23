using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alyssa_Waddell_CPT185_A80H_Final
{
    public partial class Critter_Carnival : Form
    {
        public Critter_Carnival()
        {
            InitializeComponent();
        }
        StreamReader inputFile;
        // declare globals
        int age;
        string name;
        int hunger;
        int joy;
        string type;
        private Critter playable;
        private void Critter_Carnival_Load(object sender, EventArgs e)
        {
            // on load
            openFileDialog.FileName = "tempdata.txt"; // default to temp data
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                if (playable != null)
                {
                    lblName.Text = playable.Name; // update all data for the labels
                    lblAgeTxt.Text = playable.Age.ToString();
                    lblHungertxt.Text = playable.Hunger.ToString();
                    lblJoytxt.Text = playable.Joy.ToString();

                    // update image
                    if (playable.Age <= 66) // child
                    {
                        if (playable.Type == "RED")
                            pboxRedA.Visible = true;
                        else if (playable.Type == "BLUE")
                            pboxBlueA.Visible = true;
                        else if (playable.Type == "GREEN")
                            pboxGreenA.Visible = true;
                    }
                    else // adult
                    {
                        if (playable.Type == "RED")
                            pboxRedB.Visible = true;
                        else if (playable.Type == "BLUE")
                            pboxBlueB.Visible = true;
                        else if (playable.Type == "GREEN")
                            pboxGreenB.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Data was not loaded properly.");
                }
            }
            else
            {
                MessageBox.Show("Cancelled.");
                return;
            }
        } // end open file

        private void LoadData() // function to load information
        {
            HideImages();
            string[] data = File.ReadAllLines(openFileDialog.FileName);

            for (int i = 0; i < data.Length; i += 6)
            {
                if (data[i] == "critFile")
                {
                    string type = data[i + 1];
                    string name = data[i + 2];
                    int.TryParse(data[i + 3], out int age);
                    int.TryParse(data[i + 4], out int hunger);
                    int.TryParse(data[i + 5], out int joy);

                    // Ensure critter is created
                    playable = new Critter(name, type, age, hunger, joy);
                    MessageBox.Show("Critter " + name + " loaded!");
                    return;
                }
                else
                {
                    MessageBox.Show("No critter file detected.");
                    return;
                }
            }
        } // end load

        // function to increase age and decrease food/joy
        public void TimePass(int age, int hunger, int joy)
        {
            Random random = new Random(); // make new random
            int ageInc = random.Next(0, 2); // randomly increase age
            age = age + ageInc;
            int hungerDec = random.Next(0, 2); // randomly decrease hunger
            hunger = hunger - hungerDec;
            int joyDec = random.Next(0, 2); // randomly decrease joy
            joy = joy - joyDec;
            
            // make sure all numbers are valid
            if (joy < 0)
            {
                joy = 0;
            }
            if (hunger  < 0)
            {
                hunger = 0;
            }
            if (age > 100)
            {
                age = 100;
            }

            // update critter stuff
            playable.Age = age;
            playable.Hunger = hunger;
            playable.Joy = joy;
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            TimePass(playable.Age, playable.Hunger, playable.Joy); // time pass the current age, hunger, and joy from the class
            playable.Hunger = playable.Feed(playable.Hunger); // make sure not above 100 or below 0
            if(playable.Hunger < 0)
            {
                playable.Hunger = 0;
            }
            else if (playable.Hunger > 100)
            {
                playable.Hunger = 100;
            }
            // pass hunger and update txt
            lblAgeTxt.Text = playable.Age.ToString();
            lblHungertxt.Text = playable.Hunger.ToString();
            lblJoytxt.Text = playable.Joy.ToString();
            ImageUpdate(); // update iamge
            WriteSave(); // save data
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            TimePass(playable.Age, playable.Hunger, playable.Joy); // time pass the current age, hunger, and joy from the class
            playable.Joy = playable.Play(playable.Joy);// check to make sure not below 0 or above 100
            if (playable.Joy < 0)
            {
                playable.Joy = 0;
            }
            else if (playable.Joy > 100)
            {
                playable.Joy = 100;
            }
            // pass joy and update txt
            lblAgeTxt.Text = playable.Age.ToString();
            lblHungertxt.Text = playable.Hunger.ToString();
            lblJoytxt.Text = playable.Joy.ToString();
            ImageUpdate(); // update i
            WriteSave(); // save data
        }

        private void WriteSave() // function to save data
        {
            StreamWriter outputFile;
            outputFile = File.CreateText("tempdata.txt");
            outputFile.WriteLine("critFile"); // verification line
            outputFile.WriteLine(playable.Type.ToUpper()); // make sure its uppercase
            outputFile.WriteLine(playable.Name);
            outputFile.WriteLine(playable.Age);
            outputFile.WriteLine(playable.Hunger);
            outputFile.WriteLine(playable.Joy);
            outputFile.Close();
        }

        private void ImageUpdate() // function to update image once it reaches age 66
        {
            if (playable.Age <= 66) // child
            {
                if (playable.Type == "RED")
                    pboxRedA.Visible = true;
                else if (playable.Type == "BLUE")
                    pboxBlueA.Visible = true;
                else if (playable.Type == "GREEN")
                    pboxGreenA.Visible = true;
            }
            else // adult
            {
                if (playable.Type == "RED")
                    pboxRedB.Visible = true;
                else if (playable.Type == "BLUE")
                    pboxBlueB.Visible = true;
                else if (playable.Type == "GREEN")
                    pboxGreenB.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtbSave.Text != string.Empty && lblName.Text != string.Empty)
            {
                HideImages();
                // if not empty
                StreamWriter outputFile;
                outputFile = File.CreateText(txtbSave.Text + ".txt");
                outputFile.WriteLine("critFile"); // verification line
                outputFile.WriteLine(playable.Type.ToUpper()); // make sure its uppercase
                outputFile.WriteLine(playable.Name);
                outputFile.WriteLine(playable.Age);
                outputFile.WriteLine(playable.Hunger);
                outputFile.WriteLine(playable.Joy);
                outputFile.Close();
                MessageBox.Show("Saved to " + txtbSave.Text + ".txt");
            }
            else // if empty
            {
                MessageBox.Show("Be sure to have data loaded before trying to save.");
                return;
            }
        }

        private void HideImages()
        {
            // make sure to hide all picture boxes so it updates
            pboxBlueA.Visible = false;
            pboxBlueB.Visible = false;
            pboxGreenA.Visible = false;
            pboxGreenB.Visible = false;
            pboxRedA.Visible = false;
            pboxRedB.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


