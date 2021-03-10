using ElectronicPayment.Models.DTO;
using ElectronicPayment.Models.Entity;

namespace ElectronicProcessor.Services.Profile
{
    public class PaymentStateProfile : AutoMapper.Profile
    {
        public PaymentStateProfile()
        {
            CreateMap<PaymentStateDto, PaymentState>()
                .ForMember(dest => dest.Payment, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentId, opt => opt.Ignore())
                .ForMember(dest => dest.PaymentStateId, opt => opt.Ignore())
                .ForMember(dest => dest.State, opt => opt.MapFrom(src => src.PaymentState.ToString()))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.PaymentStateDate))
                .ReverseMap()
                ;
        }
    }
}
