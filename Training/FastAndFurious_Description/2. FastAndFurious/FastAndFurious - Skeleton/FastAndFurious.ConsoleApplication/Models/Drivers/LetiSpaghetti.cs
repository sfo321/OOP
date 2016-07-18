namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Common.Extensions;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class LetiSpaghetti : Driver, IDriver, IIdentifiable
    {
        private const string LettiName = "Leti Spaghetti";

        public LetiSpaghetti()
            : base(LettiName, GenderType.Female)
        {
        }
    }
}
