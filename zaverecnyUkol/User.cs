using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaverecnyUkol
{
    internal class User
    {
        
        private string jmeno;
        private string prijmeni;
        private int vek;
        private string telCislo;

        public User(string jmeno, string prijmeni, int vek, string telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelCislo = telCislo;

        }

        public string Jmeno
        { get; private set; }
        public string Prijmeni
        { get; private set; }
        public int Vek
        { get; private set; }
        public string TelCislo
        { get; private set; }


        public override string ToString()
        {
            return String.Format("{0} {1}, {2} let, telefon: {3}", Jmeno, Prijmeni, Vek, TelCislo);
        }

        
    }

}
