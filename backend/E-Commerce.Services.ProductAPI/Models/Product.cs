using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public double new_price { get; set; }
        public double old_price { get; set; }
        public string category { get; set; }
        public string image { get; set; }
    }
}
