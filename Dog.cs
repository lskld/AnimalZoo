using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Dog: Animal
    {
        public bool CanSit {  get; set; }
        public Dog() : base()
        {
            CanSit = true;

            Legs = 4;
            Color = "Brown";
            Sound = "Woof!";
            Carnivore = true;
            Friendly = true;
        }
        public void Sit()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} is sitting. Good boy!");
        }
    }

    class Labrador : Dog
    {
        public bool CanLay {  get; set; }
        public Labrador()
        {
            CanLay = true;
            CanSit = true;
            Legs = 4;
            Color = "Golden";
            Sound = "Wooooof!";
            Carnivore = true;
            Friendly = true;
        }
        public void PrettyPaw()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} does pretty paw. Good boy!");
        }

    }

    class Dachshund : Dog
    {
        public bool BackProblems { get; set; }
        public Dachshund()
        {
            BackProblems = true;
            CanSit = true;
            Legs = 4;
            Color = "Brown and black";
            Sound = "Bark! Bark!! Bark! Bark!!";
            Carnivore = true;
            Friendly = true;
        }
        public void PlayDead()
        {
            Console.WriteLine($"The {GetType().Name.ToLower()} is playing dead...");
        }
    }
}

