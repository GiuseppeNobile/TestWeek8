using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Core.Models;

namespace TestWeek8.MVC.Models
{
    public class PiattoViewModel
    {
        public int IdPiatto { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrizione")]
        public string Descrizione { get; set; }

        [Required]
        [Display(Name = "Tipologia")]
        public Typology Tipologia { get; set; }

        [Required]
        [Display(Name = "Prezzo")]
        public decimal Prezzo { get; set; }
    }
}
