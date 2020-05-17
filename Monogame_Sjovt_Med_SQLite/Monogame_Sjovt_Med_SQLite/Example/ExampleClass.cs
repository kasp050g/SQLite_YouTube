
using Monogame_Sjovt_Med_SQLite.Example;
using Monogame_Sjovt_Med_SQLite.SqliteFramework;
using Monogame_Sjovt_Med_SQLite.SqliteFramework.Factories;
using Monogame_Sjovt_Med_SQLite.SqliteFramework.Models;
using SqliteFramework;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monogame_Sjovt_Med_SQLite.Sqlite
{
    public class ExampleClass
    {
        private ExampleUser_Fac exampleUser_Fac = new ExampleUser_Fac();
        private ExampleHero_Fac exampleHero_Fac = new ExampleHero_Fac();
        private ExampleSkill_Fac exampleSkill_Fac = new ExampleSkill_Fac();

        public void RunSQLite()
        {
            ExampleMakeTables();
            ExampleInsertTable();
            ExampleTest();
        }

        private void ExampleMakeTables()
        {
            AutoTable<ExampleHero_Table> autoTable01 = new AutoTable<ExampleHero_Table>();
            AutoTable<ExampleUser_Table> autoTable02 = new AutoTable<ExampleUser_Table>();
            AutoTable<ExampleSkill_Table> autoTable03 = new AutoTable<ExampleSkill_Table>();
            autoTable01.MakeTable();
            autoTable02.MakeTable();
            autoTable03.MakeTable();
        }

        private void ExampleInsertTable()
        {
            ExampleUser_Table user = new ExampleUser_Table("Kasper_Ja",DateTime.Now,true);
            int userID = exampleUser_Fac.Insert(user);

            ExampleHero_Table hero01 = new ExampleHero_Table(userID,"Bara",ExampleClassEnum.Class01);
            ExampleHero_Table hero02 = new ExampleHero_Table(userID, "Tata", ExampleClassEnum.Class02);
            int heroID01 = exampleHero_Fac.Insert(hero01);
            int heroID02 = exampleHero_Fac.Insert(hero02);

            ExampleSkill_Table skill01 = new ExampleSkill_Table(heroID01,"Fire Boll",23.54f);
            ExampleSkill_Table skill02 = new ExampleSkill_Table(heroID01,"Fire Attack",7373.1f);
            exampleSkill_Fac.Insert(skill01);
            exampleSkill_Fac.Insert(skill02);

            ExampleSkill_Table skill03 = new ExampleSkill_Table(heroID02, "Water Boll", 5.11f);
            ExampleSkill_Table skill04 = new ExampleSkill_Table(heroID02, "Water Attack", 666.999f);
            exampleSkill_Fac.Insert(skill03);
            exampleSkill_Fac.Insert(skill04);
        }

        private void ExampleTest()
        {
            List<ExampleSkill> tmp = exampleSkill_Fac.AllSkillHeroGotExampleSkill(1);

            foreach (var item in tmp)
            {
                Console.WriteLine(item.ExampleName);
                Console.WriteLine(item.ExampleDamage);
            }
        }
    }
}
