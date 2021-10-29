using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestWeek8.Core.Models;

namespace TestWeek8.MVC.Models
{
    public class MenuViewModel
    {
        public int IdMenu { get; set; }

        [Required]
        [Display (Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [Display (Name = "Piatti")]
        public List<Piatto> Piatti { get; set; }
    }
}
