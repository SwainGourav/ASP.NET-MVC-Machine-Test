using System.Collections.Generic;

namespace ASP.NET_MVC_Machine_Test.ViewModels
{
    public class ProductListViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }

    public class PagedProductList
    {
        public List<ProductListViewModel> Products { get; set; } = new List<ProductListViewModel>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
    }
}