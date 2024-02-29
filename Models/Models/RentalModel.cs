using System.ComponentModel.DataAnnotations;

namespace Shared.Models
{
    public class RentalModel
    {
        [Key]
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsRented { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public string ImageUrl { get; set; }

    }
}
