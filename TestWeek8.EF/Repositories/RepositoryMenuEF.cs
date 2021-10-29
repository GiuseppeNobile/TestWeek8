using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Core.Interfaces;
using TestWeek8.Core.Models;

namespace TestWeek8.EF.Repositories
{
    public class RepositoryMenuEF : IRepositoryMenu
    {
        private readonly RistoranteContext ctx;

        public RepositoryMenuEF(RistoranteContext context)
        {
            this.ctx = context;
        }

        public bool AddItem(Menu item)
        {
            if (item == null)
                return false;

            ctx.Menus.Add(item);
            ctx.SaveChanges();

            return true;
        }

        public bool DeleteItem(int id)
        {
            if (id <= 0)
                return false;

            var itemToDelete = this.ctx.Menus.Find(id);

            if (itemToDelete == null)
                return false;

            this.ctx.Menus.Remove(itemToDelete);
            ctx.SaveChanges();

            return true;
        }

        public IEnumerable<Menu> Fetch(Func<Menu, bool> filter = null)
        {
            if (filter != null)
                return this.ctx.Menus.Where(filter);

            return this.ctx.Menus;
        }

        public Menu GetById(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Menus.Find(id);
        }

        public Menu GetByName(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return null;

            return ctx.Menus.FirstOrDefault(m => m.Nome.Equals(nome));
        }

        public bool UpdateItem(Menu updatedItem)
        {
            if (updatedItem == null)
                return false;

            ctx.Entry(updatedItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            ctx.SaveChanges();

            return true;
        }
    }
}
