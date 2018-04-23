using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    public class Archiwum
    {
        public string przechwycenie_;
        public string do_tablicy;
        public void komunikat_dodano(ElementKolejki a)
        {
            Console.Clear();
            Console.Write("Dodano wartosc ");
            do_tablicy = "Dodano wartosc ";
            Console.WriteLine(przechwycenie_); 
        }

        public void komunikat_odjeto()
        {
            Console.Write("Odjeto wartosc ");
            do_tablicy = ("Odjeto wartosc ");
            Console.WriteLine(przechwycenie_);
        }

        public void komunikat_zapelniono()
        {
            Console.Write("Kolejke zapelniono! ");
            do_tablicy = ("Kolejke zapelniono!");
            //Console.WriteLine(przechwycenie_);
        }

        //public void komunikat_ile()
        //{
        //    Console.Write("Odjeto wartosc ");
        //    do_tablicy = ("Odjeto wartosc ");
        //}

        public void przekaz_przechwycenie(Kolejka a)
        {
            przechwycenie_ = a.przechwycenie;
        }

        



        public void wypisz_archiwum(Kolejka a)
        {
            Console.Clear();
            Console.WriteLine("Historia dzialan na kolejce");
            foreach (string item in a.archiwum) 
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
