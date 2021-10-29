using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8.Core.Models
{
    public enum Typology
    {
        Primo,
        Secondo,
        Contorno,
        Dolce
    }
    public class Piatto
    {
        public int IdPiatto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public Typology Tipologia { get; set; }
        public decimal Prezzo { get; set; }
    }
}
