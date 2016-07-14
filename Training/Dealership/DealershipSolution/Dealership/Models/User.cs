namespace Dealership.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common.Enums;
    using Common;

    public class User : IUser
    {
        private string username;
        private string firstname;
        private string lastname;
        private string password;
        private Role role;
        private IList<IVehicle> vehicles;

        public User(string username, string firstname, string lastname, string password, string role)
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
               Validator.ValidateNull(value, 
                   String.Format("{0} cannot be null or empty!", "Firstname"));

                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength,
                    Constants.MaxNameLength));
                this.firstname = value;
            }
        }


        public Role Role
        {
            get
            {
                return this.role;
            }
            set
            {
                this.role = value;
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
                Validator.ValidateNull(value,
                   String.Format("{0} cannot be null or empty!", "Lastname"));

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
                Validator.ValidateNull(value,
                   String.Format("{0} cannot be null or empty!", "Password"));

                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength,
                    Constants.MaxPasswordLength));

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
                Validator.ValidateNull(value,
                    String.Format("{0} cannot be null or empty!", "Username"));

                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength,
                    Constants.MaxNameLength));

                Validator.ValidateSymbols(value, Constants.UsernamePattern,
                    String.Format(Constants.InvalidSymbols, "Username"));
                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
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
            var result = new StringBuilder();
            var counter = 1;

            result.AppendLine(String.Format("--USER {0}--", this.Username));
            if (Vehicles.Count > 0)
            {
                foreach (var vehicle in this.Vehicles)
                {
                    result.AppendLine(String.Format("{0}. {1}:", counter, vehicle.GetType().Name));
                    result.Append(vehicle.ToString());
                    counter++;

                    if(vehicle.Comments.Count > 0)
                    {
                        result.AppendLine("    --COMMENTS--");
                        foreach(var comment in vehicle.Comments)
                        {
                            result.Append(comment.ToString());
                        }
                        result.AppendLine("    --COMMENTS--");
                    }
                    else
                    {
                        result.AppendLine("    --NO COMMENTS--");
                    }
                }
            }
            else
            {
                result.AppendLine("--NO VEHICLES--");
            }
            return result.ToString().Trim();
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

        public override string ToString()
        {
            return String.Format(Constants.UserToString + ", Role: {3}", 
                this.Username, this.FirstName, this.LastName, this.Role).Trim();
        }
    }
}
