using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.Entity
{
    [Table("Table_client")]
    public class Client
    {
        public int Id {get; set;}
        [MinLength(3)]
        public string? Name {get; set;}
        [MinLength(3)]
        public string? surname {get; set;}
        [Required]
        [MaxLength(11)]
        public string? CPF {get; set;}
        [MaxLength(11)]
        public string? RG {get; set;}
        [MaxLength(2)]
        public string? Uf {get; set;}
        [MinLength(3)]
        public string? City {get; set;}
        [MinLength(3)]
        public string? Neighborhood {get; set;}
        [MinLength(6)]
        public string? Road {get; set;}
        [MaxLength(6)]
        public string? Number {get; set;}
        [MaxLength(20)]
        public string? Complement {get; set;}
    }
}