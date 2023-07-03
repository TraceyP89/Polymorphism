using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
     class Animal
    {
        //Constructor
        public Animal (string species)
        {
            Species = species;
        }
        //Properties
        public string Species { get; set; }

        //Method
        public virtual void MakeSound()
        {
            MessageBox.Show("Grrrrrrr.");
        }
    }

}
