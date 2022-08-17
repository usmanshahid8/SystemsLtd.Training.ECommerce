using Microsoft.Extensions.Logging;
using SystemsLtd.Training.ECommerce.Repository;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Service.Interface
{
    public interface IProductService
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