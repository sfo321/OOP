namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class Mia : Driver, IDriver, IIdentifiable
    {
        private const string MiaName = "Mia";

        public Mia()
            : base(MiaName, GenderType.Female)
        {
        }
    }
}
