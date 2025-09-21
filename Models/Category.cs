using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC_Machine_Test.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; } = string.Empty;

        // Make Products nullable
        public virtual ICollection<Product>? Products { get; set; }
    }
}