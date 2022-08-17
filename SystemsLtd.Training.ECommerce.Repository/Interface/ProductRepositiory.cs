using Microsoft.Extensions.Logging;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Repository.Interface
{
        public interface IProductRepositiory
        {
        #region public method
        IEnumerable<Product> GetProducts();

        IEnumerable<Product> GetAllProducts(Product product);

        Product GetProduct(int id);

        int AddProduct(Product product);

        bool UpdateProduct(Product product);

        bool DeleteProduct(Product product);
        #endregion
    }
}