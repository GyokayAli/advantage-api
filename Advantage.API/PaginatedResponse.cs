using System.Collections.Generic;
using System.Linq;
using Advantage.API.Models;

namespace Advantage.API
{
    internal class PaginatedResponse<T>
    {
        public IEnumerable<Order> Data { get; set; }
        public int Total { get; set; }

        public PaginatedResponse(IEnumerable<Order> data, int pageIndex, int pageSize)
        {
            Data = data.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            Total = data.Count();
        }
    }
}