using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicPayment.Models.DTO
{
    public class PaymentStateDto
    {
        public PaymentStateEnum PaymentState { get; set; }
        public DateTime PaymentStateDate { get; set; }
    }
}
