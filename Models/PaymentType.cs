using System.ComponentModel.DataAnnotations;

namespace WebApplicationCarDealershipFinalExamPrep.Models
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeID { get; set; }
        
        [Required]
        public string CardType { get; set;} = string.Empty;


    }
}
