using System.Collections.Generic;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Extensions;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface IDriver : IIdentifiable
    {
        string Name { get; }
        GenderType Gender { get; }
        IMotorVehicle ActiveVehicle { get; }
        ICollection<IMotorVehicle> Vehicles { get; }
        void AddVehicle(IMotorVehicle vehicle);
        void SetActiveVehicle(IMotorVehicle vehicle);
        bool RemoveVehicle(IMotorVehicle vehicle);
    }
}
