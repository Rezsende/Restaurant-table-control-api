using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.Entity
{
    public class Product
    {
        public int Id {get; set;}
        public string? Barcode {get; set;}
        public string? Desc {get; set;}
        public double? Purchase_Price {get; set;}
        public double? Sale_Price {get; set;}
        public int? Stock {get; set;}
        public DateTime? Expiration_Date {get;set;}

    }
}