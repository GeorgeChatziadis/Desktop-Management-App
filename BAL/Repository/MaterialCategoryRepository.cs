using DAL.Entities;
using BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class MaterialCategoryRepository : Repository
    {
        public MaterialCategoryRepository() : base() { }
        public MaterialCategoryRepository(Context context) : base(context) { }
        public List<MaterialCategoryModel> GetMaterialCategories()
        {
            using (var context = new Context())
            {
                var categories = context.MaterialCategories.Select(x => new MaterialCategoryModel
                {
                    Designation = x.Designation,
                    MaterialCategoryID = x.MaterialCategoriesID
                }).OrderBy(x => x.Designation).ToList();

                return categories;
            }
        }

        public void Save(List<MaterialCategoryModel> categories)
        {
            foreach (var item in categories)
            {
                if (item.MaterialCategoryID == null || item.MaterialCategoryID == Guid.Empty)
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
                var entity = context.MaterialCategories.Where(x => x.MaterialCategoriesID == categoryID).FirstOrDefault();
                context.MaterialCategories.Remove(entity);
                context.SaveChanges();
            }
        }
        void Create(MaterialCategoryModel category)
        {
            var entity = new MaterialCategories
            {
                Designation = category.Designation
            };

            using (var context = new Context())
            {
                context.MaterialCategories.Add(entity);
                context.SaveChanges();
            }
        }

        void Update(MaterialCategoryModel category)
        {
            using (var context = new Context())
            {
                var entity = context.MaterialCategories.Where(x => x.MaterialCategoriesID == category.MaterialCategoryID).FirstOrDefault();

                if (entity != null)
                {
                    entity.Designation = category.Designation;
                    context.SaveChanges();
                }
            }
        }

    }
}
