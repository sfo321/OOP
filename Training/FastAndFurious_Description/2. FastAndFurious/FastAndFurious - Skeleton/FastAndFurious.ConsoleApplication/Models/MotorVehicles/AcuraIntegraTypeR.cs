namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using Abstract;

    public class AcuraIntegraTypeR : MotorVehicle
    {
        private const decimal AcuraPrice = 24999;
        private const int AcuraWeight = 1700000;
        private const int AcuraTopSpeed = 200;
        private const int AcuraAcceleration = 15;

        public AcuraIntegraTypeR()
            : base(AcuraPrice, AcuraWeight, AcuraTopSpeed, AcuraAcceleration)
        {
        }
    }
}
