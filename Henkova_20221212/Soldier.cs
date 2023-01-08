using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Henkova_20221212
{
    public class Soldier
    {
        Random random = new Random();
        public string Name { get; set; }
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int DMG { get; set; }
        public int Shield { get; set; }
        public int MaxShield { get; set; }
        public int Level { get; set; }
        public string Attack { get; set; }
        public string Heal { get; set; }
        public int LevelUp { get; set; }
        public string Result { get; set; }
        public Soldier()
        {
            Name = "";
            HP = 100;
            MaxHP = 100;
            DMG = random.Next(10,100);
            Shield = 100;
            MaxShield = 100;
            Level = 1;
            Result = " Alive";
        }

        public void Bojovat()
        {
            if (HP <= 0)
            {
                Result = " You are dead!";
                HP = 0;
            }
            else if(Shield > 0)
            {
                Shield -= DMG;

            }
            else if(Shield <= 0)
            {
                HP -= DMG;
            }
     
          

        }

        public void LecitSe()
        {
            
            if(HP > 0)
            {
                HP += 10;
                Level -= 1;
            }
            if(Level < 0)
            {
                Level = 0;
            }
        }

        public void ZvysitLevel()
        {
            if(HP > 0)
            {
                Level += 1; 
                HP -= 25;
                Shield += 25;
            }
            else if (HP <= 0)
            {
                Result = " You are dead!";
            }
            if (Shield < 0)
            {
                Shield = 0;
            }
        }

       
    }

}
