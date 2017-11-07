using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace width
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 11;
            int[] arr = new int[size] { 1, 2, 2, 1, 1, 2,2,2,2,3, 3 };
            Dictionary<int, int> d = new Dictionary<int, int> ();
            int lastId;
            for (int i = 0; i < size - 1; i++)
            {
                if (!d.ContainsKey(arr[i]))
                {
                    lastId = i;
                    for (int j = i + 1; j < size; j++)
                    {
                        if (arr[i] == arr[j]) lastId = j;
                    }
                    d.Add(arr[i], lastId - i + 1);
                }
            }
            var min = d.First();
            foreach(var v in d)
            {
                if (v.Value < min.Value) min = v;
            }
            Console.WriteLine("Key: {0} Value: {1}", min.Key, min.Value);
            Console.ReadLine();
        }
    }
}
