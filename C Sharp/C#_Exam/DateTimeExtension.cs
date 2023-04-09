using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Exam
{
    public static class DateTimeExtensions
    {
        public static string DateFormate(this DateTime date)
        {
            string format = "dd-MMM-yyyy";
            return date.ToString(format);
        }
    }
}
