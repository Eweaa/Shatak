using System.ComponentModel.DataAnnotations;

namespace Shatak.CoreLayer.Models
{
    public class Address : BaseEntity
    {
        [Required]
        public string City { get; set; }
        [Required]
        public string Neighborhood { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public int BuildingNumber { get; set; }
        [Required]
        public int ApartmentNumber { get; set; }

    }
}
