﻿using ProductStore.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Domain
{
   public class ProductFilter
    {
        public ProductType? ProductType { get; set; }

        public DateTime? ProductEndDate { get; set; }

        public string OwnerName { get; set; }

        public bool? ProductIsValid { get; set; }


    }
}
