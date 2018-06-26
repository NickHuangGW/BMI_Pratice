using BMI_Pratice.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice.PersonStandard
{
    public class BMICondition
    {
        public BMICondition(string _BMIMessae, int _CompareBMI, int _ResultValue)
        {
            BMIMessae = _BMIMessae;
            CompareBMI = _CompareBMI;
            ResultValue = _ResultValue;
        }

        public string BMIMessae { get; set; }

        public int CompareBMI { get; set; }

        public int ResultValue { get; set; }

    }
}
