using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Extensions;
using System.Collections;

namespace FastAndFurious.ConsoleApplication.Contracts
{
    public interface ITunningPart : IAccelerateable, ITopSpeed, IWeightable, IValuable, IIdentifiable
    {
        TunningGradeType GradeType { get; }
    }
}
