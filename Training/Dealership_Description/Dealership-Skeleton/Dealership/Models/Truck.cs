namespace Dealership.Models
{
    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;
    using System;

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
                    String.Format(Constants.NumberMustBeBetweenMinAndMax, "Capacity", Constants.MinCapacity,
                    Constants.MaxCapacity));
                this.weightcapacity = value;
            }

        }
    }
}
