namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits
{
    using Common.Enums;
    using Contracts;
    using Tunnings.Abstract;
    using Common.Extensions;

    public class SCTPerformanceEngineControlUnit : TunningPart, ITunningPart, IAccelerateable, ITopSpeed,
        IWeightable, IValuable, IIdentifiable, IEngineControlUnit
    {
        private const int SCTPerformanceEngineControlUnitWeightInGrams = 21000;
        private const int SCTPerformanceEngineControlUnitAccelerationBonus = 25;
        private const int SCTPerformanceEngineControlUnitTopSpeedBonus = 45;
        private const decimal SCTPerformanceEngineControlUnitPriceInUSADollars = 3599;

        public EngineControlUnitType EngineControlUnitType { get; }

        public SCTPerformanceEngineControlUnit()
            : base(SCTPerformanceEngineControlUnitPriceInUSADollars, SCTPerformanceEngineControlUnitWeightInGrams,
                  SCTPerformanceEngineControlUnitAccelerationBonus, SCTPerformanceEngineControlUnitTopSpeedBonus,
                  TunningGradeType.LowGrade)
        {
            this.EngineControlUnitType = EngineControlUnitType.Stock;
        }
    }
}
