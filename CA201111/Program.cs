using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CA201111
{
    class Program
    {
        static void Main()
        {
            var k01 = new Kutya("Bodri", new DateTime(2018, 12, 16), 3);

            Console.WriteLine($"{k01.Nev} {k01.Kor} éves");
            Console.WriteLine($"{k01.Nev}nak {k01.Labak} lába van");

            Console.ReadKey();
        }
    }
}
