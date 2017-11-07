using System;

namespace HomeTask2
{
    public abstract class Computer
    {
        private string _macAddress;

        public string MacAddress
        {
            get { return _macAddress; }
            set
            {
                _macAddress = value;
            }
        }

        public Computer(string macAddress)
        {
            MacAddress = macAddress;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}