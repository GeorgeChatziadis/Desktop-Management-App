using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public abstract class Repository : IDisposable
    {
        public Repository() : this(new Context(), true) { }
        public Repository(Context context) : this(context, false) { }

        Repository(Context context, bool ownsContext)
        {
            this.context = context;
            this.ownsContext = ownsContext;
        }

        private readonly Context context;
        private readonly bool ownsContext;

        protected Context Context => this.context;

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                if (this.ownsContext)
                    this.context?.Dispose();
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        public virtual void SaveChanges()
        {
            this.Context.SaveChanges();
        }

    }
}
