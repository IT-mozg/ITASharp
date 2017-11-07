using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReferenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;

            int num = 5;
            Console.WriteLine(string.Format("First int value: {0}", num));
            ChangeValue(num);
            Console.WriteLine("int value after function: {0}", num);

            Element item = new Element();
            item.Code = 12;
            Console.WriteLine("Source value of reference type: {0}", item);
            ChangeReference(item);
            Console.WriteLine("Itate of reference type: {0}", item);

            Element e = new Element();
            e.Code = 1;
            Console.WriteLine("Source value of reference type: {0}", e);
            ChangeReferenceUsingNew(e);
            Console.WriteLine("Itate of reference type: {0}", e);

            Element e1 = new Element();
            e1.Code = 2;
            Console.WriteLine("Source value of assign reference type: {0}", e1);
            ChangeReferenceUsingAssign(e1);
            Console.WriteLine("Itate of assign reference type: {0}", e1);

            string s = "This is string!";
            Console.WriteLine(s);
            CangeString(s);
            Console.WriteLine(s);

            Console.ReadLine();
        }

        private static void CangeString(string s)
        {
            s = "My Text";
        }

        static void ChangeValue(int someNumber)
        {
            someNumber++;
        }

        static void ChangeReference(Element item)
        {
            item.Code = 23;
        }

        static void ChangeReferenceUsingNew(Element item)
        {
            item = new Element();
            item.Code = 23;
        }

        static void ChangeReferenceUsingAssign(Element item)
        {
            Element newItem = item;
            newItem.Code = 23;
        }
    }
}
