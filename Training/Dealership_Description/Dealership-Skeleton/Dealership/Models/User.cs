using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;

namespace Dealership.Models
{
    public class User : IUser
    {
        private string username;
        private string firstname;
        private string lastname;
        private string password;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Password = password;
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }
        }

        public Role Role
        {
            get
            {
                return this.Role;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            throw new NotImplementedException();
        }

        public void AddVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public string PrintVehicles()
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            throw new NotImplementedException();
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
