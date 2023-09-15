using BAL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class ProductCategoryRepository : Repository
    {
        public ProductCategoryRepository() : base() { }
        public ProductCategoryRepository(Context context) : base(context) { }

        public List<ProductCategoryModel> GetProductCategories()
        {
            using (var context = new Context())
            {
                var categories = context.ProductCategories.Select(x => new ProductCategoryModel
                {
                    Designation = x.Designation,
                    ProductCategoryID = x.ProductCategoriesID
                }).OrderBy(x => x.Designation).ToList();

                return categories;
            }
        }

        public void Save(List<ProductCategoryModel> categories)
        {
            foreach (var item in categories)
            {
                if (item.ProductCategoryID == null || item.ProductCategoryID == Guid.Empty)
                {
                    Create(item);
                }
                else
                {
                    Update(item);
                }
            }
        }
        public void Delete(Guid categoryID)
        {
            using (var context = new Context())
            {
                var entity = context.ProductCategories.Where(x => x.ProductCategoriesID == categoryID).FirstOrDefault();
                context.ProductCategories.Remove(entity);
                context.SaveChanges();
            }
        }
        void Create(ProductCategoryModel category)
        {
            var entity = new ProductCategories
            {
                Designation = category.Designation
            };

            using (var context = new Context())
            {
                context.ProductCategories.Add(entity);
                context.SaveChanges();
            }
        }

        void Update(ProductCategoryModel category)
        {
            using (var context = new Context())
            {
                var entity = context.ProductCategories.Where(x => x.ProductCategoriesID == category.ProductCategoryID).FirstOrDefault();

                if (entity != null)
                {
                    entity.Designation = category.Designation;
                    context.SaveChanges();
                }
            }
        }
    }
}
