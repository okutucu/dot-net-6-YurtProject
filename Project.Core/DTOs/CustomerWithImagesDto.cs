using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Project.Core.Models;

namespace Project.Core.DTOs
{
    public class CustomerWithImagesDto 
    {
        public string FullName { get; set; }
        public string IdentityNo { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime Depart { get; set; }
        public string RelativeNameSurname { get; set; }
        public string RelativePhone { get; set; }
        public string UniversityName { get; set; }
        public string Description { get; set; }
        public bool DownPayment { get; set; }
        public decimal DownPaymentPrice { get; set; }
        public bool Discount { get; set; }
        public decimal DiscountPrice { get; set; }
        public List<Image> Images { get; set; }
    }
}
