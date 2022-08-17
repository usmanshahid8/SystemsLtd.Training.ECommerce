using Microsoft.Extensions.Logging;
using SystemsLtd.Training.ECommerce.Repository;
using SystemsLtd.Training.ECommerce.Service.Interface;
using SystemsLtd.Training.ECommerce.Repository.Interface;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Service
{
    public class ProductService : IProductService
    {
        #region Properties
        private readonly ILogger<ProductService> Logger;
        private readonly IProductRepositiory ProductRepository;
        #endregion

        #region Constructor
        public ProductService(ILogger<ProductService> logger, IProductRepositiory productRepository)
        {
            Logger = logger;
            this.ProductRepository = productRepository;
        }
        #endregion


        #region public method
        public IEnumerable<Product> GetProducts()
        {
            return this.ProductRepository.GetProducts();
        }

        public IEnumerable<Product> GetAllProducts(Product product)
        {
            return this.ProductRepository.GetAllProducts(product);
        }

        public Product GetProduct(int id)
        {
            return this.ProductRepository.GetProduct(id);
        }

        public int AddProduct(Product product)
        {
            return this.ProductRepository.AddProduct(product);
        }

        public bool UpdateProduct(Product product)
        {
            return this.ProductRepository.UpdateProduct(product);
        }

        public bool DeleteProduct(Product product)
        {
            return this.ProductRepository.DeleteProduct(product);
        }
        #endregion
    }
}