using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.DTO
{
    public class ProductDatailDTO_post
    {
        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public int? Qtd { get; set; }
        public double? Sale_Price { get; set; }
        public DateTime? DataSales { get; set; }
        public int? ProductId { get; set; }
        public int? commandId { get; set; }
    }
}