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
    public partial class Egg_Select : Form
    {
        public Egg_Select()
        {
            InitializeComponent();
        }
        StreamWriter outputFile = File.CreateText("tempdata.txt");
        Critter_Carnival critterCarnival = new Critter_Carnival(); // go ahead and declare this so i don't gotta do it for every egg
        private void pboxRed_Click(object sender, EventArgs e)
        {
            if (txtbName.Text != string.Empty) // make sure a name is picked
            {
                outputFile.WriteLine("critFile"); // line to verify its a critter file
                outputFile.WriteLine("RED"); // identify it as a red creature
                outputFile.WriteLine(txtbName.Text); // name
                outputFile.WriteLine("1"); // age
                outputFile.WriteLine("10"); // hunger
                outputFile.WriteLine("10"); // joy
                critterCarnival.Show(); // open game
            }
            else
            {
                MessageBox.Show("Enter a name before continuing.");
                return;
            }
            outputFile.Close(); // make sure to close
        }

        private void pboxBlue_Click(object sender, EventArgs e)
        {
            if (txtbName.Text != string.Empty) // make sure a name is picked
            {
                outputFile.WriteLine("critFile"); // line to verify its a critter file
                outputFile.WriteLine("BLUE"); // identify it as a blue creature
                outputFile.WriteLine(txtbName.Text); // name
                outputFile.WriteLine("1"); // age
                outputFile.WriteLine("10"); // hunger
                outputFile.WriteLine("10"); // joy
                critterCarnival.Show(); // open game
            }
            else
            {
                MessageBox.Show("Enter a name before continuing.");
                return;
            }
            outputFile.Close(); // make sure to close
        }

        private void pboxGreen_Click(object sender, EventArgs e)
        {
            if (txtbName.Text != string.Empty) // make sure a name is picked
            {
                outputFile.WriteLine("critFile"); // line to verify its a critter file
                outputFile.WriteLine("GREEN"); // identify it as a green creature
                outputFile.WriteLine(txtbName.Text); // name
                outputFile.WriteLine("1"); // age
                outputFile.WriteLine("10"); // hunger
                outputFile.WriteLine("10"); // joy
                critterCarnival.Show(); // open game
            }
            else
            {
                MessageBox.Show("Enter a name before continuing.");
                return;
            }
            outputFile.Close(); // make sure to close
        }
    }
}
