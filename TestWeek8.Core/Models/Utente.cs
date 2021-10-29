using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8.Core.Models
{
    public enum AccountType
    {
        Ristoratore,
        Cliente
    }
    public class Utente
    {
        public int IdUtente { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public AccountType Tipo { get; set; }

    }
}
