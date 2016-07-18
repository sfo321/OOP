namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class Vince : Driver, IDriver, IIdentifiable
    {
        private const string VinceName = "Vince";

        public Vince()
            : base(VinceName, GenderType.Male)
        {
        }
    }
}
