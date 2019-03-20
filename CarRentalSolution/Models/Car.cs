using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSolution.Models
{
    public partial class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string CarClass { get; set; }
        public int? LaunchYear { get; set; }
    }
}
