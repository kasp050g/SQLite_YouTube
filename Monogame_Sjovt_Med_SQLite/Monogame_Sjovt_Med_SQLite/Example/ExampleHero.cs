using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_Sjovt_Med_SQLite.Example
{
    public class ExampleHero
    {
        public string UserName { get; set; }
        public string HeroName { get; set; }
        public ExampleClassEnum ClassType { get; set; }
        public List<ExampleSkill> Skill { get; set; }
        public bool JamenBool { get;set; }
    }
}
