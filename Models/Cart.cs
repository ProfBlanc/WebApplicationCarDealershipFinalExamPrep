using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCarDealershipFinalExamPrep.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }

        [Required]
        public string UUID {  get; set; }

        [ForeignKey("Store")]
        public int StoreID { get; set; }

        [ForeignKey("Car")]
        public int CarID { get; set; }
        public decimal Quantity { get; set; }


        [ValidateNever]
        public Store Store { get; set; }

        [ValidateNever]
        public Car Car { get; set; }

    }
}
