using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeek8.MVC.Models
{
    public class UtenteViewModel
    {
        public int IdUtente { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password), MaxLength(16)]
        public string Password { get; set; }

        [Required]
        public Type Tipo { get; set; }
    }
}
