namespace AnimalWorks.Animals
{
    using System;
    using AnimalWorks.Enumerations;
    using AnimalWorks.Interfaces;

    public class Kitten : Animal, ISound
    {
        public Kitten(int age, string name) : base(age, name, Gender.Female)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("I Am a Kitten and i say Miaooo");
        }
    }
}