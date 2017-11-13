using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    public class PC : Computer, ISleep
    {
        private double _weight;
        private string _company;
        private int _year;

        public int Year { get => _year; set => _year = value; }
        public double Weight { get => _weight; set => _weight = value; }
        public string Company { get => _company; set => _company = value; }
        public PC():base()
        {

        }

        public PC(string name, string company, string macAddress, double weight, int year) : 
            base(name, macAddress)
        {
            Company = company;
            Weight = weight;
            Year = year;
        }

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
            return String.Format("{0}\n\t" +
                "macAddress = {1}\n\t" +
                "name = {2}\n\t" +
                "company = {3}\n\t" +
                "year = {4}\n\t" +
                "weight = {5}\n\t", GetType(), MacAddress, Name, Company, Year, Weight);
        }

    }
}
