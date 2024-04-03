using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.Identity.Client;

namespace Restaurant_table_control_api.Entity
{
    public class Command
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        [JsonIgnore]
        public RestaurantTable? restaurantTable { get; set; }
       

    }
}