using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicPayment.Models.Entity.Repository
{
    public class PaymentStateRepository : GenericRepository<PaymentState>, IPaymentStateRepository
    {
        public PaymentStateRepository(ElectronicPaymentContext dbContext) : base(dbContext)
        {

        }
        public override async Task<PaymentState> GetById(long id)
        {
            return await _dbContext.Set<PaymentState>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.PaymentId == id);
        }
    }
}
