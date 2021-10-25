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
        
        public void RunMenu(Player hero, TheGame game)  //menumetoden, instansieras och anropas via programklassen
        {
            bool runMenu = true;
            while (runMenu)
            {
                Console.WriteLine("1 spela");
                Console.WriteLine("2 show stats");
                Console.WriteLine("3 shop");
                Console.WriteLine("4 exit");

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
                        game.GoAdventuring(hero); 
                        break;
                    case 2:
                       hero.ShowStats();  
                        break;
                    case 3:
                        //shop
                        break;
                    case 4:
                        runMenu = false;
                        break;
                    default:
                        Console.WriteLine("Enter a number between 1-4");
                        break;
                }
            }
        }
    }
}
