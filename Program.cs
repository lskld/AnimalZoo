namespace AnimalZoo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           
        }

        class Animal
        {
            /* 5 common properties */
            public int legs;
            public string? color;
            public string? sound;
            public bool carnivore;
            public bool friendly;                      

            public Animal()
            {
                legs = 4;
                color = "white";
                sound = "brrrr";
                carnivore = false;
                friendly = false;

            }
            
            public void MakeSound()
            {
                Console.WriteLine(sound);
            }

            public void Eat()
            {
                Console.WriteLine("The animal is eating");
            }

            public void Sleep()
            {
                Console.WriteLine("The animal is sleeping");
            }

        }

        class Cat: Animal
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

        class Bird: Animal
        {
            public bool canFly = true;
            public Bird()
            {
                legs = 2;
                color = "red";
                sound = "Craaaaw!";
                carnivore = false;
                friendly = false;
            }
            public void Fly ()
            {
               
            }
        }

        class Dog : Animal
        {
            public bool canSit = true;

            public Dog()
            {
                legs = 4;
                color = "brown";
                sound = "Woof!";
                carnivore = true;
                friendly = true;
            }
            public void Sit()
            {
               
            }
        }

        class Labrador : Dog
        {

            public Labrador()
            {

            }
            public void PrettyPaw()
            {

            }

        }

        class Daschund : Dog
        {

            public Daschund()
            {
            
            }
            public void PlayDead()
            {

            }
        }

    }
}
