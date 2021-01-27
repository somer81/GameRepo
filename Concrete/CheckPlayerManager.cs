using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    class CheckPlayerManager : ICheckPlayerService
    {
        public bool CheckifRealPerson(Player player)
        {
            return true; 
        }
    }
}
