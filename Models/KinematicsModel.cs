using System.ComponentModel.DataAnnotations;

namespace PhysicsVSC.Models
{
    public class KinematicsModel
    {
        [Required(ErrorMessage = "Initial Velocity is required.")]
        public double? InitialVelocity { get; set; }

        [Required(ErrorMessage = "Acceleration is required.")]
        public double? Acceleration { get; set; }

        [Required(ErrorMessage = "Time is required.")]
        public double? Time { get; set; }

        public double? FinalVelocity { get; set; }

        public void CalculateFinalVelocity()
        {
            if (InitialVelocity.HasValue && Acceleration.HasValue && Time.HasValue)
            {
                FinalVelocity = InitialVelocity.Value + (Acceleration.Value * Time.Value);
            }
            else
            {
                FinalVelocity = null;
            }
        }
    }
}
