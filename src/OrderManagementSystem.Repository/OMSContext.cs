using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagementSystem.Repository.Domain;

namespace OrderManagementSystem.Repository
{
    public class OMSContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
