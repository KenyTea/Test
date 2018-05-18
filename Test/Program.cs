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
            GenerationPatien gener = new GenerationPatien();
            gener.GenetatePatient(10);
            gener.PrintPatient();
            Console.WriteLine("---------------------------------------------------\n");

            Console.WriteLine("Enter pation's name ");
            string name = Console.ReadLine();
            Patient p = gener.SearchPatient(name);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Найденный пациент: {0} ({1})", p.Name, p.IIN);
            Console.WriteLine("---------------------------------------------------\n");

            Console.ReadKey();
            Console.Clear();
                       
            GeterationMedSenter medc = new GeterationMedSenter();
            medc.GenetateMed();
            medc.PrintMed();

            Console.WriteLine("Enter Med organization Name for add patien ");
            string MedName = Console.ReadLine();
            MedOrganization m = medc.SearchMedOrg(MedName);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Found medical institution: "+  m.NameOrg);
            Console.WriteLine("Address: " + m.Address);
            Console.WriteLine("Telephone " + m.Tel);
            Console.WriteLine("---------------------------------------------------\n");

            Console.ReadKey();
            Console.Clear();

            //medc.listMed.Add(p);

            ModuleSet Ms = new ModuleSet();
            Ms.Zakreplenir(ref medc, ref p); 


        }
    }
}
