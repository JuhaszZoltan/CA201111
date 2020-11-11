using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201111
{
    class Kutya
    {
        //auto-propety
        public string Nev { private set; get; }
        //field ("mező" in HUN)
        private DateTime _szul;
        //property ("jellemző" in HUN)
        public DateTime Szul
        {
            //public prop-on belül private set
            private set
            {
                if (value > DateTime.Now) 
                    throw new Exception("sajnos a kutyák nem tudnak időutazni");
                _szul = value;
            }
            get { return _szul; }
        }      

        //only-get property ("csak lovasható jellemző" in HUN ::: NEM ÖSSZEKEVERENDŐ a readonly mezővel)
        public int Kor
        {
            get
            {
                return (int)Math.Floor((DateTime.Now - Szul).TotalDays / 365);
            }
        }

        //mező alapértelmezett értékkel
        private int _labak = 4;
        public int Labak
        {
            set
            {
                if (value > 4 || value < 0) 
                    //rise an exception ("kivételt dobni" in HUN aka. "hibaüzenet")
                    throw new Exception("nem lehet ennyi lába egy kutyának");
                _labak = value;
            }
            get { return _labak; }
        }

        //method ("tagfüggvény" in HUN ::: fura, de akkor is tagfüggvénynek hívjuk, ha valójában eljárás... magyar nyelv csodái)
        public void Ugat()
        {
            Console.WriteLine($"{Nev} mondja: vau-vau!");
        }

        public bool Szereti(string dolog)
        {
            if (dolog == "csont") return true;
            if (dolog == "zsömle") return true;
            if (dolog == "kelbimbó") return false;
            throw new Exception($"a {dolog}-ról nem ismert, hogy szereti-e ez a kutya");
        }

        //constructor ("konstruktor" in HUN ::: na EZT sikerült megfelelően "magyarosítani :'D)
        public Kutya(string nev, DateTime szul)
        {
            Nev = nev;
            Szul = szul;
        }
        //constructor-overload + constructor-inheritence
        //(overloading-ra nem tudom van-e magyar szó, az con-inh-et "származtatott konstruktor"nak szokták hívni)
        public Kutya(string nev, DateTime szul, int labak) : this(nev, szul)
        {
            Labak = labak;
        }

    }

}
