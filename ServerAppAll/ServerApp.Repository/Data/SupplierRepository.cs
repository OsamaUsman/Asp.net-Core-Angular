using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp.Repository.Data
{
    public class SupplierRepository : Repository<Supplier, MartDbContext>
    {
        MartDbContext _context;
        public SupplierRepository(MartDbContext context) : base(context)
        {
            _context = context;
        }

    }
}
