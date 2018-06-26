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
        public static IPersonBMIStandard GetPersonBMIStandard(Gender _personGender)
        {
            switch (_personGender)
            {
                case Gender.Man:
                    return new ManBMIStandard();
                case Gender.Woman:
                    return new WomanBMIStandard();
                default:
                    return null;
            }
        }
    }
}
