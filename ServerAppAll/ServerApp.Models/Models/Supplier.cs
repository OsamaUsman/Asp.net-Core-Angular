using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp.Models
{
    public class Supplier : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
