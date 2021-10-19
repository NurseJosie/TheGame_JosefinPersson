using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class Monster : Boss    //minimonster,   konstigt när monster ärver från boss så alla bossar är monster men alla monster är inte bossar.....?!?!?!
    {
        // ärvd klass
        //---------------- hur skapar jag en ny generation monster...? skapa 2-3 olika minimonster i olika levels man kan möta...
        //constuctor
        //properties: namn(string ...), level(int x), exp att ge till user vid vinst(int x), hp(int x), styrka(int x), försvar(int x), guld att ge till user vid vinst(int x)  {get: set:} !!! 
        // metoder: attack(), gethit(), givegold(), roliga fraser...

        // bool isDead (private)???  enligt markus exempel, fattar inte riktigt...

        // metod som genererar ett monster som tar hänsyn till din level- ... static metod GenerateRandom(int level)  // ska kankse ligga i TheGame???
        //---------------
    }
}
