class Goldfish : Animal{
    
    public override void MakeSound()
    {
        //base.MakeSound(); calling method from parent class
        Console.WriteLine("Goldfish goes blub blub");
    }
}