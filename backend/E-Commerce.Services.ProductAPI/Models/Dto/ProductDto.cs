using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Services.ProductAPI.Models.Dto
{
    public class ProductDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public double new_price { get; set; }
        public string old_price { get; set; }
        public string category { get; set; }
        public string image { get; set; }
    }
}
