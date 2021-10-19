using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    internal class Player   // behövs internal?
    {
        //constuctor???

        public string Name { get; set; } = "";   // exakt varför get; set;??  behövs den överallt??       INPUT FRÅN USER!!!
        public int Level { get; set; } = 1;
        public int Exp { get; set; } = 0;
        public int Hp { get; set; } = 100;
        public int Strenght { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Gold { get; set; } = 0;
        public string CatchPhrase { get; set; } = "Im the HEEROOO";
        public string AttackPhrase { get; set; } = "I will save us!";
        public string DeathPhrase { get; set; } = "Bye mama... ugh";
        private bool IsDead { get; set; } = false;  // private enligt marcus exempel, varför???

        public void ShowStats()  // anropas via switch i huvudmenyn
        {
            Console.WriteLine("Name:     " + Name);
            Console.WriteLine("Level:    " + Level);
            Console.WriteLine("EXP:      " + Exp + "/100");
            Console.WriteLine("HP:       " + Hp + "/100");
            Console.WriteLine("Strenght: " + Strenght);
            Console.WriteLine("Defense:  " + Defense);
            Console.WriteLine("Gold:     " + Gold);

            //properties uppdateras under spelets gång...
        }

        public void GetGold()
        {
            // ta guld från monster
            // behövs både getgold OCH takegold???
        }

        public void BuyItem()  // ska ligga här eller i shoppen?
        {
            // köpa från shop med gold
            // öka strenght eller defense, anges av item?
            //minus gold
        }


        //metoder: attack(), gethit(),  givegold(), ......  ska kanske ligga i TheGame? gäller både monster och user

   
    }
}
