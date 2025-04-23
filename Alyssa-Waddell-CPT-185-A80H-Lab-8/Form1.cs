using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alyssa_Waddell_CPT_185_A80H_Lab_8
{
    /*alyssa waddell
     * cpt 185 a80h
     * lab 8: employee class*/
    public partial class Form1 : Form
    {

        // create the employee instances (or objects, i guess?)
        // it doesn't seem like i need to make it to where new employees can be created, ssssooooo i didn't do that.
        private Employee empOne = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
        private Employee empTwo = new Employee("Mark Jones", 39119, "IT", "Programmer");
        private Employee empThree = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            lblInfo.Text = $"Employee Name: {empOne._name}\nID: {empOne._idNum}\nDepartment: {empOne._department}\nPosition: {empOne._position}";
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            lblInfo.Text = $"Employee Name: {empTwo._name}\nID: {empTwo._idNum}\nDepartment: {empTwo._department}\nPosition: {empTwo._position}";
        }
        private void btnShow3_Click(object sender, EventArgs e)
        {
            lblInfo.Text = $"Employee Name: {empThree._name}\nID: {empThree._idNum}\nDepartment: {empThree._department}\nPosition: {empThree._position}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblInfo.Text = string.Empty ; // only one thing to empty this time
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
