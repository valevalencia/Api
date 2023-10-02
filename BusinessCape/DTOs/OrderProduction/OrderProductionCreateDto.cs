﻿using System;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BusinessCape.DTOs.OrderProduction
{
    public class OrderProductionCreateDto
    {
        public long? QuotationClientDetailId { get; set; }
        public long? UserId { get; set; }
        public string? MaterialReception { get; set; }
        public string? Program { get; set; }
        public string? ProgramVersion { get; set; }
        public double? Indented { get; set; }
        public string? Lineature { get; set; }
        public string? ColorProfile { get; set; }
        public string? TypePoint { get; set; }
        public string? Observations { get; set; }
        public string? Image { get; set; }
        public string? Scheme { get; set; }
        public long? ImpositionPlanchId { get; set; }
        public long? MachineId { get; set; }
        public int? OrderStatus { get; set; }
        public bool StatedAt { get; set; }
        public IFormFile? SchemeInfo { get; set; } = null!;
        public IFormFile? ImageInfo { get; set; } = null!;
    }
}
