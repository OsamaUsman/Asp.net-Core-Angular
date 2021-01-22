using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerApp.Repository.Data
{
    public class RatingRepository : Repository<Rating, MartDbContext>
    {
        MartDbContext _context;
        public RatingRepository(MartDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
