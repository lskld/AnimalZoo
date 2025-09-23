namespace AnimalZoo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {        
            Dog myDog = new Dog();
            myDog.MakeSound();

            Cat myCat = new Cat();
            myCat.MakeSound();

            Bird myBird = new Bird();
            myBird.MakeSound();

            Labrador myLabrador = new Labrador();
            myLabrador.MakeSound();

            Dachshund myDachshund = new Dachshund();
            myDachshund.MakeSound();
        }

    }
}
