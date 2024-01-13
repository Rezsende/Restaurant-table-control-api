using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurant_table_control_api.Entity;

namespace Restaurant_table_control_api.Context
{
    public class ContextData : DbContext
    {
        public ContextData(DbContextOptions<ContextData> options) : base(options)
        {

        }
        public DbSet<Client> Clients_Entity { get; set; }
        public DbSet<Command> Commands_Entity { get; set; }
        public DbSet<Product> Product_Entity { get; set; }
    }
}