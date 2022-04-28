using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    internal class PurchaseRepository : Repository<Purchase>,IPurchaseRepository
    {
        private readonly AppDbContext _context;

        public PurchaseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
