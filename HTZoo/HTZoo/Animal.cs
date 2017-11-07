using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTZoo
{
    public class Animal
    {
        private string _name;
        private int _age;
        private float _weight;

        public float Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Unacceptable weight!");
                _weight = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if(value < 0)
                    throw new ArgumentException("Unacceptable age!");
                _age = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public virtual int GetNumb(int i)
        {
            return 5;
        }

        static Animal()
        {
            Console.WriteLine("static ctor");
        }

        public Animal()
        {
            Console.WriteLine("ctor Animal");
        }

        public Animal(string name, int age, float weight)
        {
            Console.WriteLine("ctor Animal 2");
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return String.Format("{0} [\n"
                + "\tName: {1};\n"
                + "\tAge: {2};\n"
                + "\tWeight: {3};\n]",
                GetType(), Name, Age, Weight);
        }
    }
}
