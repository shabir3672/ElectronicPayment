using Microsoft.EntityFrameworkCore;

namespace ElectronicPayment.Models.Entity
{
    public class ElectronicPaymentContext : DbContext
    {
        public ElectronicPaymentContext(DbContextOptions<ElectronicPaymentContext> options) : base(options) 
        {   
        }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentState> PaymentStates { get; set; }
    }
}
