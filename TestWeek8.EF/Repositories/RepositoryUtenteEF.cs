using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Core.Interfaces;
using TestWeek8.Core.Models;

namespace TestWeek8.EF.Repositories
{
    public class RepositoryUtenteEF : IRepositoryUtente
    {
        private readonly RistoranteContext ctx;

        public RepositoryUtenteEF(RistoranteContext context)
        {
            this.ctx = context;
        }

        public bool AddItem(Utente item)
        {
            if (item == null)
                return false;

            ctx.Utenti.Add(item);
            ctx.SaveChanges();

            return true;
        }

        public bool DeleteItem(int id)
        {
            if (id <= 0)
                return false;

            var itemToDelete = this.ctx.Utenti.Find(id);

            if (itemToDelete == null)
                return false;

            this.ctx.Utenti.Remove(itemToDelete);
            ctx.SaveChanges();

            return true;
        }

        public IEnumerable<Utente> Fetch(Func<Utente, bool> filter = null)
        {
            if (filter != null)
                return this.ctx.Utenti.Where(filter);

            return this.ctx.Utenti;
        }

        public Utente GetByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;

            return ctx.Utenti.FirstOrDefault(m => m.Email.Equals(email));
        }

        public Utente GetById(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Utenti.Find(id);
        }

        public bool UpdateItem(Utente updatedItem)
        {
            if (updatedItem == null)
                return false;

            ctx.Entry(updatedItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();

            return true;
        }
    }
}
