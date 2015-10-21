using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.Repository.Domain
{
    public class Customer : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int Balance { get; set; }
    }
}
