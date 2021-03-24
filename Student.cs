using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Student
{
    abstract class Student
    {
        //feilds
        private string _name;
        private string _id;

        //Constructor
        public Student (string name, string id)
        {
            _name = name;
            _id = id;
        }
        
        //Name Prop
        public string Name
        {
            get { return _id; }
            set { _name = value; }
        }
        //ID Prop
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        //requiredHours prop
        public abstract double RequiredHours
        {
            get;
        }
    
    }
}
