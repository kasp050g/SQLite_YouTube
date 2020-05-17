using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Sjovt_Med_SQLite.SqliteFramework.Models
{
    public class ExampleUser_Table
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool UnlockACC { get; set; }

        public ExampleUser_Table()
        {

        }
        public ExampleUser_Table(string Name, DateTime Date, bool UnlockACC)
        {
            this.Name = Name;
            this.Date = Date;
            this.UnlockACC = UnlockACC;
        }
    }
}
