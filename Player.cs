using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class Player                                                                                                                                                                       // behövs internal?  (från marcus exempel)
    {
                                                                                                                                                                                        //constructor.....?

        public string Name { get; set; } = "";                                                                                                                                          // exakt varför get; set;??  behövs den överallt??
        public int Level { get; set; } = 1; //startar på level 1
        public int Exp { get; set; } = 0; //0 Exp
        public int Hp { get; set; } = 100; //startar på 100 HP                                                                                                                                SET HP<0 = 0, MAX HP 300........ HUR???
        public int Strenght { get; set; } = 6; //startar på 10
        public int Defense { get; set; } = 5; //startar på 10
        public int Gold { get; set; } = 0; //startar på 0
        public string CatchPhrase { get; set; } = "Im the HEEROOO";                                                                 // för test................
        public string AttackPhrase { get; set; } = "I will save us!";                                                               // för test................
        public string DeathPhrase { get; set; } = "Bye mama... ugh";                                                                 // för test................
        public bool IsDead { get; set; } = false;                                                                                                                                // private enligt marcus exempel, varför???

        public void ShowStats()  // anropas via switch i huvudmenyn
        {
            Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
            Console.WriteLine("Name:     " + Name);
            Console.WriteLine("Level:    " + Level);
            Console.WriteLine("EXP:      " + Exp + "/100");
            Console.WriteLine("HP:       " + Hp);
            Console.WriteLine("Strenght: " + Strenght);
            Console.WriteLine("Defense:  " + Defense);
            Console.WriteLine("Gold:     " + Gold);
        }

        public void TakeGold()
        {
                                                                                                     // ta guld från monster när monster.isdead = true
            
        }

        public void BuyItem()                                                                                                                                                           // ska ligga här eller i shoppen?
        {
                                                                                                        // köpa från shop med gold
                                                                                                        // öka strenght eller defense, anges av item
                                                                                                        //minus gold
        }

        public void TakeExp()
        {
                                                                                             // ta epx från monster när isdead = true
        }


                                                                                                                                                          //metoder: attack(), gethit() ......  ska kanske ligga i TheGame? gäller både monster och user


    }
}
