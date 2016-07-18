namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using Abstract;

    public class MitsubishiEclipse : MotorVehicle
    {
        private const decimal EclipsePrice = 29999;
        private const int EclipseWeight = 1400000;
        private const int EclipseTopSpeed = 230;
        private const int EclipseAcceleration = 24;

        public MitsubishiEclipse()
            : base(EclipsePrice, EclipseWeight, EclipseTopSpeed, EclipseAcceleration)
        {
        }
    }
}
