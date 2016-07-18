namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract
{
    using System;
    using Contracts;
    using Common.Enums;
    using MotorVehicles.Abstract;
    using Common.Extensions;
    using Common.Utils;

    public abstract class TunningPart : ITunningPart, IAccelerateable, ITopSpeed, IWeightable,
        IValuable, IIdentifiable
    {
        private readonly int id;
        private int weight;
        private int acceleration;
        private int topspeed;
        private decimal price;
        private TunningGradeType gradeType;

        public TunningPart(decimal price, int weight, int topspeed, int acceleration, TunningGradeType gradeType)
        {
            this.id = DataGenerator.GenerateId();
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topspeed;
            this.Price = price;
            this.GradeType = gradeType;
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                this.price = value;
            }
        }
        public int Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                this.weight = value;
            }
        }
        public int Acceleration
        {
            get
            {
                return this.acceleration;
            }
            private set
            {
                this.acceleration = value;
            }
        }
        public int TopSpeed
        {
            get
            {
                return this.topspeed;
            }
            private set
            {
                this.topspeed = value;
            }
        }
        
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public TunningGradeType GradeType
        {
            get
            {
                return this.gradeType;
            }
            private set
            {
                this.gradeType = value;
            }
        }
    }
}
