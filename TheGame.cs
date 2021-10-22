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
        public void GoAdventuring(Player hero)
        {
          
            Random rnd = new Random(); 
            int chance = rnd.Next(1, 100);

            if (chance < 10) // 9% chans att man bara hittar gräs....
            {
                //gräs
                Console.WriteLine("You only found grass!");
            
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else if (chance == 11)  //   1% chans
            {
                // återställd HP!!!
                Console.WriteLine("You found a MAX HEALTH KIT!");
            }
            else // 89% chans att man möter ett monster/boss
            {
                //fight!!!
                Console.WriteLine("FIGHT!");

                if(hero.Level > 8)
                {
                    Console.WriteLine("Boss!!!");
                    //boss
                }
                else if(hero.Level > 4)
                {
                    Console.WriteLine("medium strenght monster!!!");
                    // mediumMonster
                }
                else
                {
                    Console.WriteLine("Baby mini monster!!!");
                    // miniMonster
                }

               // public void Fight()
                //{
               // while(hero == isDead) {GAME OVER}
               //while(boss/monster == isDead) {vinstmetod...? }

                //}

                //fight-metod: user anfall sedan monster anfall(attackens skada: random mellan styrka och styrka*2, skadan blir styrka - försvar. ),
                //hp ner(beror på attackens skada), exp upp(beror på monstrets angivna exp som den ska släppa), monster släpper guld(RANDOM summa!), fraser...

                //om både spelare och monster lever, loopa en omgång till
                // monster hp 0, åter till startmenyn med uppdaterade stats(plus exp(ev. ökad level), plus guld)


                if(hero.IsDead)
                {
                    Console.WriteLine("GAME OVER");
                    //åter till startmenyn med ordinarie stats!!!
                }

                if(hero.Level == 10)
                {
                    Console.WriteLine("YOU WIN!!!!");
                }
            }
        }
    }
}
