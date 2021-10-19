using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class Boss // boss? stormonster?
    {
        //constuctor???

            public string Name { get; set; } = "Boss";   // exakt varför get; set;??  behövs den överallt??  
            public int Level { get; set; } = 10;
            public int Exp { get; set; } = 100;
            public int Hp { get; set; } = 150;
            public int Strenght { get; set; } = 60;
            public int Defense { get; set; } = 50;
            public int Gold { get; set; } = 200;
            public string CatchPhrase { get; set; } = "Rawr";
            public string AttackPhrase { get; set; } = "Imma kill u";
            public string DeathPhrase { get; set; } = "Farewell cruel world";
            private bool IsDead { get; set; } = false;  // private enligt marcus exempel, varför???

        public void GiveGold()
        {
            // ge guld till user när isdead = true
        }

        public void GiveExp()
        {
            // ge guld till user när isdead = true
        }

        //metoder: attack(), gethit(),          ska kanske ligga i TheGame? gäller både monster och user

        // metod som genererar ett monster som tar hänsyn till din level- ... static metod GenerateRandom(int level)  // ska kankse ligga i TheGame???
    }

}
