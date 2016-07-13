namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;
    using System;

    public class Motorcycle : Vehicle, IVehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category) : base(make, model, price)
        {
            this.Type = VehicleType.Motorcycle;
            this.Wheels = (int)VehicleType.Motorcycle;
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Category",
                    Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }
    }
}
