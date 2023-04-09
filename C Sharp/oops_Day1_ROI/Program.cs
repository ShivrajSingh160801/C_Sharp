using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_Day1_ROI
{
    public class Program
    {
        static void Main(string[] args)
        {
            roiCalculation RoiReq = new roiCalculation();
            RoiReq.ROI(70000,50000);

            Console.WriteLine("\n--------------------------------------");

            annualizedROI annualizedROI = new annualizedROI();
            annualizedROI.annualizedROICalculate();
        }
    }
    public class roiCalculation
    {
        public decimal GainFromInvestment;
        public decimal CostOfInvestment;
        public decimal ROI(decimal GainFromInvestment , decimal CostOfInvestment) 
        {
            decimal Calculation = ((GainFromInvestment - CostOfInvestment) / CostOfInvestment );
            Console.WriteLine(Calculation*100 +"%");
            return Calculation;
        }
    }
    public class TimeDifference
    {
        public decimal GetYearsBetweenDates(DateTime date1, DateTime date2)
        {
            TimeSpan timeSpan = date1 > date2 ? date1 - date2 : date2 - date1;
            decimal years = (decimal)(timeSpan.TotalDays / 365.25);
            return Math.Abs(years);
        }
    }

    public class annualizedROI
    {
        public double annualizedROICalculate()
        {
            Console.WriteLine("Enter Date 1");
            DateTime Date1 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Date 2");
            DateTime Date2 = Convert.ToDateTime(Console.ReadLine());

            TimeDifference myDaterange = new TimeDifference();
            decimal years = myDaterange.GetYearsBetweenDates(Date1, Date2);

            Console.WriteLine("Enter invested amount");
            decimal amountInvested = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Returned amount");
            decimal amountreturned = Convert.ToDecimal(Console.ReadLine());

            roiCalculation RoiReq = new roiCalculation();
            decimal roi =  RoiReq.ROI(amountreturned, amountInvested);

            double annualizedROI = (Math.Pow(Convert.ToDouble(1+roi), (double)( 1 / years) ) - 1) * 100;
            Console.WriteLine("Annualized ROI is "+annualizedROI + "%");
            return annualizedROI;

        }

    }
}
