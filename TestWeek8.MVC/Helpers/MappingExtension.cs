using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Core.Models;
using TestWeek8.MVC.Models;

namespace TestWeek8.MVC.Helpers
{
    public static class MappingExtension
    {
        #region MENU
        public static MenuViewModel ToViewModel(this Menu menu)
        {
            return new MenuViewModel
            {
                IdMenu = menu.IdMenu,
                Nome = menu.Nome,
                Piatti = menu.Piatti
            };
        }

        public static IEnumerable<MenuViewModel> ToListViewModel(this IEnumerable<Menu> menus)
        {
            return menus.Select(e => e.ToViewModel());
        }

        public static Menu ToMenu(this MenuViewModel menuViewModel)
        {
            return new Menu
            {
                IdMenu = menuViewModel.IdMenu,
                Nome = menuViewModel.Nome,
                Piatti = menuViewModel.Piatti
            };
        }
        #endregion

        #region PIATTO
        public static PiattoViewModel ToViewModel(this Piatto piatto)
        {
            return new PiattoViewModel
            {
                IdPiatto = piatto.IdPiatto,
                Nome = piatto.Nome,
                Descrizione = piatto.Descrizione,
                Tipologia = piatto.Tipologia,
                Prezzo = piatto.Prezzo
            };
        }
                
        public static IEnumerable<PiattoViewModel> ToListViewModel(this IEnumerable<Piatto> piatti)
        {
            return piatti.Select(e => e.ToViewModel());
        }

        public static Piatto ToPiatto(this PiattoViewModel piattoViewModel)
        {
            return new Piatto
            {
                IdPiatto = piattoViewModel.IdPiatto,
                Nome = piattoViewModel.Nome,
                Descrizione = piattoViewModel.Descrizione,
                Tipologia = piattoViewModel.Tipologia,
                Prezzo = piattoViewModel.Prezzo
            };
        }
        #endregion

        #region UTENTE
        public static Utente ToUtente(this UtenteLoginViewModel userViewModel)
        {
            return new Utente
            {
                Email = userViewModel.Email,
                Password = userViewModel.Password,
                Tipo = AccountType.Cliente
            };
        }
        #endregion

    }
}
