using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Interfaces;

namespace Test.Classes
{
    /*Приложение с авторизацией (включает в себя три модуля)
А) Модуль Прикрепления пациента
Б) Контролирующий модуль
В) Отчет о прикрепленных пациентах

авторизуемый пользователь, может иметь права доступа как к одному из этих модулей, так и ко всем сразу.
*/
    public class ModuleSet
    {
        public void Zakreplenir(ref MedOrganization organ, ref Patient patient)
        {

            organ.patients.Add(patient);
            patient.MedOrgan = organ;
        }

    }
}
