using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    public class EkranGlowny
    {
        Menu MenuGlowne = new Menu(6);

        ElementKolejki e1 = new ElementKolejki("1");
        ElementKolejki e2 = new ElementKolejki("2");
        ElementKolejki e3 = new ElementKolejki("3");
        ElementKolejki e4 = new ElementKolejki("4");
        ElementKolejki e5 = new ElementKolejki("5");

        Kolejka k1 = new Kolejka();
        Archiwum a1 = new Archiwum();

        public void kolor()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
        }

        public virtual void dodaj_pozycje_menu()
        {
            MenuGlowne.Dodaj("Wypelnij kolejke");
            MenuGlowne.Dodaj("Zobacz aktualny stan kolejki");
            MenuGlowne.Dodaj("Dodaj element do kolejki");
            MenuGlowne.Dodaj("Usun element kolejki");
            MenuGlowne.Dodaj("Archiwum");
            MenuGlowne.Dodaj("Wyjdz");

            while (true)
            {
                switch (MenuGlowne.Dzialaj())
                {
                    case 0:
                        kolor();
                        k1.wypelnij_kolejke(e1,e2,e3,e4,e5,a1,k1.archiwum);
                        break;
                    case 1:
                        EkranStanuKolejki ek1 = new EkranStanuKolejki();
                        kolor();
                        k1.pokaz_cala_kolejke();
                        k1.ile_w_kolejce(k1.element);
                        k1.pierwszy_element(k1.element);
                        k1.ostatni_element(k1.element);
                        break;
                    case 2:
                        kolor();
                        EkranDodawania ek2 = new EkranDodawania();
                        k1.dodaj_element_do_kolejki(e1, a1, k1.archiwum,k1);
                        break;
                    case 3:
                        kolor();
                        EkranUsuwania ek3 = new EkranUsuwania();
                        k1.usun_element_kolejki(k1.element, a1, k1.archiwum, k1, e1);
                        break;
                    case 4:
                        kolor();
                        EkranArchiwum ek4 = new EkranArchiwum();
                        a1.wypisz_archiwum(k1);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;

                }
            }
        }

        
    }
}
