﻿using System;
using System.Collections.Generic;

namespace DataCape.Models
{
    public  class PaperCutModel
    {
        public PaperCutModel()
        {
            Products = new HashSet<ProductModel>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? StatedAt { get; set; }

        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
