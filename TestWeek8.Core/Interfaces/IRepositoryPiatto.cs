﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeek8.Core.Models;

namespace TestWeek8.Core.Interfaces
{
    public interface IRepositoryPiatto : IRepository<Piatto>
    {
        Piatto GetByName(string nome);
    }
}
