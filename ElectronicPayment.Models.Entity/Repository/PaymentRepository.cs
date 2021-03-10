using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPayment.Models.Entity.Repository
{
    public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
    {
        public PaymentRepository(ElectronicPaymentContext dbContext) : base(dbContext)
        {

        }
        public override async Task<Payment> GetById(long id)
        {
            return await _dbContext.Set<Payment>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.PaymentId == id);
        }
    }
}
