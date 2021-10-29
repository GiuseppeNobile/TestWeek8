using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Core.Interfaces;
using TestWeek8.Core.Models;

namespace TestWeek8.Core
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IRepositoryMenu _menuRepo;
        private readonly IRepositoryPiatto _piattoRepo;
        private readonly IRepositoryUtente _utenteRepo;

        public MainBusinessLayer(IRepositoryMenu repoMenu, IRepositoryPiatto repoPiatto, IRepositoryUtente repoUtente)
        {
            this._menuRepo = repoMenu;
            this._piattoRepo = repoPiatto;
            this._utenteRepo = repoUtente;
        }

        public ResultBL AddNewUtente(Utente user)
        {
            if (user == null)
                return new ResultBL(false, "Utente non valido");

            var result = _utenteRepo.AddItem(user);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Utente creato!");
        }

        public ResultBL CreateMenu(Menu newMenu)
        {
            if (newMenu == null)
                return new ResultBL(false, "Dati del menu non validi");

            var result = _menuRepo.AddItem(newMenu);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Menu creato!");
        }

        public ResultBL CreatePiatto(Piatto newPiatto)
        {
            if (newPiatto == null)
                return new ResultBL(false, "Dati del piatto non validi");

            var result = _piattoRepo.AddItem(newPiatto);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Piatto creato!");
        }

        public ResultBL DeleteMenu(int id)
        {
            if (id <= 0)
                return new ResultBL(false, "ID non valido!");

            var result = _menuRepo.DeleteItem(id);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Menu cancellato!");
        }

        public ResultBL DeletePiatto(int id)
        {
            if (id <= 0)
                return new ResultBL(false, "ID non valido!");

            var result = _piattoRepo.DeleteItem(id);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Piatto cancellato!");
        }

        public ResultBL EditMenu(Menu editedMenu)
        {
            if(editedMenu == null)
                return new ResultBL(false, "Menu non valido!");

            var result = _menuRepo.UpdateItem(editedMenu);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Menu modificato!");
        }

        public ResultBL EditPiatto(Piatto editedPiatto)
        {
            if (editedPiatto == null)
                return new ResultBL(false, "Menu non valido!");

            var result = _piattoRepo.UpdateItem(editedPiatto);

            if (!result)
                return new ResultBL(result, "qualcosa è andato storto!");

            return new ResultBL(result, "Piatto modificato!");
        }

        public IEnumerable<Menu> FetchMenus(Func<Menu, bool> filter = null)
        {
            return this._menuRepo.Fetch(filter);
        }

        public IEnumerable<Piatto> FetchPiatti(Func<Piatto, bool> filter = null)
        {
            return this._piattoRepo.Fetch(filter);
        }

        public Menu GetMenuById(int id)
        {
            if (id <= 0)
                return null;
            return this._menuRepo.GetById(id);
        }

        public Menu GetMenuByName(string name)
        {
            if (string.IsNullOrEmpty(name))            
                return null;

            return this._menuRepo.GetByName(name);
        }

        public Piatto GetPiattoById(int id)
        {
            if (id <= 0)
                return null;
            return this._piattoRepo.GetById(id);
        }

        public Piatto GetPiattoByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;

            return this._piattoRepo.GetByName(name);
        }

        public Utente GetUtenteByEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return null;
            return _utenteRepo.GetByEmail(email);
        }
    }
}
