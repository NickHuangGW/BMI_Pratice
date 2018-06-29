using BMI_Pratice.Interfaces;
using BMI_Pratice.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice.PersonStandard
{
    public class ManBMIStandard: PersonBMIStandardBase, IPersonBMIStandard
    {

        public ManBMIStandard(float _personBMI)
        {
            _bMIConditions = new List<BMICondition>();
            _bMIConditions.Add(new BMICondition(MessaeType.Thin, 20, -1));
            _bMIConditions.Add(new BMICondition(MessaeType.Fat, 25, 1));
            _bMIConditions.Add(new BMICondition(MessaeType.Normal,Convert.ToInt32(_personBMI), 0));
        }
    }
}
