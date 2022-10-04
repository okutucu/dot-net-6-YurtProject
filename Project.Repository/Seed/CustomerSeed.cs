using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Core.Models;

namespace Project.Repository.Seed
{
    internal class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer { Id=1, FullName="Oğuzhan Kutucu",IdentityNo="1234567",Phone="05353073235",Email="o@kutucu.com",EntryDate=DateTime.Now,RelativeNameSurname="Kaan Kutucu",RelativePhone="5555555",Description="UK",CreatedDate=DateTime.Now,UpdatedDate=DateTime.Now,RoomId=1},
                 new Customer { Id = 1, FullName = "Kaan Kutucu", IdentityNo = "12345267", Phone = "5555555", Email = "k@kutucu.com", EntryDate = DateTime.Now, RelativeNameSurname = "Oğuzhan Kutucu", RelativePhone = "05353073235", Description = "UK", CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now, RoomId = 1 }
                );
        }
    }
}
