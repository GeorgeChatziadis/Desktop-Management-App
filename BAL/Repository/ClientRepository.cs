using BAL.Models;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class ClientRepository : Repository
    {
        public ClientRepository() : base() { }
        public ClientRepository(Context context) : base(context) { }

        public List<ClientModel> GetClients()
        {
            using (var context = new Context())
            {
                var clients = context.Client.Select(x => new ClientModel
                {
                    ClientID = x.ClientID,
                    Address = x.Address,
                    Email = x.Email,
                    Mobile = x.Mobile,
                    Comments = x.Comments,
                    Name = x.Name,
                    Telephone = x.Telephone,
                    TownDesignation = x.Town.Designation
                }).OrderBy(x => x.Name).ToList();

                return clients;
            }

        }

        public ClientModel GetClient(Guid clientID)
        {
            using (var context = new Context())
            {
                var client = context.Client.Where(x => x.ClientID == clientID).Select(x => new ClientModel
                {
                    Address = x.Address,
                    Comments = x.Comments,
                    Email = x.Email,
                    Mobile = x.Mobile,
                    Name = x.Name,
                    Telephone = x.Telephone,
                    ClientID = x.ClientID,
                    TownID = x.TownID
                }).FirstOrDefault();

                return client;
            }
        }



        #region CRUD
        public void Save(ClientModel client)
        {
            if (client.ClientID != null && client.ClientID != Guid.Empty)
            {
                Update(client);
            }
            else
            {
                Create(client);
            }
        }
        public void Create(ClientModel client)
        {
            var entity = new Client
            {
                Name = client.Name,
                Address = client.Address,
                Comments = client.Comments,
                Email = client.Email,
                Mobile = client.Mobile,
                Telephone = client.Telephone,
                TownID = client.TownID
            };

            this.Context.Client.Add(entity);
            Context.SaveChanges();
        }

        public void Update(ClientModel client)
        {
            var entity = this.Context.Client.Where(x => x.ClientID == client.ClientID).FirstOrDefault();

            if (entity != null)
            {
                entity.Name = client.Name;
                entity.Address = client.Address;
                entity.Comments = client.Comments;
                entity.Email = client.Email;
                entity.Mobile = client.Mobile;
                entity.Telephone = client.Telephone;
                entity.TownID = client.TownID;
            }

            Context.SaveChanges();
        }

        public void Delete(Guid clientID)
        {
            using (var context = new Context())
            {
                var entity = context.Client.Where(x => x.ClientID == clientID).FirstOrDefault();

                if (entity != null)
                {
                    context.Client.Remove(entity);
                }

                context.SaveChanges();
            }            
        }

        #endregion
    }
}
