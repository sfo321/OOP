namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;
    using FastAndFurious.ConsoleApplication.Common.Enums;

    public class MagnaflowExhaust : TunningPart, IExhaust
    {
        private const decimal Mprice = 379;
        private const int Mweight = 12800;
        private const int Macceleration = 5;
        private const int Mspeed = 25; 

        public ExhaustType ExhaustType { get; }

        public MagnaflowExhaust()
            : base(Mprice, Mweight, Macceleration, Mspeed, TunningGradeType.LowGrade)
        {
            this.ExhaustType = ExhaustType.NickelChromePlated;
        }
    }
}
