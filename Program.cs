namespace Polymorphisim;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Cat myCat = new Cat();
        Dog myDog = new Dog();
        Goldfish dory = new Goldfish();
        // simple inheritance
        dory.MakeSound();

        //polymorphisim in action
        myCat.MakeSound();
        myDog.MakeSound();

        //polymorphic methods
        dory.Sleep();
        myCat.Sleep();
        myDog.Sleep();

    }
}
