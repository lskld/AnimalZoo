using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Bird: Animal
    {
        public bool CanFly {  get; set; }
        public Bird() : base()
        {
            CanFly = true;

            Legs = 2;
            Color = "Red";
            Sound = "Craaaw Craaaw!";
            Carnivore = false;
            Friendly = false;
        }
        public void FlyAway()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} just flew away from the Zoo... that's not very good");
        }
    }
}
