using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.Service.DTOs
{
    class PagenatedListDTO<T>
    {
        public PagenatedListDTO(IEnumerable<T> items, int pageIndex, int totalCount, int pageSize)
        {
            Items = items;
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
            HasNext = pageIndex < TotalPages;
            HasPrev = pageIndex > 1;
        }

        public IEnumerable<T> Items { get; }
        public int PageIndex { get; }
        public int TotalPages { get; }
        public bool HasNext { get; }
        public bool HasPrev { get; }
    }
}
