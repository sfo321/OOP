using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Extensions;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface IMotor : ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        int Horsepower { get; }
        MotorType MotorType { get; }
        CylinderType CylinderType { get; }
    }
}
