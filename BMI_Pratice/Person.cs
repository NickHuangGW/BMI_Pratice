using BMI_Pratice.Factory;
using BMI_Pratice.Helper;
using BMI_Pratice.PersonStandard;
using BMI_Pratice.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BMI_Pratice.Factory.GenderFactory;

namespace BMI_Pratice
{
    public class Person
    {
        private int PersonHigh { get; set; }

        private int PersonWeight { get; set; }

        private Gender PersonGende { get; set; }

        public float PersonBMI { get; private set; }

        public Person(int _personHight, int _personWeight, Gender _personGende)
        {
            PersonHigh = _personHight;
            PersonWeight = _personWeight;
            PersonGende = _personGende;
            PersonBMI = BMIHelper.GetBMI(PersonHigh, PersonWeight);
        }

        public string GetAlertMessageForBMI()
        {
            IPersonBMIStandard PersonBMIStandard = GetPersonBMIStandard(PersonGende, PersonBMI);
            return PersonBMIStandard.BMIstandard(PersonBMI);
        }

    }
}
