﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCape.DTOs.PaperCut
{
    public class PaperCutUpdateDto
    {

        public long Id { get; set; }
        public string Name { get; set; } = null!;

        //public virtual ICollection<OrderProductionModel> OrderProductions { get; set; }

    }
}
