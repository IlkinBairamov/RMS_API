using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    internal class StaffTypeRepository : Repository<StaffType>,IStaffTypeRepository
    {
        private readonly AppDbContext _context;

        public StaffTypeRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
