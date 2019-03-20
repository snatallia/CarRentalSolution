using System;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSolution.Models
{
    public partial class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string DriverLicenceNumber { get; set; }
    }
}
