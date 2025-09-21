using ASP.NET_MVC_Machine_Test.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace ASP.NET_MVC_Machine_Test.Services
{
    public static class PaginationService
    {
        public static PagedProductList GetPagedProducts(List<ProductListViewModel> products, int page, int pageSize = 10)
        {
            var totalCount = products.Count;
            var pagedProducts = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            var totalPages = (int)System.Math.Ceiling(totalCount / (double)pageSize);

            return new PagedProductList
            {
                Products = pagedProducts,
                CurrentPage = page,
                TotalPages = totalPages,
                PageSize = pageSize,
                TotalCount = totalCount
            };
        }
    }
}