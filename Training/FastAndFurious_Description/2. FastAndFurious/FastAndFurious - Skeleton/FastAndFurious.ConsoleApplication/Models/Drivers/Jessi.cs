namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class Jessi : Driver, IDriver, IIdentifiable
    {
        private const string JessiName = "Jessi";

        public Jessi()
            : base(JessiName, GenderType.Female)
        {
        }
    }
}
