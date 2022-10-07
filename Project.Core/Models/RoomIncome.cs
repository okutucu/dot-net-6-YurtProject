﻿namespace Project.Core.Models
{
    public class RoomIncome : BaseEntity
    {
        public string Exchange { get; set; }
        public decimal Price { get; set; }
        public double MoneyOfTheDay { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }

        public int? RoomId { get; set; }

        // Relational Properties

        public virtual Room Room { get; set; }

    }
}
