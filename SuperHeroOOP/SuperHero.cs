using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroOOP
{
    class SuperHero
    {
        //Declaire Fields

        private int highIQ;
        private int strength;
        private string stamina;
        private string hiddenIdentity;

        //Declaire Properties

        public int HighIQ
        {
            get { return this.highIQ; }
            set { this.highIQ = value; }
        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public string Stamina
        {
            get { return this.stamina; }
            set { this.stamina = value; }
        }

        public string HiddenIdentity
        {
            get { return this.hiddenIdentity; }
            set { this.hiddenIdentity = value; }
        }

        //Declaire Constructors
        public SuperHero()
        {
            //Default
        }

        //Loaded Constructor
        public SuperHero(int highIQ, int strength, string stamina, string hiddenIdentity)
        {
            this.highIQ = highIQ;
            this.strength = strength;
            this.stamina = stamina;
            this.hiddenIdentity = hiddenIdentity;
        }

        public SuperHero(int strength, string stamina)
        {
            this.strength = strength;
            this.stamina = stamina;
        }


        public void Power()
        {
            Console.WriteLine("The Hero lifts {0} pounds!", Strength);
        }
        public void Mind()
        {
            Console.WriteLine("What's your IQ like {0} man thats low!", HighIQ);
        }
        public void Unkown()
        {
            Console.WriteLine("My life is my own! {0}", HiddenIdentity);
        }
        public void Tortise()
        {
            Console.WriteLine("Your stamina is {0}!", Stamina);
        }

    }
}
