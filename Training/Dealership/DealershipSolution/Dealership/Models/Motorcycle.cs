namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Contracts;
    using System;
    using System.Text;

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
                Validator.ValidateNull(value,
                    String.Format("{0} cannot be null or empty!", "Category"));

                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Category",
                    Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine(String.Format("  Category: {0}", this.Category));

            return result.ToString();
        }
    }
}
