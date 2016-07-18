namespace FastAndFurious.ConsoleApplication.Models.Motors.Abstract
{
    using System;
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using Common.Utils;

    public abstract class Motor : IMotor, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        private readonly int id;
        public int Weight { get; private set; }
        public int Acceleration { get; private set; }
        public int TopSpeed { get; private set; }
        public decimal Price { get; private set; }
        public int Horsepower { get; private set; }
        public TunningGradeType GradeType { get; private set;}
        public CylinderType CylinderType { get; private set; }
        public MotorType MotorType { get; private set; }

        public Motor(decimal price, int weight, int acceleration, int topSpeed, int horsepower,
            TunningGradeType gradeType, CylinderType cylinderType, MotorType motorType)
        {
            this.id = DataGenerator.GenerateId();
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.Price = price;
            this.Horsepower = horsepower;
            this.GradeType = gradeType;
            this.CylinderType = cylinderType;
            this.MotorType = motorType;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }
    }
}
