using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Core.Models;

namespace TestWeek8.Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        #region MENU
        IEnumerable<Menu> FetchMenus(Func<Menu, bool> filter = null);
        Menu GetMenuById(int id);
        Menu GetMenuByName(string name);
        ResultBL CreateMenu(Menu newMenu);
        ResultBL EditMenu(Menu editedMenu);
        ResultBL DeleteMenu(int id);
        #endregion

        #region PIATTO
        IEnumerable<Piatto> FetchPiatti(Func<Piatto, bool> filter = null);
        Piatto GetPiattoById(int id);
        Piatto GetPiattoByName(string name);
        ResultBL CreatePiatto(Piatto newPiatto);
        ResultBL EditPiatto(Piatto editedPiatto);
        ResultBL DeletePiatto(int id);
        #endregion

        #region UTENTE        
        Utente GetUtenteByEmail(string email);
        ResultBL AddNewUtente(Utente user);
        #endregion
    }
}
