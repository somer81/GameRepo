using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    class GameManager : IGameService
    {
        private IEntity _entity;
        public GameManager(IEntity entity)
        {
            _entity = entity;
        }
      
        public void Add()
        {
            Console.WriteLine("Game is Added");
        }

        public void Delete()
        {
            Console.WriteLine("Game is Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Game is Updated");
        }
    }
}
