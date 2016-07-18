namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Common.Constants;
    using Common.Exceptions;
    using Common.Utils;
    using Contracts;
    using FastAndFurious.ConsoleApplication.Common.Extensions;

    public abstract class MotorVehicle : IMotorVehicle, IWeightable, IValuable
    {
        private readonly int id;
        private int weight;
        private int acceleration;
        private int topspeed;
        private decimal price;
        private readonly ICollection<ITunningPart> tunningParts;

        public MotorVehicle(decimal price, int weight, int topspeed, int acceleration)
        {
            this.id = DataGenerator.GenerateId();
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topspeed;
            this.Price = price;
            this.tunningParts = new List<ITunningPart>();
        }

        public decimal Price
        {
            get
            {
                return this.price + this.TunningParts.Sum(x => x.Price);
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
                return this.acceleration + this.TunningParts.Sum(x => x.Acceleration); 
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
                return this.topspeed + this.TunningParts.Sum(x => x.TopSpeed);
            }
            private set
            {
                this.topspeed = value;
            }
        }
        public ICollection<ITunningPart> TunningParts
        {
            get
            {
                return new List<ITunningPart>(tunningParts);
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public void AddTunning(ITunningPart part)
        {
            if(this.TunningParts.Any(x => x.GetType() == part.GetType()))
            {
                throw new ArgumentException(GlobalConstants.CannotAddMultiplePartsOfTheSameTypeToVehicleExceptionMessage);
            }
            this.TunningParts.Add(part);
        }

        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            throw new NotImplementedException();
        }

        public bool RemoveTunning(ITunningPart part)
        {
            return this.TunningParts.Remove(part);
        }
    }
}
