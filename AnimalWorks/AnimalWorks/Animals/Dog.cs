namespace AnimalWorks.Animals
{
    using System;
    using AnimalWorks.Enumerations;
    using AnimalWorks.Interfaces;

    public class Dog : Animal, ISound
    {
        public Dog(int age, string name, Gender gender) : base(age, name, gender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("BAWWW");
        }
    }
}