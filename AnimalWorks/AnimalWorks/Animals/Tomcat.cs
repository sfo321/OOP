namespace AnimalWorks.Animals
{
    using System;
    using AnimalWorks.Enumerations;
    using AnimalWorks.Interfaces;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(int age, string name) : base(age, name, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I Am a Tomcat and i say Miaooo");
        }
    }
}