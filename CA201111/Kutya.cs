using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201111
{
    class Kutya
    {
        public string Nev { private set; get; }
        private DateTime _szul;
        public DateTime Szul
        {
            private set
            {
                if (value > DateTime.Now) 
                    throw new Exception("sajnos a kutyák nem tudnak időutazni");
                _szul = value;
            }
            get { return _szul; }
        }      

        public int Kor
        {
            get
            {
                return (int)Math.Floor((DateTime.Now - Szul).TotalDays / 365);
            }
        }

        private int _labak = 4;
        public int Labak
        {
            set
            {
                if (value > 4 || value < 0) throw new Exception("nem lehet ennyi lába egy kutyának");
                _labak = value;
            }
            get { return _labak; }
        }


        //metódusok (method)
        public void Ugat()
        {
            Console.WriteLine($"{Nev} mondja: vau-vau!");
        }

        public bool Szereti(string dolog)
        {
            if (dolog == "csont") return true;
            if (dolog == "kelbimbó") return false;
            throw new Exception($"a {dolog}-ról nem ismert, hogy szereti-e ez a kutya");
        }

        public Kutya(string nev, DateTime szul)
        {
            Nev = nev;
            Szul = szul;
        }
        public Kutya(string nev, DateTime szul, int labak) : this(nev, szul)
        {
            Labak = labak;
        }

    }

}
