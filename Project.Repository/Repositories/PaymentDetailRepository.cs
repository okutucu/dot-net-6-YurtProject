﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Models;
using Project.Core.Repositories;
using Project.Repository.Context;

namespace Project.Repository.Repositories
{
    public class PaymentDetailRepository : GenericRepository<PaymentDetail>, IPaymentDetailRepository
    {
        public PaymentDetailRepository(YurtDbContext context) : base(context)
        {
        }
    }
}