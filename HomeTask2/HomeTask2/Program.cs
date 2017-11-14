using System;

namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadLine();
        }

        static void Start()
        {
            try
            {
                Console.Write("Enter size: ");
                int size = Int32.Parse(Console.ReadLine());
                Computer[] comps = new Computer[size];
                int i = -1;
                int add;
                while (i+1 < size)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("To add Mac press \"1\";");
                    Console.WriteLine("To add PC press \"2\";");
                    Console.WriteLine("To print array press \"0\"");
                    Console.Write("Add: ");
                    add = Int32.Parse(Console.ReadLine());
                    switch (add)
                    {
                        case 1:
                            Console.WriteLine("Fill properties: Name, Company, MacAddress, Weight, Year");
                            i++;
                            comps[i] = new Mac() {
                                Name = Console.ReadLine(),
                                Company = Console.ReadLine(),
                                MacAddress = Console.ReadLine(),
                                Weight = Double.Parse(Console.ReadLine()),
                                Year = Int32.Parse(Console.ReadLine())
                            };
                            break;
                        case 2:
                            Console.WriteLine("Fill properties: Name, Company, MacAddress, Weight, Year");
                            i++;
                            comps[i] = new PC() {
                                Name = Console.ReadLine(),
                                Company = Console.ReadLine(),
                                MacAddress = Console.ReadLine(),
                                Weight = Double.Parse(Console.ReadLine()),
                                Year = Int32.Parse(Console.ReadLine())
                            };
                            break;
                        case 0:
                            PrintArr(comps, i);
                            break;
                        default:
                            Console.WriteLine("Unknown numb!");
                            break;
                    }
                }
                PrintArr(comps, i);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown number");
                Console.WriteLine("Bay!");
            }

        }

        private static void PrintArr(Computer[] comps, int i)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            for(int k = 0; k <= i; k++)
            {
                Console.WriteLine(comps[k]);
            }
        }
    }
}
