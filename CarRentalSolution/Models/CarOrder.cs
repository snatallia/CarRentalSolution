using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSolution.Models
{
    public partial class CarOrder
    {
        [Key]
        public int CarOrderId { get; set; }
        public int CarId { get; set; }
        public int ClientId { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
    }
}
