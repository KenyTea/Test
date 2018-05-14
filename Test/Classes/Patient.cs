using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Interfaces
{
    /*1.	Пациент (Фамилия, Имя, Отчество, ИИН)*/
    public class Patient
    {
        private string Name_;
        public string Name
        {
            get
            {
                return Name_;
            }
            set
            {
                Name_ = value.Replace("<center><b><font size=7>", "").Replace("</font></b></center>", "").Replace("\n", "");
            }
        }
        public int IIN { get; set; }
    }
}
