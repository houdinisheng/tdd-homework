﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantApi.Models
{
    public class Product
    {
        public string Id { get; set; }
        public int Cost { get; set;}
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
