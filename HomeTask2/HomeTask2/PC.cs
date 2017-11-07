using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    public class PC : Computer, ISleep
    {

        public PC(string PCAddress) : base(PCAddress){ }

        public void Sleep()
        {
            Console.WriteLine("PC in sleep mode!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("PC turn off!");
        }

        public override void TurnOn()
        {
            Console.WriteLine("PC turn on!");
        }

        public override string ToString()
        {
            return String.Format("{0}\n\t macAddress = {1}", GetType(), MacAddress);
        }

    }
}
