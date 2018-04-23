using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    public class Menu
    {
        string[] elementy;
        int liczbaElementow, zaznaczony = 0, szerokosc;
        /// <summary>
        /// Konstruktor Menu
        /// </summary>
        /// <param name="liczbaElementow">Liczba elementów menu</param>
        public Menu(int liczbaElementow)
        {
            elementy = new string[liczbaElementow];
        }

        public void Dodaj(string element)
        {
            if (liczbaElementow < elementy.Length)
            {
                aktualizujSzerokosc(element);

                elementy[liczbaElementow++] = element;
            }

        }

        private void aktualizujSzerokosc(string element)
        {
            if (szerokosc < element.Length)
                szerokosc = element.Length;
        }

        private void Rysuj()
        {
            for (int i = 0; i < liczbaElementow; i++)
            {
                if (i == zaznaczony)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(elementy[i].PadRight(szerokosc));
            }
        }
        public int Dzialaj()
        {
            while (true)
            {
                Console.ResetColor();
                Console.Clear();
                Rysuj();
                ConsoleKeyInfo k = Console.ReadKey();
                switch (k.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (zaznaczony > 0) zaznaczony--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (zaznaczony < liczbaElementow - 1) zaznaczony++;
                        break;
                    case ConsoleKey.Enter:
                        return zaznaczony;

                }
            }

        }


    }
}
