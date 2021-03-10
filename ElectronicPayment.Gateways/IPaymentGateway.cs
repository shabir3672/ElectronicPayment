using ElectronicPayment.Models.DTO;

namespace ElectronicPayment.Gateways
{
    public interface IPaymentGateway
    {
        PaymentStateDto ProcessPayment(PaymentRequestDto paymentRequest);
    }
}
