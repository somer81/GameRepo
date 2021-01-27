using Game.Adapters;
using Game.Concrete;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gaming game1 = new Gaming() { 
              Id = 1,
              Name = "Chess", 
              Description = "Borad Game", 
              Price = 10
            };
            Player player1 = new Player() {
                Id = 1,
                FName = "Omer",
                Lname = "Sevinc",
                DateofBirth = new DateTime(1982, 4, 12),
                TCNo = "2323232323"
               
            };
            Campaign campaign1 = new Campaign() { 
              Id = 1,
              Name = "Big One",
              Discount = "50%"
            };

            GameManager gameManager = new GameManager(game1);
            gameManager.Add();

            PlayerManager playerManager = new PlayerManager(player1);

            MernisServiceAdapter service = new MernisServiceAdapter();
            service.CheckifRealPerson(player1); 


        }
    }
}
