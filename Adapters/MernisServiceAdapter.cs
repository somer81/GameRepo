using Game.Abstract;
using Game.Entities;
using Game.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Adapters
{
    class MernisServiceAdapter : ICheckPlayerService
    {
        public bool CheckifRealPerson(Player player)
        {
            return TaskAsync(player).Result;
        }

        public static async Task<bool> TaskAsync(Player player)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            var status = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.TCNo), player.FName, player.Lname, player.DateofBirth.Year);

            return status.Body.TCKimlikNoDogrulaResult;
        }
    }
}
