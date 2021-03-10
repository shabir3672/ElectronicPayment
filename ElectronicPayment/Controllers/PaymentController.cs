using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ElectronicPayment.Models.DTO;
using ElectronicPayment.Services;

namespace ElectronicPayment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService, ILogger<PaymentController> logger)
        {
            _logger = logger;
            _paymentService = paymentService;
        }

        [HttpGet]
        public string Get()
        {
            return "ProcessPayment";
        }


        [HttpPost]        
        public async Task<IActionResult> Post(PaymentRequestDto paymentRequest)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var paymentState = await _paymentService.ProcessPayment(paymentRequest);

                    var paymentResponse = new PaymentResponseDto()
                    {
                        IsProcessed = paymentState.PaymentState == PaymentStateEnum.Processed,
                        PaymentState = paymentState
                    };

                    if (!paymentResponse.IsProcessed)
                    {
                        return StatusCode(500, new { error = "Payment could not be processed" });
                    }
                    else
                    {
                        return Ok(paymentResponse);
                    }
                }
                else
                    return BadRequest(ModelState);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return StatusCode(500);
            }
        }
    }
}