﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    internal class Player   // behövs internal?  (från marcus exempel)
    {
        //constructor.....?

        public string Name { get; set; } = "";   // exakt varför get; set;??  behövs den överallt??                        namn = INPUT FRÅN USER (tas från program.cs)
        public int Level { get; set; } = 1; //startar på level 1
        public int Exp { get; set; } = 0; //0 Exp
        public int Hp { get; set; } = 100; //startar på 100 HP
        public int Strenght { get; set; } = 10; //startar på 10
        public int Defense { get; set; } = 10; //startar på 10
        public int Gold { get; set; } = 0; //startar på 0
        public string CatchPhrase { get; set; } = "Im the HEEROOO"; // för test................
        public string AttackPhrase { get; set; } = "I will save us!"; // för test................
        public string DeathPhrase { get; set; } = "Bye mama... ugh"; // för test................
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
        }

        public void GetGold()
        {
            // ta guld från monster
            // behövs både getgold OCH takegold???
        }

        public void BuyItem()  // ska ligga här eller i shoppen?
        {
            // köpa från shop med gold
            // öka strenght eller defense, anges av item
            //minus gold
        }


        //metoder: attack(), gethit() ......  ska kanske ligga i TheGame? gäller både monster och user

   
    }
}
