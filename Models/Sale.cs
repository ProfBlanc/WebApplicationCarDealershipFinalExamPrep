using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCarDealershipFinalExamPrep.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        [ForeignKey("PaymentInfo")]
        public int PaymentInfoID { get; set; }

        public decimal TotalPrice { get; set; }

        [ValidateNever]
        public PaymentInfo PaymentInfo { get; set; }


    }
}
