using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Adresa_Id { get; set; }
        public Adresa Adresa { get; set; }
    }

    public class Adresa
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        public string Ulica { get; set; }
        public string Broj { get; set; }

        public Osoba Osoba { get; set; }
    }
}
