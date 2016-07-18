namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using Abstract;

    public class MitsubishiLancerEvolution : MotorVehicle
    {
        private const decimal LancerPrice = 56999;
        private const int LancerWeight = 1780000;
        private const int LancerTopSpeed = 300;
        private const int LancerAcceleration = 20;

        public MitsubishiLancerEvolution()
            : base(LancerPrice, LancerWeight, LancerTopSpeed, LancerAcceleration)
        {
        }
    }
}
