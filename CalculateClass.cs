using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace CalculateLib
{
    public class Calculations
    {
        public static List<string> CalculateSumSeries(double x, double eps)
        {
            int a = 2;
            double lastAns = 1;
            double currAns = (-1) * x / a;
            List<string> answer = new List<string>();
            do
            {
                answer.Add(Convert.ToString(lastAns));
                lastAns = currAns;
                a++;
                currAns = Math.Pow((-1), ((a - 1) % 2)) * (x / a);
            } while ((Math.Abs(currAns) - Math.Abs(lastAns)) > eps);
            return answer;
        }

        public static double CalculateNatLog(double x)
        {
            double answer = Math.Log((1 + x) / x);
            return answer;
        }

    }
}
