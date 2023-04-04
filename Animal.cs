// this class represents animals in my system.
// classes must be delared abstract
//to contain abstract methods
abstract class Animal{
    //make some sound

public virtual void MakeSound() {
    //virtual means optional

    Console.WriteLine("animal is making a default sound: blop blop!");
}
    //Sleep
    // this is a mandatory method.
    // all animals must implement sleep

    public abstract void Sleep();

}