using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnyUkol
{
    internal class Database
    {
        
        private List<User> list;

        public Database()
        {

            list = new List<User>();
        }

        /// <summary>
        /// Přidání uživatele
        /// </summary>
        public void PridejUzivatele()
        {
            Console.Write("Zadejte jméno: ");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Nesprávné zadání. Zadejte jméno znovu:");
            }

            Console.Write("Zadejte příjmení: ");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Nesprávné zadání. Zadejte příjmení znovu:");
            }

            Console.Write("Zadejte věk: ");
            int vek;
            while ((!int.TryParse(Console.ReadLine(), out vek)) | ((vek > 110) | (vek <= 0)))
            {
                Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

            }


            Console.Write("Zadejte telefonní číslo: ");
            string telCislo;
            while (string.IsNullOrWhiteSpace(telCislo = Console.ReadLine()) | (telCislo.Length < 9))
            {
                Console.WriteLine("Nesprávné zadání. Zadejte telefon znovu:");
            }

            list.Add(new User(jmeno, prijmeni, vek, telCislo));
        }

        /// <summary>
        /// Výpis všech uživatelů
        /// </summary>
        public void VypisUzivatele()
        {
            int pocet = 0;
            foreach (var uzivatele in list)
            {
                pocet++; 

            }
            if (pocet == 0)
                Console.WriteLine("Neexistují žádné pojištěné osoby. ");
            else
                Console.WriteLine("Jsou registrovány tyto osoby: ");
                Console.WriteLine();
                foreach (var uzivatele in list)
                {
                    
                    Console.WriteLine(uzivatele);
                }

        }
        /// <summary>
        /// Hledání uživatele dle jména a příjmení
        /// </summary>

        public void HledejUzivatele()
        {
            Console.WriteLine("Zadejte jméno: ");
            string hledaneJmeno = Console.ReadLine().ToLower();

            Console.WriteLine("Zadejte příjmení: ");
            string hledanePrijmeni = Console.ReadLine().ToLower();

            foreach (var item in list)
            {

                if ((item.Jmeno.ToLower() == hledaneJmeno && item.Prijmeni.ToLower() == hledanePrijmeni)
                    || (item.Jmeno.ToUpper() == hledaneJmeno && item.Prijmeni.ToUpper() == hledanePrijmeni))
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                    return;
                }
            }



            Console.WriteLine("Uživatel nenalezen");




        }
                  

        public void Menu()
        {
            Console.WriteLine("Vyberte si akci: ");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vyhledat pojištěného");
            Console.WriteLine("3 - Výpis všech pojištěných");
            Console.WriteLine("4 - Ukončit program");
        }

    }
}
