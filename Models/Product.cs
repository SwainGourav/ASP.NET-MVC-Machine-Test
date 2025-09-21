using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace ASP.NET_MVC_Machine_Test.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
