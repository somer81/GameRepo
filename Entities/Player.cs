using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Player:IEntity
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string Lname { get; set; }
        public DateTime DateofBirth { get; set; }
        public string TCNo { get; set; }
    }
}
