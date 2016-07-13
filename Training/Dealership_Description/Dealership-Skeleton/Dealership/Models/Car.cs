namespace Dealership.Models
{
    using Common;
    using Common.Enums;
    using Dealership.Contracts;
    using System;

    public class Car : Vehicle, IVehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats) : base(make, model, price)
        {
            this.Type = VehicleType.Car;
            this.Wheels = (int)VehicleType.Car;
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }
            private set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats,
                    String.Format(Constants.NumberMustBeBetweenMinAndMax,
                    "Seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }
    }
}
