﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ApplicationCore.Entity
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
