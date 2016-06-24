namespace AnimalWorks.Animals
{
    using System;
    using AnimalWorks.Enumerations;
    using AnimalWorks.Interfaces;

    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender gender) : base(age, name, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("KWAK");
        }
    }
}