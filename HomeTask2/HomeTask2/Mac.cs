using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    public class Mac : Computer, ISleep
    {
        public Mac(string macAddress) : base(macAddress){}

        public void Sleep()
        {
            Console.WriteLine("Mac in sleep mode!");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Mac turn off!");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Mac turn on!");
        }
        public override string ToString()
        {
            return String.Format("{0}\n\t macAddress = {1}", GetType(), MacAddress);
        }
    }
}
