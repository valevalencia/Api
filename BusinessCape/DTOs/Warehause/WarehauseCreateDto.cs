﻿using DataCape.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessCape.DTOs.Warehause
{
    public class WarehauseCreateDto
    {
        public long? TypeServiceId { get; set; }
        public string? Ubication { get; set; }
        public bool? StatedAt { get; set; }
        public WarehauseCreateDto()
        {
            StatedAt = true;
        }
    

    }
}
