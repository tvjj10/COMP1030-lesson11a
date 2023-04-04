class Cat : Animal {
    //no errors, all good due to virtual method.
    public override void MakeSound()
    {
        //base.MakeSound(); calling method from parent class
        Console.WriteLine("cat goes meow meow");
    }
}