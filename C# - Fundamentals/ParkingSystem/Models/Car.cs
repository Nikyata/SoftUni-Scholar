using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace ParkingSystem.Models
{
    public class Car
    {
        [Required]
        public string Owner { get; set; }
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string PlateNumber { get; set; }

        [Required]
        public string ParkingSpaceNum { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public int Paid { get; set; }

        [Required]
        public int TimeLeft { get; set; }
    }

    }
