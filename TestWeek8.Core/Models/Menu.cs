using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeek8.Core.Models
{
    public class Menu
    {
        public int IdMenu { get; set; }
        public string Nome { get; set; }
        public List<Piatto> Piatti { get; set; }

    }
}
