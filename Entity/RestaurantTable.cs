using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.Entity
{
    public class RestaurantTable
    {
        public int Id {get; set;}
        public string? Description {get; set;}
        public ICollection<Command>? commands {get;set;} 

    }
}