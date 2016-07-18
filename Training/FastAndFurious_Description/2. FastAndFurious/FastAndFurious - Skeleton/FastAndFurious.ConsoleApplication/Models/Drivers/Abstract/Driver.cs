namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FastAndFurious.ConsoleApplication.Common.Constants;
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Utils;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Common.Extensions;

    public abstract class Driver : IDriver, IIdentifiable
    {
        private readonly int id;
        private string name;
        private GenderType gender;
        private IMotorVehicle activeVehicle;
        private ICollection<IMotorVehicle> vehicles;

        public Driver(string name, GenderType gender)
        {
            this.id = DataGenerator.GenerateId();
            this.Gender = gender;
            this.Name = name;
            this.vehicles = new List<IMotorVehicle>();
        }

        public IMotorVehicle ActiveVehicle
        {
            get
            {
                return this.activeVehicle;
            }
            //private set
            //{
            //    this.ActiveVehicle = activeVehicle;
            //}
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public ICollection<IMotorVehicle> Vehicles
        {
            get
            {
                return new List<IMotorVehicle>(vehicles);
            }
        }

        public void AddVehicle(IMotorVehicle vehicle)
        {
            if(this.Vehicles.Contains(vehicle))
            {
                throw new ArgumentException(GlobalConstants.DriverCannotBeAssignedAsOwnerToVehicleMoreThanOnceExceptionMessage);
            }
            this.Vehicles.Add(vehicle);
        }


        public bool RemoveVehicle(IMotorVehicle vehicle)
        {
            return this.Vehicles.Remove(vehicle);
        }

        public void SetActiveVehicle(IMotorVehicle vehicle)
        {
            if(!this.Vehicles.Contains(vehicle))
            {
                throw new ArgumentException(GlobalConstants.CannotSetForeignVehicleAsActiveExceptionMessage);
            }
            if(vehicle == null)
            {
                throw new ArgumentNullException(GlobalConstants.CannotSetNullObjectAsActiveVehicleExceptionMessage);
            }
            this.activeVehicle = vehicle;
        }
    }
}
