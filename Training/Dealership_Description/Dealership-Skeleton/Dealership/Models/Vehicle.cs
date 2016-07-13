namespace Dealership.Models
{
    using Dealership.Contracts;
    using System;
    using System.Collections.Generic;
    using Dealership.Common.Enums;
    using Common;
    public abstract class Vehicle : IVehicle
    {
        private string make;
        private string model;        
        private decimal price;
        public int Wheels { get; protected set; }
        public VehicleType Type { get; protected set; }       
        private IList<IComment> comments;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
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
                     String.Format(Constants.StringMustBeBetweenMinAndMax, "Make",
                     Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength,
                     String.Format(Constants.StringMustBeBetweenMinAndMax, "Model",
                     Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax,
                    "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }
    }
}
