using zaverecnyUkol;
Database database = new Database();


Console.WriteLine("-----------------------------\nEvidence pojištěných\n-----------------------------");

Console.WriteLine("Vyberte si akci: ");
Console.WriteLine("1 - Přidat nového pojištěného");
Console.WriteLine("2 - Vyhledat pojištěného");
Console.WriteLine("3 - Výpis všech pojištěných");
Console.WriteLine("4 - Ukončit program");

char volba = '0';
while (volba != '4')
{
    switch (volba)
    {
        
        case '1':
            Console.WriteLine();
            Console.WriteLine("Přidat nového pojištěného:  ");
            database.PridejUzivatele();
            Console.WriteLine("\nData byla uložena.\n");
            Console.WriteLine("Pokračujte libovolnou klávesou");
            Console.ReadLine();
            database.Menu();
            break;
        case '2':
            Console.WriteLine();
            database.HledejUzivatele();
            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou");
            Console.ReadLine();
            database.Menu();
            
            break;
        
        case '3':
            Console.WriteLine();
            database.VypisUzivatele();
            Console.WriteLine("\n");
            Console.WriteLine("Pokračujte libovolnou klávesou");
            Console.ReadLine();
            database.Menu();
            break;

        case '4':
                      
            break;
        
    }

    volba = Console.ReadKey().KeyChar;
}


