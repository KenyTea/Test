﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;

namespace Test.Classes
{
    /*2.	Мед Организация (Наименование, Адрес, Телефон)*/
    public class MedOrganization
    {
        public string NameOrg { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

        public List<Patient> patients;

        public MedOrganization()
        {
            patients = new List<Patient>();
        }

       

      

    }
}
