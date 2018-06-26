using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice.PersonStandard
{
   public abstract class PersonBMIStandardBase
    {
        protected List<BMICondition> _bMIConditions { get; set; }

        public virtual string BMIstandard(float _personBMI)
        {
            string ReturnValue = string.Empty;
            foreach (var _bMICondition in _bMIConditions)
            {
                if (_personBMI.CompareTo(_bMICondition.CompareBMI).Equals(_bMICondition.ResultValue).Equals(true))
                {
                    ReturnValue = _bMICondition.BMIMessae;
                    break;
                }
            }
            return ReturnValue;
        }

    }
}
