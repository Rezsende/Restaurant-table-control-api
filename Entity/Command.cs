using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant_table_control_api.Entity
{
    public class Command
    {
        public int Id {get; set;}
        public string Description {get; set;}

        public TableM Tables {get; set;}
        public int TablesId {get; set;}

    }
}