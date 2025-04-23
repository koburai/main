using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alyssa_Waddell_CPT_185_A80H_Lab_8
{
    internal class Employee
    {
        // declare all properties with get and set
        public string _name {  get; set; }
        public int _idNum { get; set; }
        public string _department { get; set; }
        public string _position { get; set; }

        // empty constructor
        public Employee()
        {
            _name = "";
            _idNum = 0;
            _department = "";
            _position = "";
        }

        // constructor that just does name and idnum, department and psitopn are ""
        public Employee(string name, int idNum)
        {
            _name = name;
            _idNum = idNum;
            _department = "";
            _position = "";
        }

        // constructor to accept all variables
        public Employee(string name, int idNum, string department, string position)
        {
            // assign everything inputted into the public strings/int proproeries
            _name = name; 
            _idNum = idNum;
            _department = department;
            _position = position;
        }

    }
}
