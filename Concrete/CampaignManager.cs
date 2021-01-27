using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrete
{
    public class CampaignManager : IGameService
    {
        private IEntity _entity;
        public CampaignManager(IEntity entity)
        {
            _entity = entity;
        }

        public void Add()
        {
            Console.WriteLine("Campaign is Added");
        }

        public void Delete()
        {
            Console.WriteLine("Campaign is Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Campaign is Updated");
        }
    }
}
