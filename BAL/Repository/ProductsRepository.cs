using DAL.Entities;
using BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class ProductsRepository : Repository
    {
        public ProductsRepository() : base() { }
        public ProductsRepository(Context context) : base(context) { }

        public List<ProductModel> GetProducts()
        {
            using(var context = new Context())
            {
                var products = context.Product.Select(x => new ProductModel
                {
                    Designation = x.Designation,
                    ProductID = x.ProductID,
                    ProductCategoryID = x.ProductCategoriesID,
                    Price = x.Price
                }).ToList();

                return products;
            }
        }

        public void Save(List<ProductModel> products)
        {
            bool newItems = false;
            foreach (var item in products)
            {
                if (item.ProductID == null || item.ProductID == Guid.Empty)
                {
                    Create(item);
                    newItems = true;
                }
                else
                {
                    Update(item);
                }
            }

            if (newItems == true) //Bool για να καταλαβαίνω άν εχει νέα προϊόντα για να περάσει τη μέθοδο.
            {
                CreateInventory();
            }
        }

        public void Delete(Guid productID)
        {
            using (var context = new Context())
            {
                var productEntity = context.Product.Where(x => x.ProductID == productID).FirstOrDefault();
                var inventoryEntity = context.Inventory.Where(x => x.ProductID == productID).FirstOrDefault(); //Διαγράφω και το αντίστοιχο Inventory
                context.Inventory.Remove(inventoryEntity);
                context.Product.Remove(productEntity);
                context.SaveChanges();
            }
        }
        
        void Create(ProductModel product)
        {
            var entity = new Product
            {
                Designation = product.Designation,
                ProductCategoriesID = product.ProductCategoryID,
                Price = product.Price
            };

            using (var context = new Context())
            {
                context.Product.Add(entity);
                context.SaveChanges();
            }
        }

        void CreateInventory() //Με το που κάνει register ένα νέο Product βάζω εγγραφή και στον Inventory πίνακα
        {
            using (var context = new Context())
            {
                var products = context.Product.ToList();
                var inventory = context.Inventory.ToList();
                foreach (var item in products)
                {
                    if (inventory.Any(x => x.ProductID == item.ProductID))
                    {
                        continue;
                    }

                    var entity = new Inventory
                    {
                        ProductID = item.ProductID,
                        Quantity = 0,
                        QuantityForOrders = 0
                    };

                    context.Inventory.Add(entity);
                    context.SaveChanges();
                }
            }
        }

        void Update(ProductModel product)
        {
            using (var context = new Context())
            {
                var entity = context.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();

                if (entity != null)
                {
                    entity.Designation = product.Designation;
                    entity.ProductCategoriesID = product.ProductCategoryID;
                    entity.Price = product.Price;
                    context.SaveChanges();
                }
            }
        }
    }
}
