namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class VinBenzin : Driver, IDriver, IIdentifiable
    {
        private const string BenzinName = "Vin Benzin";

        public VinBenzin()
            : base(BenzinName, GenderType.Male)
        {
        }
    }
}
