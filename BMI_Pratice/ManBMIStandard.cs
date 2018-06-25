using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice
{
    public class ManBMIStandard: IPersonBMIStandard
    {
        public string BMIstandard(float _personBMI)
        {
            string RetunMessage= MessaeType.Normal; ;
            if (_personBMI.CompareTo(20)==-1)
            {
                RetunMessage= MessaeType.Thin;
            }
            if (_personBMI.CompareTo(25) == 1)
            {
                RetunMessage= MessaeType.Fat;
            }
            return RetunMessage;
        }
    }
}
