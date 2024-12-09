using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCarDealershipFinalExamPrep.Models
{
    public class PaymentInfo
    {
        [Key]
        public int PaymentTypeID { get; set; }

        [ForeignKey("IdentityUser")]
        public string UserID{ get; set; } = string.Empty;

        public string CardNumber { get; set; } = string.Empty;

        [ValidateNever]
        public IdentityUser IdentityUser { get; set; }

    }
}
