using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    internal class TableStatusRepository : Repository<TableStatus>,ITableStatusRepository
    {
        private readonly AppDbContext _context;

        public TableStatusRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
