using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using BAL.Models;

namespace BAL.Repository
{
    public class PurchaseRepository : Repository
    {
        public PurchaseRepository() : base() { }
        public PurchaseRepository(Context context) : base(context) { }

        public List<PurchaseModel> GetProductPurchases(CriteriaModel criteria)
        {
            var purchases = Context.Purchase.Where(x => x.ProductID != null && x.ProductID != Guid.Empty).ToList();

            if (criteria.DateTo != null && criteria.DateTo != DateTime.MinValue)
            {
                purchases = purchases.Where(x => x.Date <= criteria.DateTo).ToList();
            }
            if (criteria.DateFrom != null && criteria.DateFrom != DateTime.MinValue)
            {
                purchases = purchases.Where(x => x.Date >= criteria.DateFrom).ToList();
            }
            if (criteria.ProductID != null && criteria.ProductID != Guid.Empty)
            {
                purchases = purchases.Where(x => x.ProductID == criteria.ProductID).ToList();
            }

            var list = purchases.Select(x => new PurchaseModel
            {
                Date = x.Date,
                Comments = x.Comments,
                Cost = x.Cost,
                ProductName = x.Product.Designation,
                Quantity = x.Quantity,
                ProductPurchaseID = x.ProductPurchaseID,
                ProductID = x.ProductID
            }).ToList();

            return list;
        }

        public List<PurchaseModel> GetMaterialPurchase(CriteriaModel criteria)
        {
            var purchases = Context.Purchase.Where(x => x.MaterialID != null && x.MaterialID != Guid.Empty).ToList();

            if (criteria.DateTo != null && criteria.DateTo != DateTime.MinValue)
            {
                purchases = purchases.Where(x => x.Date <= criteria.DateTo).ToList();
            }
            if (criteria.DateFrom != null && criteria.DateFrom != DateTime.MinValue)
            {
                purchases = purchases.Where(x => x.Date >= criteria.DateFrom).ToList();
            }
            if (criteria.ProductID != null && criteria.ProductID != Guid.Empty)
            {
                purchases = purchases.Where(x => x.MaterialID == criteria.MaterialID).ToList();
            }

            var list = purchases.Select(x => new PurchaseModel
            {
                Date = x.Date,
                Comments = x.Comments,
                Cost = x.Cost,
                ProductName = x.Material.Designation,
                Quantity = x.Quantity,
                ProductPurchaseID = x.ProductPurchaseID,
                MaterialID = x.MaterialID
            }).ToList();

            return list;
        }

        public PurchaseModel GetProductPurchaseByID(Guid purchaseID)
        {
            var puchase = Context.Purchase.Where(x => x.ProductPurchaseID == purchaseID).Select(x => new PurchaseModel
            {
                Comments = x.Comments,
                Cost = x.Cost,
                Date = x.Date,
                ProductID = x.ProductID,
                Quantity = x.Quantity
            }).FirstOrDefault();

            return puchase;
        }

        public PurchaseModel GetMaterialPurchaseByID(Guid purchaseID)
        {
            var puchase = Context.Purchase.Where(x => x.ProductPurchaseID == purchaseID).Select(x => new PurchaseModel
            {
                Comments = x.Comments,
                Cost = x.Cost,
                Date = x.Date,
                MaterialID = x.MaterialID,
                Quantity = x.Quantity
            }).FirstOrDefault();

            return puchase;
        }

        public void Save(PurchaseModel model)
        {
            var entity = new Purchase
            {
                Comments = model.Comments,
                Date = model.Date,
                ProductID = model.ProductID,
                Cost = model.Cost,
                MaterialID = model.MaterialID,
                Quantity = model.Quantity
            };

            Context.Purchase.Add(entity);
            Context.SaveChanges();
            if (model.ProductID != null && model.ProductID != Guid.Empty)
            {
                UpdateInventory(model.ProductID, model.Quantity, true, true);
            }
            else
            {
                UpdateInventory(model.MaterialID, model.Quantity, true, false);
            }
        }

        public void Delete(Guid purchaseID)
        {
            var entity = Context.Purchase.Where(x => x.ProductPurchaseID == purchaseID).FirstOrDefault();
            if (entity.ProductID != null && entity.ProductID != Guid.Empty)
            {
                UpdateInventory(entity.ProductID, entity.Quantity, false, true);
            }
            else
            {
                UpdateInventory(entity.MaterialID, entity.Quantity, false, false);
            }
            Context.Purchase.Remove(entity);
            Context.SaveChanges();

            
        }

        void UpdateInventory(Guid? productID , decimal? quantity, bool isSave, bool isProduct)
        {
            if (isSave && isProduct) //Αποθηκεύω αγορά νέου προϊόντος
            {
                var inventory = Context.Inventory.Where(x => x.ProductID == productID).FirstOrDefault();
                inventory.Quantity += quantity;
            }
            else if (!isSave && isProduct) //Διαγράφω αγορά προϊόντος
            {
                var inventory = Context.Inventory.Where(x => x.ProductID == productID).FirstOrDefault();
                inventory.Quantity -= quantity;
            }
            if (isSave && !isProduct) //Αποθηκεύω αγορά νέου υλικού
            {
                var inventory = Context.Inventory.Where(x => x.MaterialID == productID).FirstOrDefault();
                inventory.Quantity += quantity;
            }
            else if (!isSave && !isProduct) //Διαγράφω αγορά υλικού
            {
                var inventory = Context.Inventory.Where(x => x.MaterialID == productID).FirstOrDefault();
                inventory.Quantity -= quantity;
            }

            Context.SaveChanges();
        }
    }
}
