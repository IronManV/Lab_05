using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Employed employee1 = new Employed();
            employee1.Age = 20;
            employee1.Salary = 4000.0;

            Boss employee2 = new Boss();
            employee2.Age = 40;
            employee2.Salary = 8000.0;
            employee2.BonusSalary = 1000.0;

            Console.WriteLine("Salaries are set!");

            Console.ReadKey();
        }
    }
    abstract class Human
    {
        public uint Age { get; set; }
    }

    class Employed : Human
    {
        public double Salary { get; set; }
    }

    class Boss : Employed
    {
        public double BonusSalary { get; set; }
    }
}
