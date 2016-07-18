namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract;
    using FastAndFurious.ConsoleApplication.Common.Enums;

    public class BorlaExhaust : TunningPart, IExhaust
    {
        private const decimal Bprice = 1299;
        private const int Bweight = 14600;
        private const int Bacceleration = 12;
        private const int Bspeed = 40;

        public ExhaustType ExhaustType { get; }
       
        public BorlaExhaust() 
            : base(Bprice, Bweight, Bacceleration, Bspeed, TunningGradeType.HighGrade)
        {
            this.ExhaustType = ExhaustType.CeramicCoated;
        }
    }
}
