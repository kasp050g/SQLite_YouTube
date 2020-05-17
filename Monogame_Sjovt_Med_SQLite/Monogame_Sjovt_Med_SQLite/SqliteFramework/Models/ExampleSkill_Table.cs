using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Sjovt_Med_SQLite.SqliteFramework.Models
{
    public class ExampleSkill_Table
    {
        public int ID { get; set; }
        public int HeroID { get; set; }
        public string Name { get; set; }
        public float Damage { get; set; }

        public ExampleSkill_Table()
        {

        }

        public ExampleSkill_Table(int HeroID, string Name, float Damage)
        {
            this.HeroID = HeroID;
            this.Name = Name;
            this.Damage = Damage;
        }
    }
}
