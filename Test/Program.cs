using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Classes;
using Test.Interfaces;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Generation gener = new Generation();
            gener.GenetatePatient(22);
            gener.PrintPatient();

            Console.WriteLine("Enter Name ");
            string name = Console.ReadLine();
            Patient p = gener.SearchPatient(name);
            Console.WriteLine("Найденный пациент: {0} ({1})", p.Name, p.IIN);

        }
    }
}
