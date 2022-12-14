using System.ComponentModel.DataAnnotations;

namespace SystemsLtd.Training.ECommerce.API.Models
{
    public class ProductUpdateVM
    {
        #region Properties

        [Required]
        [Range(1, int.MaxValue)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int CategoryID { get; set; }
        public bool Active { get; set; }

        #endregion
    }
}
