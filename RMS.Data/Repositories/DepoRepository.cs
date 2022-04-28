using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    class DepoRepository : Repository<Depo>, IDepoRepository
    {
        private readonly AppDbContext _context;

        public DepoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
