using Monogame_Sjovt_Med_SQLite.Example;
using Monogame_Sjovt_Med_SQLite.SqliteFramework.CustomeModels;
using Monogame_Sjovt_Med_SQLite.SqliteFramework.Models;
using SqliteFramework;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Sjovt_Med_SQLite.SqliteFramework.Factories
{
    public class ExampleSkill_Fac : AutoFac<ExampleSkill_Table>
    {
        public List<ExampleSkill> AllSkillHeroGotExampleSkill(int ID)
        {
            string SQL = "";
            // Select
            SQL += "SELECT ExampleSkill_Table.Name as ExampleName, ExampleSkill_Table.Damage as ExampleDamage ";
            // From
            SQL += " FROM ExampleHero_Table ";
            // Inner Join
            SQL += " INNER JOIN ExampleSkill_Table ON ExampleSkill_Table.HeroID = ExampleHero_Table.ID ";
            // Where
            SQL += " WHERE ExampleHero_Table.ID=@ID ";

            using (var cmd = new SQLiteCommand(SQL, Conn.CreateConnection()))
            {
                cmd.Parameters.AddWithValue("@ID", ID);

                var mapper = new Mapper<ExampleSkill>();
                List<ExampleSkill> per = new List<ExampleSkill>();

                per = mapper.MapList(cmd.ExecuteReader());

                cmd.Connection.Close();
                return per;
            }
        }
    }
}
