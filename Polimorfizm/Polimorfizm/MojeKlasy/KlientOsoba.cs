using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.MojeKlasy
{
    internal class KlientOsoba : Klient
    {
        public string imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }

        public KlientOsoba(string imie, string nazwisko, DateTime DataUrodzenia, string nrTelefonu,
        string kraj, decimal Kapital) : base("osoba prawna", nrTelefonu, kraj, Kapital)
        {
            this.imie = imie;
            Nazwisko = nazwisko;
            DataUrodzenia = DataUrodzenia;
        }

        public override string ToString()
        {
            return $"Imie: {imie}, Nazwisko {Nazwisko}, DataUrodzenia {DataUrodzenia}, {base.ToString()}";
        }

        public decimal PoliczKapital()
        {
            decimal kapital = Kapital;
            kapital = kapital * 1.02m;
            return kapital;
        }

    }
}
