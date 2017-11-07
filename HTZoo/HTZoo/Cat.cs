using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZoo
{
    public class Cat : Animal
    {
        public int i;

        static Cat()
        {
            Console.WriteLine("static Cat");
        }
        public Cat()
        {
            Console.WriteLine("ctor car");
        }

        public override int GetNumb(int i)
        {
            return 7;
        }

        public int GetNumb(int i, int s)
        {
            return 9;
        }

        public Cat(string name, int age, float w) : base(name, age, w)
        {
            Console.WriteLine("ctor car");
            this.i = age;
        }

    }
}
