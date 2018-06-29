using BMI_Pratice.Factory;
using BMI_Pratice.Helper;
using BMI_Pratice.Interfaces;
using BMI_Pratice.Models;
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
    public class HealthExamination
    {
        public Person PersonModel { get; set; }

        public float PersonBMI { get; private set; }

        public string Message { get; private set; }

        public HealthExamination(Person _personModel)
        {
            PersonModel = _personModel;
        }

        public void GetMessageAndBMI()
        {
            PersonBMI = BMIHelper.GetBMI(PersonModel.PersonHigh, PersonModel.PersonWeight);
            IPersonBMIStandard PersonBMIStandard = GetPersonBMIStandard(PersonModel.PersonGende, PersonBMI);
            Message = PersonBMIStandard.BMIstandard(PersonBMI);
        }

    }
}
