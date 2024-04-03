using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.Entity
{
    public class ProductDetail
    {
        public int Id { get; set; }
        
        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public int? Qtd { get; set; }
        public double? Sale_Price { get; set; }
        public DateTime? DataSales { get; set; }

    
      
    }
}