﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Core.Models;

namespace Project.Repository.Context
{
    public class YurtDbContext : DbContext
    {
        public YurtDbContext(DbContextOptions<YurtDbContext> options): base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<IncomeDetail> IncomeDetails { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomIncome> RoomIncomes { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
