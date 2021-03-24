using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //for MessageBox

namespace Polymorphism
{
    class Animal
    {
        //Feild
        private string _species;

        //constructor
        public Animal(string species)
        {
            _species = species;
        }

        //Species Prop
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        //MakeSound method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrr");
        }
    }
}
