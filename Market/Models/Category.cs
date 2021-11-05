﻿using System.Collections.Generic;

namespace Market.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}