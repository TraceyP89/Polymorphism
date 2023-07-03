using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
     class Cat : Animal
    {
        public Cat(string name) : base("Cat")
        {
            Name = name;
        }
        public string Name { get; set; }
        public override void MakeSound()
        {
            MessageBox.Show("Meow");
        }
    }
}
