namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;
    using FastAndFurious.ConsoleApplication.Common.Enums;

    public class RemusExhaust : TunningPart, IExhaust
    {
        private const decimal Rprice = 679;
        private const int Rweight = 11500;
        private const int Racceleration = 8; 
        private const int Rspeed = 32;

        public ExhaustType ExhaustType { get; }

        public RemusExhaust()
            : base(Rprice, Rweight, Racceleration, Rspeed, TunningGradeType.MidGrade)
        {
            this.ExhaustType = ExhaustType.StainlessSteel;
        }
    }
}
