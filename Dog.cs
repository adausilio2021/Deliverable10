using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    class Dog : Animal
    {
        //feild
        private string _name;

        //Constructor
        public Dog(string name)
            :base("Dog")
        {
            _name = name;
        }

        //name prop
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //make sound
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }
    }
}
