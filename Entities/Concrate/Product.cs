﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CatagoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
