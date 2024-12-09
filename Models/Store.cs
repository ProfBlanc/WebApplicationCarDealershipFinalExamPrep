using System.ComponentModel.DataAnnotations;

namespace WebApplicationCarDealershipFinalExamPrep.Models
{
    public class Store
    {
        [Key]
        public int StoreID {  get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
