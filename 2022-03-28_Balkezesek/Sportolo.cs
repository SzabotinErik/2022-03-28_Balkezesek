using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_03_28_Balkezesek
{
    class Sportolo
    {
        public string Nev { get; set; }
        public string edatum { get; set; }
        public string udatum { get; set; }
        public int Suly { get; set; }
        public int magassag { get; set; }

        public Sportolo(string sor)
        {
            string[] t = sor.Split(';');
            Nev = t[0];
            edatum = t[1];
            udatum =[2];
            Suly = int.Parse(t[3]);
            magassag = int.Parse(t[4]);
        }

    }
}
