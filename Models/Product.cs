using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC_Machine_Test.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(150)]
        public string ProductName { get; set; } = string.Empty;

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        // Make Category nullable
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}