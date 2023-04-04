class Dog : Animal{
    //
    
    public override void MakeSound()
    {
        //base.MakeSound(); calling method from parent class
        Console.WriteLine("Dog goes woof woof");
    }
        public override void Sleep()
    {
        Console.WriteLine("Dog go ugrrrrhgggrghrg");
    }
}