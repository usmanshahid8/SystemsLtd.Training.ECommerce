using System.ComponentModel.DataAnnotations;

namespace SystemsLtd.Training.ECommerce.API.Models
{
    public class ProductDeleteVM
    {
        [Required]
        [Range(1, int.MaxValue)]
        public int ProductId { get; set; }
    }
}
