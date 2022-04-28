using RMS.Core.Entities;
using RMS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Data.Repositories
{
    internal class ProductDepoRepository : Repository<ProductDepo>,IProductDepoRepository
    {
        private readonly AppDbContext _context;

        public ProductDepoRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
