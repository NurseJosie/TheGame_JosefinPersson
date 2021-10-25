using System;

namespace TheGame_JosefinPersson
{
    class Program                      
    {
        static void Main(string[] args)
        {

            //skapa spelarobjekt i början av spelet, fråga efter spelarens namn.
            Console.WriteLine("Whats your name?");
            string userInputName = Console.ReadLine();  // behöver man kolla att det är ett namn...?

            Player hero = new Player();
            hero.Name = userInputName;
            Console.WriteLine("Hello " + hero.Name + "! Let's begin our adventure..!");

            //instansiera The Game
            TheGame game = new TheGame();

            // anropa huvudmenyn
            Menu menu = new Menu(); // skapa en meny av Menu-klassen
            menu.RunMenu(hero, game); 



        }
    }
}
