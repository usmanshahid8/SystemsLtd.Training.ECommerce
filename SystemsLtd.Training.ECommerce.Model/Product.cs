using System.ComponentModel.DataAnnotations;

namespace SystemsLtd.Training.ECommerce.Model
{
    public class Product
    {
        #region Properties
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int CategoryID { get; set; }
        public bool Active { get; set; }
        #endregion

        #region Constructor
        public Product()
        {

        }
        #endregion

        #region public method
        
        #endregion
    }
}
