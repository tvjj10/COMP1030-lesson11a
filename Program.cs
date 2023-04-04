namespace Polymorphisim;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Cat myCat = new Cat();
        Dog myDog = new Dog();
        Goldfish dory = new Goldfish();

        dory.MakeSound();
        myCat.MakeSound();
        myDog.MakeSound();
    }
}
