using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Classes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Generation gener = new Generation();
            gener.GenetatePatient(22);
            gener.PrintPatient();

        }
    }
}
