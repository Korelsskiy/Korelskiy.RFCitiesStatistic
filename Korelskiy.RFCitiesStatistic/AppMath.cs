using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korelskiy.RFCitiesStatistic
{
    public static class AppMath
    {
        public static int GetNumberOfYears(int firstYear, int secondYear)
        {
            return secondYear - firstYear;
        }
        public static double GetFullPopulationChange(int firstYearPopulation, int secondYearPopulation)
        {
            double popChange = Convert.ToDouble(secondYearPopulation) / Convert.ToDouble(firstYearPopulation);
            popChange = Math.Abs(popChange - 1);
            popChange *= 100;
            popChange = Math.Round(popChange, 3);
            return popChange;
        }
        public static double GetOneYearPopulationChange(int firstYear, int secondYear, double popChange)
        {
            return popChange / (Math.Abs(firstYear - secondYear));
        }
        public static char GetSign(int firstYearPopulation, int secondYearPopulation)
        {
            char sign = ' ';
            if (firstYearPopulation != secondYearPopulation)
            {
                sign = firstYearPopulation > secondYearPopulation ? '-' : '+';
            }
            return sign;
        }
    }
}
