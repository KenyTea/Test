using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    public enum Organisation { Policlinnika6, Policlinnika12, HAK, Sunkar, Rakhat, Policlinnika3, Policlinnika4 }
    public enum Addresss { Shevshenko22, Aptynsarina3, Matepfkrf11, AbilayHana43, KabanbayBatyra81, Abaya2, Doatyr310
    }
    public class GeterationMedSenter
    {
        MedOrganization med; 

        private Random rand = new Random();
        public List<MedOrganization> listMed;

        public GeterationMedSenter()
        {
            med = new MedOrganization();
        }

        public void GenetateMed()
        {
            for (int i = 0; i < 6; i++)
            {
                med.NameOrg = rand.Next(0, 6).ToString();
                med.Address = rand.Next(0, 6).ToString();
            }

        }

    }
}
