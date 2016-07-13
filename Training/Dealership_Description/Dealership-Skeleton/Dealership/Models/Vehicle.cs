namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Common.Enums;
    using Dealership.Contracts;
    using Common;
    public abstract class Vehicle : IVehicle
    {
        private string make;
        private readonly string model;        
        private decimal price;
        public int Wheels { get; protected set; }        
        public VehicleType Type { get; protected set; }
        private readonly IList<IComment> comments;


        public Vehicle(VehicleType type, string make, string model, decimal price, int wheels)
        {
            this.Type = type;
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Wheels = wheels;
            this.comments = new List<IComment>();
        }

        public IList<IComment> Comments
        {
            get
            {
                return new List<IComment>(comments);
            }            
        }

        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                   String.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }

        }

        public string Model
        {
            get
            {
                throw new NotImplementedException();
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                   String.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
