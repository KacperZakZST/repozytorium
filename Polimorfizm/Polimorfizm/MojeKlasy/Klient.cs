using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm.MojeKlasy
{
    internal class Klient
    {
        public string Nazwa { get; set; }
        public string NrTelefonu { get; set; }
        public string Kraj { get; set; }
        public decimal Kapital { get; set; }

        public Klient(string nazwa, string nrTelefonu, string kraj, decimal kapital)
        {
            Nazwa = nazwa;
            NrTelefonu = nrTelefonu;
            Kraj = kraj;
            Kapital = kapital;
        }

        public override string ToString()
        {
            return $"Klient: {Nazwa}, {NrTelefonu}, {Kraj}, kapitał: {Kapital}";
        }

        public decimal PoliczKapital()
        {
            return PoliczKapital(12); 
        }

        public decimal PoliczKapital(int liczbaMiesiecy)
        {
            decimal odsetki = 0.03m;
            decimal nowyKapital = Kapital;

            for (int i = 0; i< liczbaMiesiecy; i++)
            {
                nowyKapital += nowyKapital * odsetki;
            }

            return nowyKapital;
        }



    }
}
