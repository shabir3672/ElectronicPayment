using ElectronicPayment.Models.DTO;
using System.Threading.Tasks;

namespace ElectronicPayment.Services
{
    public interface IPaymentService
    {
        Task<PaymentStateDto> ProcessPayment(PaymentRequestDto paymentRequestDto);
    }
}