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
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            How_To_Play howToPlay = new How_To_Play(); // declare new instance of the help form
            howToPlay.Show(); // open the help form
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Egg_Select egg_Select = new Egg_Select();
            egg_Select.Show(); // open the egg select form
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Critter_Carnival critterCarnival = new Critter_Carnival();
            critterCarnival.Show(); // open the main game
        }
    }
}
