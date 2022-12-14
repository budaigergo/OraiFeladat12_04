using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OraiFeladat12_04
{
    internal class felhaszn
    {
        int id;
        string nev;
        DateTime szuletes;
        string kep;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuletes { get => szuletes; set => szuletes = value; }
        public string Kep { get => kep; set => kep = value; }

        public felhaszn(int id, string nev, DateTime szuletes, string kep)
        {
            Id = id;
            Nev = nev;
            Szuletes = szuletes;
            Kep = kep;
        }
        public override string ToString()
        {
            return Nev;
        }        }
    }

