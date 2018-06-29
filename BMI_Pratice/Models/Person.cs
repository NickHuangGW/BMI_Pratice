using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BMI_Pratice.Factory.GenderFactory;

namespace BMI_Pratice.Models
{
    public class Person
    {
        public int PersonHigh { get; set; }

        public int PersonWeight { get; set; }

        public Gender PersonGende { get; set; }
    }
}
