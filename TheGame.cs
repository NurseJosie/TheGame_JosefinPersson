using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson
{
    class TheGame
    {
        // deklarerar att det ska finnas 3 olika monster i the game
        public Boss boss { get; set; } // nödvändigt med get; set; ???
        public Monster mediumMonster { get; set; }

        public Monster miniMonster { get; set; }

        public TheGame() // constructor
        {
            //boss
            boss = new Boss("Boss", 100, 1500, 5, 50, 200, "rawr", "imma kill u", "Farewell cruel world", false); 

            //medium monster
            mediumMonster = new Monster("Hugo", 50, 1000, 5, 30, 100, "Mjau", "Attaaaack", "Im dead", false);


            
        }
        // go adventure-metod, själva spelet!
        public void GoAdventuring(Player hero)
        {
            Random rnd = new Random(); 
            int chance = rnd.Next(1, 101);

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
                Console.WriteLine("You found a MAX HEALTH KIT!");                  // hur? 
                hero.Hp = 100;
            }
            else // 89% chans att man möter ett monster/boss
            {
                //fight!!!
                Fight(hero);

                if(hero.Level == 10)
                {
                    Console.WriteLine("YOU WIN!!!!");
                }
            }
        }
        public void Fight(Player hero)
        {

            Random rnd = new Random();
            int fightRnd = rnd.Next(10,30);

            Console.WriteLine("FIGHT!");

            if (hero.Level > 8)
            {
                Console.WriteLine("Boss!!!");
                //boss

            }
            else if (hero.Level > 4)
            {
                Console.WriteLine("medium strenght monster!!!");
                // mediumMonster
            }
            else
            {
                Console.WriteLine("Baby mini monster!!!");      // miniMonster

                //mini monster
                miniMonster = new Monster("MiniBaby", 10, 1000, 1, 1, 500, "Hi!", "Wanna play?", "*cries*", false);

                while (miniMonster.Hp > 1 && hero.Hp > 1)  
                {
                        Console.WriteLine("hero attacks! monster hp before: " + miniMonster.Hp);
                        miniMonster.Hp -= ((hero.Strenght * (fightRnd / 10)) - miniMonster.Defense);   // hero attack först
                        Console.WriteLine("monster hp after: " + miniMonster.Hp);

                    if (miniMonster.Hp < 1)
                    {
                        Console.WriteLine("monster is dead");
                        hero.Exp += miniMonster.Exp;
                        hero.Gold += miniMonster.Gold;
                        Console.WriteLine("gold: " + hero.Gold + " exp: " + hero.Exp + " /100");
                        if (hero.Exp >= 100)
                        {
                            hero.Level++;
                            Console.WriteLine("Level up!");
                            hero.Exp = 0;
                            hero.Strenght += 5;
                            hero.Defense += 5;
                            hero.Hp = 100;
                            Console.WriteLine("updated stats: ");
                            hero.ShowStats();
                            return;
                        }
                        return;
                    }

                    if (miniMonster.Hp > 1 && hero.Hp > 1)
                    {
                        // minimonster attack
                        Console.WriteLine("monster attacks! hero hp before: " + hero.Hp);
                        hero.Hp -= ((miniMonster.Strenght * (fightRnd / 10)) - hero.Defense);
                        Console.WriteLine("hero hp after: " + hero.Hp);

                        if (hero.Hp < 1)
                        {
                            Console.WriteLine("game over");
                                                                            // åter till huvudmenyn med ord. stats.............................
                            return;
                        }
                    }

                } // while loop slut                     
            } // mini monster fight
        } // fight metod
    } // class
} //namespace
