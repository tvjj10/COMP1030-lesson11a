class Cat : Animal {
    //no errors, all good due to virtual method.
    public override void MakeSound()
    {
        //base.MakeSound(); calling method from parent class
        Console.WriteLine("Cat goes meow meow");
    }
    public override void Sleep()
    {
        Console.WriteLine("cat go brrrr brrr");
    }
}