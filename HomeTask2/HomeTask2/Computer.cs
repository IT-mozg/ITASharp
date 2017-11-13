using System;

namespace HomeTask2
{
    public abstract class Computer
    {
        private string _macAddress;
        private string _name;

        public string MacAddress
        {
            get { return _macAddress; }
            set
            {
                _macAddress = value;
            }
        }

        public string Name { get => _name; set => _name = value; }

        public Computer(string name, string macAddress)
        {
            MacAddress = macAddress;
        }
        public Computer()
        {

        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}