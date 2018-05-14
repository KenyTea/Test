using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    public enum Organisation { Policlinnika6, Policlinnika12, HAK, Sunkar, Rakhat, Policlinnika3, Policlinnika4 }
    public enum Addresss { Shevshenko22, Aptynsarina3, Matepfkrf11, AbilayHana43, KabanbayBatyra81, Abaya2, Doatyr310 }

    public class GeterationMedSenter
    {
        private Random rand = new Random();
        public List<MedOrganization> listMed;

        public GeterationMedSenter()
        {
            listMed = new List<MedOrganization>();
        }

        public void GenetateMed()
        {

            for (int i = 0; i < 6; i++)
            {
                MedOrganization med = new MedOrganization();
                med.NameOrg = ((Organisation)(rand.Next(0, 6))).ToString();
                med.Address = ((Addresss)rand.Next(0, 6)).ToString();
                med.Tel = (rand.Next(300000, 999999)).ToString();
                listMed.Add(med);
            }
        }

        public void PrintMed()
        {
            foreach (MedOrganization item in listMed)
            {
                Console.WriteLine("Name Med Organisation - " + item.NameOrg);
                Console.WriteLine("Address - " + item.Address);
                Console.WriteLine(" " + item.Tel);
                Console.WriteLine("---------------------------------------");
            }
        }

    }
}
