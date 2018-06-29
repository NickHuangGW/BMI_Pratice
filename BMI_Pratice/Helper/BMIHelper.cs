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
