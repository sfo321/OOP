namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;
    using System;
    using System.Text;

    public class Truck : Vehicle, IVehicle, ITruck
    {
        private int weightcapacity;

        public Truck(string make, string model, decimal price, int weightcapacity) : base(make, model, price)
        {
            this.Type = VehicleType.Truck;
            this.Wheels = (int)VehicleType.Truck;
            this.WeightCapacity = weightcapacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightcapacity;
            }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity,
                    Constants.MaxCapacity));
                this.weightcapacity = value;
            }

        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.AppendLine(String.Format("  Weight Capacity: {0}t", this.WeightCapacity));

            return result.ToString();
        }
    }
}
