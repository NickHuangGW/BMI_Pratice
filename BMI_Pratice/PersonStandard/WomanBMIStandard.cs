using BMI_Pratice.Interfaces;
using BMI_Pratice.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice.PersonStandard
{
    public class WomanBMIStandard : PersonBMIStandardBase, IPersonBMIStandard
    {

        public WomanBMIStandard(float _personBMI)
        {
            _bMIConditions = new List<BMICondition>();
            _bMIConditions.Add(new BMICondition(MessaeType.Thin, 18, -1));
            _bMIConditions.Add(new BMICondition(MessaeType.Fat, 22, 1));
            _bMIConditions.Add(new BMICondition(MessaeType.Normal, Convert.ToInt32(_personBMI), 0));
        }
    }
}
