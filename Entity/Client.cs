using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.Entity
{
    public class Client
    {
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? surname { get; set; }

        public string? CPF { get; set; }

        public string? RG { get; set; }

        public string? Uf { get; set; }

        public string? City { get; set; }

        public string? Neighborhood { get; set; }

        public string? Road { get; set; }

        public string? Number { get; set; }
        public string? Complement { get; set; }
    }
}