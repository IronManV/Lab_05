using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.IncreaseAge();
            Console.WriteLine(kitty.Age);
            kitty.CountLegs();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public uint Age { get; set; } = 0;

        public void IncreaseAge()
        {
            Age++;
        }
    }

    interface ILandBased
    {
        void CountLegs();
    }

    class Cat : Animal, ILandBased
    {
        public string Sound { get; set; } = "miau";
        public void CountLegs()
        {
            Console.WriteLine("Cat has four legs and falls on all of them!");
        }
    }
}
