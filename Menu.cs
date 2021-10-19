using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame_JosefinPersson  
{
    class Menu
    {
        //constuctor..?

        
        public void RunMenu()  //menumetod
        {
            bool runMenu = true;
            while (runMenu)
            {
               // Console.Clear;      funkar ej...
                Console.WriteLine("1 spela");
                Console.WriteLine("2 show stats");
                Console.WriteLine("3 shop");
                Console.WriteLine("4 exit");
            }

            //ta input
            //---------------// snyggare sätt med tryparse
            //int choice = 0;
            //int.tryParse(Console.ReadLine(), out choice); 
            //---------------

            string userInputMenu = Console.ReadLine();
            int menuInputInt = 0;
            int.TryParse(userInputMenu, out menuInputInt);

            if (menuInputInt > 4 || menuInputInt < 0)
            {
                Console.WriteLine("1-4");
                Console.ReadKey();          // eller?
            }

            switch (menuInputInt)
            {
                case 1:
                    // TheGame.GoAdventuring();  //?
                    break;
                        case 2:
                    // Player.ShowStats();  //?
                    break;
                        case 3:
                    //shop
                    break;
                        case 4:
                    runMenu = false;
                    break;
                default:
                    break;
            }


        }
    }
}
