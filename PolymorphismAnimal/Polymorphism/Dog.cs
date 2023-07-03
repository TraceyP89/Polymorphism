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
        public Dog(string name) : base("Dog")
        {
            Name = name;
        }
        public string Name { get; set; }

        public override void MakeSound()
        {
            MessageBox.Show("woof woof!");
        }
    }
}
