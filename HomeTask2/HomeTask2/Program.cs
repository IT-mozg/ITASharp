using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        { 
            const int count = 3;
            Computer[] comps = new Computer[count] {
                new Mac("1".GetHashCode().ToString()),
                new Mac("2".GetHashCode().ToString()),
                new PC("3".GetHashCode().ToString())
            };

            for(int i = 0; i < comps.Length; i++)
            {
                Console.WriteLine(comps[i]);
                comps[i].TurnOn();
                comps[i].TurnOff();
            }

            ISleep[] icomps = new ISleep[count] {
                new Mac("1".GetHashCode().ToString()){ MacAddress = "1".GetHashCode().ToString()},
                new Mac("2".GetHashCode().ToString()){ MacAddress = "2".GetHashCode().ToString()},
                new PC("3".GetHashCode().ToString()){ MacAddress = "3".GetHashCode().ToString()}
            };

            foreach(var c in icomps)
            {
                Console.WriteLine(c);
                c.Sleep();
            }

            Console.ReadLine();
        }
    }
}
