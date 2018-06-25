using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Pratice
{
    public static class BMI
    {
        public static float GetBMI(int High,int Weiget)
        {
            return Weiget / (High * High);
        }
    }
}
