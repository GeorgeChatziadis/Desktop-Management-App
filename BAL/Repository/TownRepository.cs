using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAL.Models;
using DAL.Entities;

namespace BAL.Repository
{
    public class TownRepository : Repository
    {
        public TownRepository() : base() { }
        public TownRepository(Context context) : base(context) { }

        public List<TownModel> GetTowns()
        {
            var list = Context.Town.Select(x => new TownModel { TownDesignation = x.Designation, TownID = x.TownID }).OrderBy(x => x.TownDesignation).ToList();
            return list;
        }

        public void Save(List<TownModel> towns)
        {
            foreach (var item in towns)
            {
                if (item.TownID == null || item.TownID == Guid.Empty)
                {
                    Create(item);
                }
                else
                {
                    Update(item);
                }
            }
        }

        public void Delete(TownModel town)
        {
            var entity = Context.Town.Where(x => x.TownID == town.TownID).FirstOrDefault();
            Context.Town.Remove(entity);
            Context.SaveChanges();
        }

        void Create(TownModel town)
        {
            var entity = new Town
            {
                Designation = town.TownDesignation
            };
            this.Context.Town.Add(entity);
            Context.SaveChanges();
        }

        void Update(TownModel town)
        {
            var entity = Context.Town.Where(x => x.TownID == town.TownID).FirstOrDefault();
            entity.Designation = town.TownDesignation;
            Context.SaveChanges();
        }
    }
}
