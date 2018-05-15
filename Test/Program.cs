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
            gener.GenetatePatient(10);
            gener.PrintPatient();
            Console.WriteLine("---------------------------------------------------\n");

            GeterationMedSenter medc = new GeterationMedSenter();
            medc.GenetateMed();
            medc.PrintMed();

            Console.WriteLine("Enter Name ");
            string name = Console.ReadLine();
            Patient p = gener.SearchPatient(name);
            Console.WriteLine("Найденный пациент: {0} ({1})", p.Name, p.IIN);
            Console.WriteLine("---------------------------------------------------\n");

            ModuleSet Ms = new ModuleSet();
            MedOrganization Mo = new MedOrganization();

            //Ms.Zakreplenir(ref Mo[], ref  


        }
    }
}
