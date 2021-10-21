using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class TheGame
    {
        //--------------- vad av detta ska ligga här/ i menu/ i program.cs???
        //game over-metod....
        //---------------

        // go adventure-metod, själva spelet!
        public void GoAdventuring()
        {
          
            Random rnd = new Random(); 
            int chance = rnd.Next(1, 100);

            if (chance < 10) // 9% chans att man bara hittar gräs....
            {
                //gräs
                // press enter to continue
                return;
            }
            else if (chance == 11)  //   1% chans
            {
                // återställd HP!!!
            }
            else // 89% chans att man möter ett monster
            {
                //fight!!!


               // public void Fight()
                //{
               // while(hero == isDead) {GAME OVER}
               //while(boss/monster == isDead) {vinstmetod...? }

                //}

                //fight-metod: user anfall sedan monster anfall(attackens skada: random mellan styrka och styrka*2, skadan blir styrka - försvar. ),
                //hp ner(beror på attackens skada), exp upp(beror på monstrets angivna exp som den ska släppa), monster släpper guld(RANDOM summa!), fraser...

                //om både spelare och monster lever, loopa en omgång till
                // monster hp 0, åter till startmenyn med uppdaterade stats(plus exp(ev. ökad level), plus guld)

                // game over vid user hp 0, åter till startmenyn med ord. stats
                // om level 10, du vinner hela äventyret
            }
        }
    }
}
