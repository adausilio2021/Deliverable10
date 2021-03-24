using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Student
{
    class CompSciStudent : Student
    {
        //constants
        private double MATH_HOURS = 20;
        private double CS_HOURS = 40;
        private double GEN_HOURS = 60;

        //Feilds
        private string _academicTrack;

        //constructor
        public CompSciStudent(string name,string id, string track)
            :base(name,id)
        {
            _academicTrack = track;
        }
        //AcademicTrack Prop
        public string AcademicTrack
        {
            get { return _academicTrack; }
            set { _academicTrack = value; }
        }

        //REquiredHours prop
        public override double RequiredHours
        {
            get { return MATH_HOURS + CS_HOURS + GEN_HOURS; }
        }

     }
}
