﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class CustomerImageFile : File
    {
        public IList<Customer> Customers { get; set; }
    }
}
