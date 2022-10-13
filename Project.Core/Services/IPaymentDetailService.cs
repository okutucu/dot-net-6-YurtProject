using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.DTOs;
using Project.Core.Models;

namespace Project.Core.Services
{
    public interface IPaymentDetailService : IService<PaymentDetail>
    {
        Task AddByCurrency(PaymentDetailDto paymentDetailDto, decimal currency);
        Task UpdateByCurrency(PaymentDetailDto paymentDetailDto, decimal currency);
    }
}
