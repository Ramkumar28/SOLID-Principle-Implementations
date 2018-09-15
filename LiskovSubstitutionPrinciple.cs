using System;
namespace SOLID_Example
{
    public class Animal
    {
        public virtual void Fly()
        {
           //No need implementation;
        }
        public virtual void Walk()
        {
            Console.WriteLine("I can walk");
        }

        public virtual void MakeNoise()
        {
            //No need Implentation.
        }

    }

    public class Bird : Animal
    {
        public override void Fly()
        {
            Console.WriteLine("I can fly");
        }

public override void MakeNoise()
{
    Console.WriteLine("I can make Cuckoo sound");

}
    }

    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("I can bark");
        }
    }
}