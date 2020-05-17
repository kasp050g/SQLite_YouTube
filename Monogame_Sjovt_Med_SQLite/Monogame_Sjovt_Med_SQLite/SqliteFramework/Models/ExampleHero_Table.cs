using Monogame_Sjovt_Med_SQLite.Example;
using Monogame_Sjovt_Med_SQLite.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Sjovt_Med_SQLite.SqliteFramework.Models
{
    public class ExampleHero_Table
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public ExampleClassEnum exampleClassEnum { get; set; }

        public ExampleHero_Table()
        {

        }
        public ExampleHero_Table(int UserID, string Name, ExampleClassEnum exampleClassEnum)
        {
            this.UserID = UserID;
            this.Name = Name;
            this.exampleClassEnum = exampleClassEnum;
        }
    }


}
