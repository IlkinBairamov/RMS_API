using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    internal class StaffRepository : Repository<Staff>, IStaffRepository
    {
        private readonly AppDbContext _context;

        public StaffRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
