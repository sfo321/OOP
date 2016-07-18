namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits
{
    using Common.Enums;
    using Common.Extensions;
    using Contracts;
    using Tunnings.Abstract;

    public class APREngineControlUnit : TunningPart, ITunningPart, IAccelerateable, ITopSpeed,
        IWeightable, IValuable, IIdentifiable, IEngineControlUnit
    {
        private const int APREngineControlUnitWeightInGrams = 22000;
        private const int APREngineControlUnitAccelerationBonus = 45;
        private const int APREngineControlUnitTopSpeedBonus = 75;
        private const decimal APREngineControlUnitPriceInUSADollars = 5789;

        public EngineControlUnitType EngineControlUnitType { get; }


        public APREngineControlUnit()
            : base(APREngineControlUnitPriceInUSADollars, APREngineControlUnitWeightInGrams,
                  APREngineControlUnitAccelerationBonus, APREngineControlUnitTopSpeedBonus,
                  TunningGradeType.HighGrade)
        {
            this.EngineControlUnitType = EngineControlUnitType.Pro;
        }
    }
}
