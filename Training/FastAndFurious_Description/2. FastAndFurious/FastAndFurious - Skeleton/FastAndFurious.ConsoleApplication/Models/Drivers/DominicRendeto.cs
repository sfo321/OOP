namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class DominicRendeto : Driver, IDriver, IIdentifiable
    {
        private const string DominicName = "Dominic Rendeto";

        public DominicRendeto()
            : base(DominicName, GenderType.Male)
        {
        }
    }
}
