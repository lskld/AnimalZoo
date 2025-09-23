using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Animal
    {
        /* 5 common properties */
        public int Legs {  get; set; }
        public string? Color { get; set; }
        public string? Sound { get; set; }
        public bool Carnivore { get; set; }
        public bool Friendly { get; set; }

        public Animal()
        {
            Legs = 4;
            Color = "Black";
            Sound = "Rawr";
            Carnivore = true;
            Friendly = true;
        }

        public void MakeSound()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} says {Sound}");
        }

        public void Eat()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} is sleeping");
        }
    }
}
