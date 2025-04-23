using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alyssa_Waddell_CPT185_A80H_Final
{
    public partial class How_To_Play : Form
    {
        public How_To_Play()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreatureSel_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "Selecting a creature is as easy as using the drop-down menu on the drop down menu on the game page!" +
                " This will write to a text file, which will then be used to update your critter as needed. When starting " +
                "the game, be sure to load your tempdata to begin!";
        }

        private void btnCreatureHealth_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "Keeping your creature happy is very important. You can feed and play with your critter using the 'feed' " +
                "and 'play' buttons on the game page.";
        }

        private void btnSaveLoad_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "The game will try to automatically save to a temporary file upon every interaction to ensure the least " +
                "amount of data is lost in the event of a crash. A save and load button is also present on the game page!";
        }
    }
}
