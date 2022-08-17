using Microsoft.Extensions.Logging;
using SystemsLtd.Training.ECommerce.Repository.Interface;
using SystemsLtd.Training.ECommerce.Model;

namespace SystemsLtd.Training.ECommerce.Repository
{
        public class ProductRepositiory : IProductRepositiory
        {
            #region Properties
            private readonly ILogger<ProductRepositiory> Logger;
            private readonly ECommerceDBContext ECommerceDBContext;
            private static List<Product> Products = new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Dell Laptop",
                    ProductDescription =  "Dell Laptop E6418",
                    PurchasePrice = 1000.50m,
                    SalesPrice = 1200.50m,
                    Active = true,
                    CategoryID = 1
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "Hp Laptop",
                    ProductDescription =  "HP Laptop E6418",
                    PurchasePrice = 1000.50m,
                    SalesPrice = 1200.50m,
                    Active = true,
                    CategoryID = 1
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Apple Laptop",
                    ProductDescription =  "Apple Laptop E6418",
                    PurchasePrice = 1000.50m,
                    SalesPrice = 1200.50m,
                    Active = true,
                    CategoryID = 1
                }
            };
        #endregion

            #region Constructor
            public ProductRepositiory(ILogger<ProductRepositiory> logger, ECommerceDBContext eCommercedbContext)
            {
                this.Logger = logger;
                this.ECommerceDBContext = eCommercedbContext;
            }
            #endregion


            #region public method
            public IEnumerable<Product> GetProducts()
            {
                return ProductRepositiory.Products;
            }

            public IEnumerable<Product> GetAllProducts(Product product)
            {
                var products = ProductRepositiory.Products;
                if(product != null)
                {
                    if (!string.IsNullOrWhiteSpace(product.ProductName))
                    {
                        products = products.Where(x => x.ProductName.Equals(product.ProductName, StringComparison.CurrentCulture)).ToList();
                    }
                    if (product.CategoryID > 0)
                    {
                        products = products.Where(x => x.CategoryID == product.CategoryID).ToList();
                    }

                    products = products.Where(x => x.Active == product.Active).ToList();
                }
                return products;
            }
            
            public Product GetProduct(int id)
            {
            //return ProductRepositiory.Products.FirstOrDefault(x => x.ProductId == id);
                return this.ECommerceDBContext.Products.ToList();
            }

            public int AddProduct(Product product)
            { 
                product.ProductId = ProductRepositiory.Products.Count() + 1;
                ProductRepositiory.Products.Add(product);
                return product.ProductId;
            }

            public bool UpdateProduct(Product product)
            {
                var existingProduct = this.GetProduct(product.ProductId);
                if(existingProduct != null)
                {
                    existingProduct.ProductName = product.ProductName;
                    existingProduct.ProductDescription = product.ProductDescription;
                    existingProduct.PurchasePrice = product.PurchasePrice;
                    existingProduct.SalesPrice = product.SalesPrice;
                    existingProduct.Active = product.Active;
                    existingProduct.CategoryID = product.CategoryID;
                    return true;
                }
                else
                    return false;
            }

            public bool DeleteProduct(Product product)
            {
                var exisitingProduct = this.GetProduct(product.ProductId);
                return ProductRepositiory.Products.Remove(exisitingProduct);
            }
        #endregion
    }
}