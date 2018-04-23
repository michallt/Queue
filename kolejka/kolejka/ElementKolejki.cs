using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    public class ElementKolejki
    {
        public string wartosc_poczatkowa;
        public string wartosc;

        public ElementKolejki(string a)
        {
            wartosc_poczatkowa = a;
        }

        public string pokaz_wartosc_dla_pierwszego(string a)
        {
            return a;
        }

        public void pokaz_wartosci()
        {
            Console.Write(wartosc_poczatkowa+" ");
        }

        public void pokaz_wartosc_()
        {
            Console.WriteLine(wartosc_poczatkowa);
        }

        public string podaj_wartosc()
        {
            wartosc = Console.ReadLine();
            return wartosc;
        } 
    }
}
