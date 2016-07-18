namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using Abstract;

    public class NissanSkylineR34 : MotorVehicle
    {
        private const decimal SkylinePrice = 45999;
        private const int SkylineWeight = 1850000;
        private const int SkylineTopSpeed = 280;
        private const int SkylineAcceleration = 50;

        public NissanSkylineR34()
            : base(SkylinePrice, SkylineWeight, SkylineTopSpeed, SkylineAcceleration)
        {
        }
    }
}