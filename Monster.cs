﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class Monster    
    {
       






        //constructor.......?

        public string Name { get; set; }   // exakt varför get; set;??  behövs den överallt??  
        public int Exp { get; set; }
        public int Hp { get; set; }
        public int Strenght { get; set; }
        public int Defense { get; set; }
        public int Gold { get; set; }
        public string CatchPhrase { get; set; }
        public string AttackPhrase { get; set; }
        public string DeathPhrase { get; set; }
        public bool IsDead { get; set; } // private enligt marcus exempel, varför???


        public Monster()
        {
            //tom constructor
        }
        public Monster(string name, int exp, int hp, int strenght, int defense, int gold, string catchPhrase, string attackPhrase, string deathPhrase, bool isDead)
        {
            Name = name;
            Exp = exp;
            Hp = hp;
            Strenght = strenght;
            Defense = defense;
            Gold = gold;
            CatchPhrase = catchPhrase;
            AttackPhrase = attackPhrase;
            DeathPhrase = deathPhrase;
            IsDead = isDead;
        }



        //metoder: attack(), gethit(),          ska kanske ligga i TheGame? gäller både monster och user
    }
}

