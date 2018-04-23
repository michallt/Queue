using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    public class Kolejka
    {
        public List<ElementKolejki> element = new List<ElementKolejki>();
        public List<string> archiwum = new List<string>();

        public string przechwycenie;

        public void wypelnij_kolejke(ElementKolejki a, ElementKolejki b, ElementKolejki c, ElementKolejki d, ElementKolejki e,Archiwum f,List<string> g)
        {
            Console.Clear();
            element.Add(a);
            element.Add(b);
            element.Add(c);
            element.Add(d);
            element.Add(e);
            f.komunikat_zapelniono();
            g.Add(f.do_tablicy);
            Console.ReadKey();
            Console.Clear();
        }

        public void pokaz_cala_kolejke()
        {
            Console.Clear();
            Console.Write("Twoja kolejka to: ");
            foreach (ElementKolejki item in element)
            {
                item.pokaz_wartosci();
            }
            Console.WriteLine();
        }

        public void usun_element_kolejki(List<ElementKolejki> a, Archiwum b, List<string> c, Kolejka d,ElementKolejki e)
        {
            Console.Clear();
            przechwycenie = a[0].wartosc_poczatkowa;
            b.przekaz_przechwycenie(d);
            a.RemoveAt(0);
            b.komunikat_odjeto();
            c.Add(b.do_tablicy+b.przechwycenie_);
            Console.ReadKey();
            Console.Clear();
        }

        public void dodaj_element_do_kolejki(ElementKolejki a,Archiwum b,List<string> c, Kolejka d)
        {
            Console.Clear();
            Console.WriteLine("Podaj wartosc jaka chcesz dodac do kolejki");
            a.wartosc = a.podaj_wartosc();
            przechwycenie = a.wartosc;
            b.przekaz_przechwycenie(d);
            ElementKolejki e1 = new ElementKolejki(a.wartosc);
            d.element.Add(e1);
            b.komunikat_dodano(e1);
            c.Add(b.do_tablicy+a.wartosc);
            Console.ReadKey();
            Console.Clear();
        }

        public void ile_w_kolejce(List<ElementKolejki> a)
        {
            Console.WriteLine("Aktualnie w kolejce znajduje sie "+a.Count+ " wartosci");
            //Console.WriteLine();
        }

        public void pierwszy_element(List<ElementKolejki> a) 
        {
            Console.WriteLine("Pierwszym elementem listy jest: " + a.First().wartosc_poczatkowa);
        }

        public void ostatni_element(List<ElementKolejki> a)
        {
            Console.WriteLine("Ostatnim elementem listy jest: " + a.Last().wartosc_poczatkowa);
            Console.ReadKey();
            Console.Clear();
        }



    }
}
