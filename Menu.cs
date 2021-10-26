using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson  
{
    class Menu
    {
        //constuctor.....?
        
        public void RunMenu(Player hero, TheGame game, Shop shop, Menu menu)  //menumetoden, instansieras och anropas via programklassen
        {
            bool runMenu = true;
            while (runMenu)
            {
                Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");
                Console.WriteLine("1) Go adventuring!");
                Console.WriteLine("2) Show stats");
                Console.WriteLine("3) Go shopping");
                Console.WriteLine("4) Exit The Game");
                Console.WriteLine("~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~.~");

                //ta input
                string userInputMenu = Console.ReadLine();
               // Console.Clear;    //  funkar ej...
                int menuInputInt = 0;
                int.TryParse(userInputMenu, out menuInputInt);

                if (menuInputInt > 4 || menuInputInt < 0)
                {
                    Console.WriteLine("1-4");
                    Console.ReadKey();          // eller console.readline?
                }

                switch (menuInputInt)
                {
                    case 1:
                        Console.Clear();
                        game.GoAdventuring(hero, menu); 
                        break;
                    case 2:
                        Console.Clear();
                       hero.ShowStats();  
                        break;
                    case 3:
                        Console.Clear();
                        shop.RunShopMenu(hero, game);
                        break;
                    case 4:
                        runMenu = false;
                        // runShopMenu = false;    så att hela spelet avslutas ....
                        break;
                    default:
                        Console.WriteLine("Enter a number between 1-4");
                        break;
                }
            }
        }
    }
}
