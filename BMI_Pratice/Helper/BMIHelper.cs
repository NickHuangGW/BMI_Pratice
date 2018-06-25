using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice.Helper
{
    public static class BMIHelper
    {
        public static float GetBMI(int High,int Weiget)
        {
            return Weiget / (High * High);
        }
    }
}
