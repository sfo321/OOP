namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits
{
    using Common.Enums;
    using Common.Extensions;
    using Contracts;
    using Tunnings.Abstract;

    public class DinanEngineControlUnit : TunningPart, ITunningPart, IAccelerateable, ITopSpeed,
        IWeightable, IValuable, IIdentifiable, IEngineControlUnit
    {
        private const int DinanEngineControlUnitWeightInGrams = 19000;
        private const int DinanEngineControlUnitAccelerationBonus = 35;
        private const int DinanEngineControlUnitTopSpeedBonus = 65;
        private const decimal DinanEngineControlUnitPriceInUSADollars = 4999;

        public EngineControlUnitType EngineControlUnitType { get; }

        public DinanEngineControlUnit()
            : base(DinanEngineControlUnitPriceInUSADollars, DinanEngineControlUnitWeightInGrams,
                  DinanEngineControlUnitAccelerationBonus, DinanEngineControlUnitTopSpeedBonus,
                  TunningGradeType.MidGrade)
                  
        {
            this.EngineControlUnitType = EngineControlUnitType.Performance;
        }
    }
}
