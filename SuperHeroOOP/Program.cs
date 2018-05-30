using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero George = new SuperHero(135, 900, "Overwhelming", "You will never know!");
            George.Power();
            George.Tortise();
            George.Unkown();
            George.Mind();
        }
    }
}
