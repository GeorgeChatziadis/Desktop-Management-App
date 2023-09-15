using DAL.Entities;
using BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class LookUpEditRepository : Repository
    {
        public LookUpEditRepository() : base() { }
        public LookUpEditRepository(Context context) : base(context) { }

        public List<LookUpEditModel> SetLookUpProductCategories()
        {
            using (var context = new Context())
            {
                var productCategories = context.ProductCategories.Select(x => new LookUpEditModel
                {
                    Designation = x.Designation,
                    ID = x.ProductCategoriesID
                }).OrderBy(x => x.Designation).ToList();

                return productCategories;
            }
        }

        public List<LookUpEditModel> SetLookUpMaterialCategories()
        {
            using (var context = new Context())
            {
                var materialCategories = context.MaterialCategories.Select(x => new LookUpEditModel
                {
                    Designation = x.Designation,
                    ID = x.MaterialCategoriesID
                }).OrderBy(x => x.Designation).ToList();

                return materialCategories;
            }
        }

        public List<LookUpEditModel> SetLookUpProducts()
        {
            using (var context = new Context())
            {
                var products = context.Product.Select(x => new LookUpEditModel
                {
                    Designation = x.Designation,
                    ID = x.ProductID
                }).OrderBy(x => x.Designation).ToList();

                return products;
            }
        }

        public List<LookUpEditModel> SetLookUpMaterials()
        {
            using (var context = new Context())
            {
                var products = context.Material.Select(x => new LookUpEditModel
                {
                    Designation = x.Designation,
                    ID = x.MaterialID
                }).OrderBy(x => x.Designation).ToList();

                return products;
            }
        }

        public List<LookUpEditModel> SetLookUpClients()
        {
            using (var context = new Context())
            {
                var clients = context.Client.Select(x => new LookUpEditModel
                {
                    Designation = x.Name,
                    ID = x.ClientID
                }).OrderBy(x => x.Designation).ToList();

                return clients;
            }
        }

        public List<LookUpEditModel> SetLookUpClientsForTown(Guid? townID)
        {
            using (var context = new Context())
            {
                var clients = context.Client.Where(x => x.TownID == townID).Select(x => new LookUpEditModel
                {
                    Designation = x.Name,
                    ID = x.ClientID
                }).OrderBy(x => x.Designation).ToList();

                return clients;
            }
        }

        public List<LookUpEditModel> SetLookUpTowns()
        {
            using (var context = new Context())
            {
                var towns = context.Town.Select(x => new LookUpEditModel
                {
                    Designation = x.Designation,
                    ID = x.TownID
                }).OrderBy(x => x.Designation).ToList();

                return towns;
            }
        }
    }
}
