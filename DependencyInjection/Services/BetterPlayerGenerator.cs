using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class BetterPlayerGenerator : IPlayerGenerator
    {
        public Player CreateNewPlayer()
        {
            throw new NotImplementedException();
        }
    }
}
