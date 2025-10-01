//Theo Lilliesköld, NET25

namespace AnimalZoo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Animal[] animals = { new Dog(), new Cat(), new Bird(), new Labrador(), new Dachshund() };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }
    }
}
