using Microsoft.AspNetCore.Mvc;
using SystemsLtd.Training.ECommerce.API.Models;
using SystemsLtd.Training.ECommerce.Model;
using SystemsLtd.Training.ECommerce.Service;
using SystemsLtd.Training.ECommerce.Service.Interface;

namespace SystemsLtd.Training.ECommerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        #region Properties
        private readonly ILogger<ProductController> Logger;
        private readonly IProductService ProductService;
        #endregion

        #region Constructor
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            this.Logger = logger;
            this.ProductService = productService;
        }
        #endregion

        #region public method
        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> GetProducts()
        {
            return this.ProductService.GetProducts();
        }

        [HttpGet(Name = "GetAllProducts")]
        public IEnumerable<Product> GetAllProducts([FromQuery] ProductGetAllVM productVM)
        {
            var product = new Product
            {
                CategoryID = productVM.CategoryID,
                ProductName = productVM.ProductName,
                Active = productVM.Active
            };
            return this.ProductService.GetAllProducts(product);
        }

        [HttpGet(Name = "GetProduct")]
        public Product GetProduct(int id)
        {
            return this.ProductService.GetProduct(id);
        }

        [HttpPost(Name = "AddProduct")]
        public int AddProduct([FromBody] ProductAddVM productVM)
        {
            var product = new Product
            {
                CategoryID = productVM.CategoryID,
                ProductName = productVM.ProductName,
                ProductDescription = productVM.ProductDescription,
                SalesPrice = productVM.SalesPrice,
                PurchasePrice = productVM.PurchasePrice,
                Active = productVM.Active
            };

            return this.ProductService.AddProduct(product);
        }

        [HttpPut(Name = "UpdateProduct")]
        public bool UpdateProduct([FromBody] ProductUpdateVM productVM)
        {
            var product = new Product
            {
                ProductId = productVM.ProductId,
                CategoryID = productVM.CategoryID,
                ProductName = productVM.ProductName,
                ProductDescription = productVM.ProductDescription,
                SalesPrice = productVM.SalesPrice,
                PurchasePrice = productVM.PurchasePrice,
                Active = productVM.Active
            };

            return this.ProductService.UpdateProduct(product);
        }

        [HttpDelete(Name = "DeleteProduct")]
        public bool DeleteProduct([FromBody] ProductDeleteVM productVM)
        {
            var product = new Product
            {
                ProductId = productVM.ProductId
            };

            return this.ProductService.DeleteProduct(product);
        }
        #endregion
    }
}