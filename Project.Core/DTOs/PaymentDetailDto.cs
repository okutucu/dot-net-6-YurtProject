﻿using Project.Core.Enums;

namespace Project.Core.DTOs
{
	public class PaymentDetailDto : BaseDto
	{
		public PaymentName PaymentName { get; set; }
		public decimal Price { get; set; }
		public Exchange Exchange { get; set; }
		public DateTime PaymentDate { get; set; }
		public decimal MoneyOfTheDay { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public string Description { get; set; }
	}
}
