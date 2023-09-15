using BAL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class MaterialRepository : Repository
    {
        public MaterialRepository() : base() { }
        public MaterialRepository(Context context) : base(context) { }

        public List<MaterialModel> GetMaterials()
        {
            using (var context = new Context())
            {
                var materials = context.Material.Select(x => new MaterialModel
                {
                    Designation = x.Designation,
                    MaterialID = x.MaterialID,
                    MaterialCategoryID = x.MaterialCategoryID
                }).ToList();

                return materials;
            }
        }

        public void Save(List<MaterialModel> materials)
        {
            bool newItems = false;
            foreach (var item in materials)
            {
                if (item.MaterialID == null || item.MaterialID == Guid.Empty)
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

        public void Delete(Guid materialID)
        {
            using (var context = new Context())
            {
                var materialEntity = context.Material.Where(x => x.MaterialID == materialID).FirstOrDefault();
                var inventoryEntity = context.Inventory.Where(x => x.MaterialID == materialID).FirstOrDefault(); //Διαγράφω και το αντίστοιχο Inventory
                context.Inventory.Remove(inventoryEntity);
                context.Material.Remove(materialEntity);
                context.SaveChanges();
            }
        }

        void Create(MaterialModel material)
        {
            var entity = new Material
            {
                Designation = material.Designation,
                MaterialCategoryID = material.MaterialCategoryID
            };

            using (var context = new Context())
            {
                context.Material.Add(entity);
                context.SaveChanges();
            }
        }

        void CreateInventory() //Με το που κάνει register ένα νέο Material βάζω εγγραφή και στον Inventory πίνακα
        {
            using (var context = new Context())
            {
                var materials = context.Material.ToList();
                var inventory = context.Inventory.ToList();
                foreach (var item in materials)
                {
                    if (inventory.Any(x => x.MaterialID == item.MaterialID))
                    {
                        continue;
                    }

                    var entity = new Inventory
                    {
                        MaterialID = item.MaterialID,
                        Quantity = 0,
                        QuantityForOrders = 0
                    };

                    context.Inventory.Add(entity);
                    context.SaveChanges();
                }
            }
        }

        void Update(MaterialModel material)
        {
            using (var context = new Context())
            {
                var entity = context.Material.Where(x => x.MaterialID == material.MaterialID).FirstOrDefault();

                if (entity != null)
                {
                    entity.Designation = material.Designation;
                    entity.MaterialCategoryID = material.MaterialCategoryID;
                    context.SaveChanges();
                }
            }
        }
    }
}
