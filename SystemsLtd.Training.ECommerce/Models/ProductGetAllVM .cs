using System.ComponentModel.DataAnnotations;

namespace SystemsLtd.Training.ECommerce.API.Models
{
    public class ProductGetAllVM
    {
        [Required]
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public bool Active { get; set; }
    }
}
