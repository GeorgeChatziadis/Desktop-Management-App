using BAL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class PriceForClientRepository : Repository
    {
        public PriceForClientRepository() : base() { }
        public PriceForClientRepository(Context context) : base(context) { }

        public List<PriceForClientModel> GetClients()
        {
                var list = (from x in this.Context.PriceForClient
                            join y in this.Context.Client on x.ClientID equals y.ClientID
                            select new PriceForClientModel
                            {
                                ClientID = x.ClientID,
                                ClientName = y.Name                                
                            }).Distinct().OrderBy(x => x.ClientName).ToList();

                return list;
        }

        public List<PriceForClientModel> GetPricesForClient(Guid clientID)
        {
            using (var context = new Context())
            {
                var list = context.PriceForClient.Where(x => x.ClientID == clientID).Select(x => new PriceForClientModel
                {
                    ProductID = x.ProductID,
                    NewPrice = x.NewPrice,
                    PriceForClientID = x.PriceForClientID
                }).OrderBy(x => x.NewPrice).ToList();

                return list;
            }

        }

        public decimal? GetPriceForClientAndProduct(Guid clientID, Guid productID)
        {
            using (var context = new Context())
            {
                var price = context.PriceForClient.Where(x => x.ClientID == clientID && x.ProductID == productID).Select(x => x.NewPrice).FirstOrDefault();

                return price;
            }

        }

        public decimal? ProductPrice(Guid productID)
        {
            var price = this.Context.Product.Where(x => x.ProductID == productID).Select(x => x.Price).FirstOrDefault();

            return price;
        }

        public string Save(List<PriceForClientModel> newPrices, Guid clientID)
        {
            var priceForClient = this.Context.PriceForClient.Where(x => x.ClientID == clientID).ToList();
            foreach (var item in newPrices.Where(x => x.PriceForClientID == null || x.PriceForClientID == Guid.Empty))
            {
                if (priceForClient.Any(x => x.ProductID == item.ProductID))
                {
                    return "nope";
                }
                var entity = new PriceForClient
                {
                    ProductID = item.ProductID,
                    ClientID = clientID,
                    NewPrice = item.NewPrice
                };

                this.Context.PriceForClient.Add(entity);
            }

            foreach (var item in newPrices.Where(x => x.PriceForClientID != null && x.PriceForClientID != Guid.Empty))
            {
                var entity = this.Context.PriceForClient.Where(x => x.PriceForClientID == item.PriceForClientID).FirstOrDefault();
                entity.NewPrice = item.NewPrice; //Γινεται το update της τιμης
                if (item.NewPrice == 0) //Αν ειναι μηδεν η νεα τιμη τοτε διαγραφει τελειως την εγγραφη
                {
                    this.Context.PriceForClient.Remove(entity);
                }

            }
            this.Context.SaveChanges();
            return "ok";
        }

        public void Delete(Guid clientID)
        {
            List<PriceForClient> list = this.Context.PriceForClient.Where(x => x.ClientID == clientID).ToList();

            if (list != null)
            {
                if (list.Count > 0)
                {
                    foreach (var item in list)
                    {
                        this.Context.PriceForClient.Remove(item);
                    }
                }
            }

            this.Context.SaveChanges();
        }

    }
}
