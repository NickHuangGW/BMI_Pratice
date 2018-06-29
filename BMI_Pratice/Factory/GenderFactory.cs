using BMI_Pratice.Interfaces;
using BMI_Pratice.PersonStandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice.Factory
{
    public class GenderFactory
    {
        public enum Gender
        {
            Man,
            Woman

        }
        public static IPersonBMIStandard GetPersonBMIStandard(Gender _personGender, float _personBMI)
        {
            switch (_personGender)
            {
                case Gender.Man:
                    return new ManBMIStandard(_personBMI);
                case Gender.Woman:
                    return new WomanBMIStandard(_personBMI);
                default:
                    return null;
            }
        }
    }
}
