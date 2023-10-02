﻿namespace DataCape.Models
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            QuotationClientDetails = new List<QuotationClientDetailModel>();
            Supplies = new List<SupplyXProductModel>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string TypeProduct { get; set; } = null!;
        public long? PaperCutId { get; set; }
        public decimal? Cost { get; set; }
        public string? Observations { get; set; }
        public bool? StatedAt { get; set; }
        public string Size { get; set; } = null!;
        public bool? FrontPage { get; set; }
        public bool? FrontPageInks { get; set; }
        public string? FrontPageNumberInks { get; set; }
        public string? FrontPagePantone { get; set; }
        public string? FrontPageCode { get; set; }
        public bool? BackCover { get; set; }
        public bool? BackCoverInks { get; set; }
        public string? BackCoverNumberInks { get; set; }
        public string? BackCoverPantone { get; set; }
        public string? BackCoverCode { get; set; }
        public bool? Inside { get; set; }
        public bool? InsideInks { get; set; }
        public string? InsideNumberInks { get; set; }
        public string? InsidePantone { get; set; }
        public string? InsideCode { get; set; }
        public long? NumberPages { get; set; }
        public string? Cover { get; set; }
        public string? Bindings { get; set; }
        public string? Dimension { get; set; }
        public string? SubstratumFrontPage { get; set; }
        public string? SubstratumInside { get; set; }
        public string? Substratum { get; set; }

        public virtual PaperCutModel? PaperCut { get; set; }
        public virtual List<QuotationClientDetailModel> QuotationClientDetails { get; set; }
        public virtual List<SupplyXProductModel> Supplies { get; set; }
    }
}
