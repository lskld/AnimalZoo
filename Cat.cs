using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Cat: Animal
    {
        public bool outsideCat = true;
        public Cat() : base()
        {
            legs = 4;
            color = "black";
            sound = "Meow!";
            carnivore = true;
            friendly = false;
        }
        public void Attack()
        {

        }
    }
}
