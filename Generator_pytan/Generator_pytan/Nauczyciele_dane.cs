using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator_pytan
{
    class Nauczyciele_dane
    {
        //Atrybuty klasy
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public String Stopien { get; set; }
        public String Przedmiot { get; set; }
        public String Login { get; set; }
        public String Haslo { get; set; }

        public static List<Nauczyciele_dane> listaNauczycieli = new List<Nauczyciele_dane>();//Utworzenie nowej listy nauczycieli

        // Zmienne przydatne
      
        public static string nazwa_pliku_nauczyciele;

    }
}
