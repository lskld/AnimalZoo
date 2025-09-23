using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Cat: Animal
    {
        public int LengthInCm {  get; set; }
        public Cat() : base()
        {
            LengthInCm = 70;

            Legs = 4;
            Color = "White";
            Sound = "Meow!";
            Carnivore = true;
            Friendly = false;
        }
        public void UseClaws()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} just scratched you with their claws... Ouch!");
        }
    }
}
