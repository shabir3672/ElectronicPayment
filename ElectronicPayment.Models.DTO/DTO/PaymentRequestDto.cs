using ElectronicPayment.Models.DTO.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace ElectronicPayment.Models.DTO
{
    public class PaymentRequestDto
    {
        [Required]
        [CreditCard]
        public string CreditCardNumber { get; set; }
        [Required]
        public string CardHolder { get; set; }
        [Required]
        [PastDateValidation]
        public DateTime ExpirationDate { get; set; }

        [StringLength(maximumLength: 3, MinimumLength =3)]
        public string SecurityCode { get; set; }
        [Required]
        [Range(0, double.MaxValue)]
        public decimal Amount { get; set; }

    }
}
