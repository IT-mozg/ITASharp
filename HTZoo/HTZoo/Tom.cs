using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZoo
{
    public class Tom : Cat
    {
        static Tom()
        {
            Console.WriteLine("static Tom");
        }
        public Tom()
        {
            Console.WriteLine("Tom ctor");
        }
    }
}
