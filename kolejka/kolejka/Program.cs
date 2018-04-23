using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolejka
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranGlowny e1 = new EkranGlowny();
            e1.dodaj_pozycje_menu();

            Console.ReadKey();
        }
    }
}
