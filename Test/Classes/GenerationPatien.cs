using GeneratorName;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;

namespace Test.Classes
{
    public class Generation
    {

        private Random rand = new Random();
        public List<Patient> listPat;
        Generator gen = new Generator();

        public Generation()
        {
            listPat = new List<Patient>();
        }

        public void GenetatePatient(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Patient patient = new Patient();
                patient.Name = gen.GenerateDefault(Gender.man);
                patient.IIN = rand.Next(600000, 999999);
                listPat.Add(patient);
            }
        }

        public void PrintPatient()
        {
            foreach (Patient item in listPat)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.IIN);
                Console.WriteLine("---------------------------");
            }

        }

        public Patient SearchPatient(string name)
        {
            Patient p = null;
            foreach (Patient pation in listPat)
            {
                if (pation.Name.Contains(name))
                {
                    p = pation;
                    break;
                }
            }

            return p;
        }
    }
}
