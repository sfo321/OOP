using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Common;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string username;
        private string firstname;
        private string lastname;
        private string password;
        public Role Role { get; set; }
        private readonly IList<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Password = password;
            Role rol = (Role)Enum.Parse(typeof(Role), role);
            this.Role = rol;
            this.vehicles = new List<IVehicle>();
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength,
                    Constants.MaxNameLength));
                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength,
                    Constants.MaxNameLength));
                this.lastname = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
            private set
            {
                Validator.ValidateSymbols(value, Constants.PasswordPattern,
                    String.Format(Constants.InvalidSymbols, "Password"));
                this.password = value;
            }
        }


        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                Validator.ValidateSymbols(value, Constants.UsernamePattern,
                    String.Format(Constants.InvalidSymbols, "Username"));
                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return new List<IVehicle>(vehicles);
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            commentToAdd.Author = this.Username;
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if(this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            if(this.Role == Role.Normal && vehicles.Count >= Constants.MaxVehiclesToAdd)
            {
                throw new ArgumentException(String.Format(Constants.NotAnVipUserVehiclesAdd,
                    Constants.MaxVehiclesToAdd));
            }
            this.vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if(commentToRemove.Author == this.Username)
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
            else
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.vehicles.Remove(vehicle);
        }
    }
}
