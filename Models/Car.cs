using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCarDealershipFinalExamPrep.Models
{
    public class Car
    {
        public void Test() { }
        [Key]
        public int CarID { get; set; }

        [NotMapped]
        public IFormFile PhotoUpload { get; set; }

        [ValidateNever]
        public string Photo { get; set; }

        [Required]
        public string Make { get; set; } = string.Empty;

        [Required]
        public string Model { get; set; } = string.Empty;

        [Required]
        public short Year { get; set; }

        [Required]
        public string Condition { get; set; } = string.Empty;

        [Required]
        public int Mileage { get; set; }

        [Required]
        [Range(1000, 250000)]
        public decimal Price { get; set; }

        

    }
}
