using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // sleep...

namespace TheGame_JosefinPersson
{
    class TheGame
    {
        // deklarerar att det ska finnas 3 olika monster i the game
        public Boss boss { get; set; } // nödvändigt med get; set; ???
        public Monster mediumMonster { get; set; }
        public Monster miniMonster { get; set; }

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
                // 100 HP!!!
                Console.WriteLine("You found a HEALTH KIT!");              
                hero.Hp += 100;
            }
            else // 89% chans att man möter ett monster/boss
            {
                //fight!!!
                Fight(hero, miniMonster, mediumMonster, boss);

                if(hero.Level == 10)
                {
                    Console.WriteLine("YOU WIN!!!!");
                }
            }
        }
        public void Fight(Player hero, Monster miniMonster, Monster mediumMonster, Boss boss)
        {

            Console.WriteLine("FIGHT!");
            //------------------------------------------------------------------------------------------------------------------
            if (hero.Level >= 8)
            {
               

                Console.WriteLine("Boss!!!");
                //boss

                //boss
                boss = new Boss("Boss", 100, 200, 13, 12, 500, "rawr", "imma kill u", "Farewell cruel world", false);


                while (boss.Hp > 0 && hero.Hp > 0) // om BÅDE hero och monster LEVER
                {

                    if (hero.Hp > 0) // om hero LEVER
                    {
                        Random rnd = new Random();
                        int fightRnd = rnd.Next(10, 21);

                        Console.WriteLine("HERO attacks! monster hp before: " + boss.Hp);
                        boss.Hp -= ((hero.Strenght * (fightRnd / 10)) - boss.Defense);   // hero attack först
                        Console.WriteLine("monster hp after: " + boss.Hp);
                        Thread.Sleep(1000);

                        if (boss.Hp <= 0) // om monstret DÖR
                        {
                            Console.WriteLine("YOU SLAYED THE MONSTER!");
                            hero.Exp += boss.Exp;
                            hero.Gold += boss.Gold;
                            Console.WriteLine("gold: " + hero.Gold + " exp: " + hero.Exp + " /100");
                            if (hero.Exp >= 100) // LEVEL UP
                            {
                                hero.Level++;
                                Console.WriteLine("Level up!");
                                hero.Exp -= 100;
                                hero.Strenght++;
                                hero.Defense++;
                                hero.Hp = 100;
                                Console.WriteLine("updated stats: ");
                                hero.ShowStats();
                            }
                        }
                    }

                    if (boss.Hp > 0) // om monstret LEVER
                    {
                        // minimonster attack
                        Random rnd = new Random();
                        int fightRnd = rnd.Next(10, 21);

                        Console.WriteLine("MONSTER attacks! hero hp before: " + hero.Hp);
                        hero.Hp -= ((boss.Strenght * (fightRnd / 10)) - hero.Defense);
                        Console.WriteLine("hero hp after: " + hero.Hp);
                        Thread.Sleep(1000);

                        if (hero.Hp <= 0) // om hero DÖR
                        {
                            Console.WriteLine("game over");
                            // stäng av spelet... ELLER åter till huvudmenyn från "whats your name?"...
                            return;
                        }
                    }
                } // while loop slut
            } // medium monster fight

            //----------------------------------------------------------------------------------------------------------------
            else if (hero.Level >= 4)
            {
               

                Console.WriteLine("medium strenght monster!!!");
                // mediumMonster

                //medium monster
                mediumMonster = new Monster("Hugo", 80, 100, 10, 8, 300, "Mjau", "Attaaaack", "Im dead", false);

                while (mediumMonster.Hp > 0 && hero.Hp > 0) // om BÅDE hero och monster LEVER
                {

                    if (hero.Hp > 0) // om hero LEVER
                    {
                        Random rnd = new Random();
                        int fightRnd = rnd.Next(10, 21);

                        Console.WriteLine("HERO attacks! monster hp before: " + mediumMonster.Hp);
                        mediumMonster.Hp -= ((hero.Strenght * (fightRnd / 10)) - mediumMonster.Defense);   // hero attack först
                        Console.WriteLine("monster hp after: " + mediumMonster.Hp);
                        Thread.Sleep(1000);

                        if (mediumMonster.Hp <= 0) // om monstret DÖR
                        {
                            Console.WriteLine("YOU SLAYED THE MONSTER!");
                            hero.Exp += mediumMonster.Exp;
                            hero.Gold += mediumMonster.Gold;
                            Console.WriteLine("gold: " + hero.Gold + " exp: " + hero.Exp + " /100");
                            if (hero.Exp >= 100) // LEVEL UP
                            {
                                hero.Level++;
                                Console.WriteLine("Level up!");
                                hero.Exp = 0;
                                hero.Strenght++;
                                hero.Defense++;
                                hero.Hp = 100;
                                Console.WriteLine("updated stats: ");
                                hero.ShowStats();
                            }
                        }
                    }

                    if (mediumMonster.Hp > 0) // om monstret LEVER
                    {
                        // minimonster attack
                        Random rnd = new Random();
                        int fightRnd = rnd.Next(10, 21);

                        Console.WriteLine("MONSTER attacks! hero hp before: " + hero.Hp);
                        hero.Hp -= ((mediumMonster.Strenght * (fightRnd / 10)) - hero.Defense);
                        Console.WriteLine("hero hp after: " + hero.Hp);
                        Thread.Sleep(1000);

                        if (hero.Hp <= 0) // om hero DÖR
                        {
                            Console.WriteLine("game over");
                            // stäng av spelet... ELLER åter till huvudmenyn från "whats your name?"...
                            return;
                        }
                    }
                } // while loop slut
            } // medium monster fight
      //----------------------------------------------------------------------------------------------------------------
            else
            {
                

                Console.WriteLine("Baby mini monster!!!");      // miniMonster

                //mini monster
                miniMonster = new Monster("MiniBaby", 60, 80, 6, 4, 200, "Hi!", "Wanna play?", "*cries*", false);      // skapar ett nytt minimonster vid varje match... för att återställa hp m.m.

                while (miniMonster.Hp > 0 && hero.Hp > 0) // om BÅDE hero och monster LEVER
                {
                       
                    if(hero.Hp > 0) // om hero LEVER
                    {
                        Random rnd = new Random();
                        int fightRnd = rnd.Next(10, 21);

                        Console.WriteLine("HERO attacks! monster hp before: " + miniMonster.Hp);
                        miniMonster.Hp -= ((hero.Strenght * fightRnd) - miniMonster.Defense);   // hero attack först
                        Console.WriteLine("monster hp after: " + miniMonster.Hp);
                        Thread.Sleep(1000);

                        if (miniMonster.Hp <= 0) // om monstret DÖR
                        {
                            Console.WriteLine("YOU SLAYED THE MONSTER!");
                            hero.Exp += miniMonster.Exp;
                            hero.Gold += miniMonster.Gold;
                            Console.WriteLine("gold: " + hero.Gold + " exp: " + hero.Exp + " /100");
                            if (hero.Exp >= 100) // LEVEL UP
                            {
                                hero.Level++;
                                Console.WriteLine("Level up!");
                                hero.Exp = 0;
                                hero.Strenght++;
                                hero.Defense++;
                                hero.Hp = 100;
                                Console.WriteLine("updated stats: ");
                                hero.ShowStats();
                            }
                        }
                    }

                    if (miniMonster.Hp > 0) // om monstret LEVER
                    {
                        // minimonster attack
                        Random rnd = new Random();
                        int fightRnd = rnd.Next(10, 21);

                        Console.WriteLine("MONSTER attacks! hero hp before: " + hero.Hp);
                        hero.Hp -= ((miniMonster.Strenght * fightRnd) - hero.Defense);
                        Console.WriteLine("hero hp after: " + hero.Hp);
                        Thread.Sleep(1000);

                        if (hero.Hp <= 0) // om hero DÖR
                        {
                            Console.WriteLine("game over");
                            // stäng av spelet... ELLER åter till huvudmenyn från "whats your name?"...
                            return;
                        }
                    }
                } // while loop slut
            } // mini monster fight
            //-----------------------------------------------------------------------------------------------------------
        } // fight metod
    } // class
} //namespace
