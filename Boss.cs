using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class Boss : Monster   // ärvd klass,  varför behöver jag constructor i ärvd klass????!
    {
        public Boss()
        {
            //tom constructor
        }
        public Boss(string name, int exp, int hp, int strenght, int defense, int gold, string catchPhrase, string attackPhrase, string deathPhrase, bool isDead)
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


    }
}
