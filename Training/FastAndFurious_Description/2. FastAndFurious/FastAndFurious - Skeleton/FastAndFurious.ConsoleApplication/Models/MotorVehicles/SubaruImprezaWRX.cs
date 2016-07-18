namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using Abstract;

    public class SubaruImprezaWRX : MotorVehicle
    {
        private const decimal SubaruPrice = 55999;
        private const int SubaruWeight = 1560000;
        private const int SubaruTopSpeed = 260;
        private const int SubaruAcceleration = 35;

        public SubaruImprezaWRX()
            : base(SubaruPrice, SubaruWeight, SubaruTopSpeed, SubaruAcceleration)
        {
        }
    }
}