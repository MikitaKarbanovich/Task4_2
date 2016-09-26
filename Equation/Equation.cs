using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquationLib
{
    public class Equation
    {
        public string QuadraticEquation(string[] arguments)
        {
            double a = Double.Parse(arguments[0]);
            double b = Double.Parse(arguments[1]);
            double c = Double.Parse(arguments[2]);
            string ans = String.Empty;
            double root1 = 0;
            double root2 = 0;
            double identifier = 0;
      
            identifier = b * b - (4 * a * c);


            if (identifier > 0)
            {
                root1 = (-b + (Math.Sqrt(identifier) / (2 * a)));
                root2 = (-b - (Math.Sqrt(identifier) / (2 * a)));
                string r1 = string.Format("{0:0.##}", root1); ;
                string r2 = string.Format("{0:0.##}", root2); ;
                ans = "Root1 =" + r1 + " Root2 = " + r2;
                Console.WriteLine(ans);
                return ans;
            }

            if (identifier < 0)
            {
                double Real = (-b / (2 * a));
                double Complex = ((Math.Sqrt((identifier * (-1.00))) / (2 * a)));
                string SReal = Convert.ToString(Real);
                string SComplex = Convert.ToString(Complex);
                ans = "Roots = " + SReal + "+/-" + SComplex + "i";
                Console.WriteLine(ans);
                return ans;
            }

            if (identifier == 0)
            {
                root1 = (-b / (2 * a));
                string Root = Convert.ToString(root1);
                ans = "Repeated roots : " + Root;
                return ans;
            }
            return ans;
        }
        public string LinnerEquation(string[] arguments)
        {
            double a = Double.Parse(arguments[0]);
            double b = Double.Parse(arguments[1]);
            double c = Double.Parse(arguments[2]);
            double x = (c - b) / a;
            string result = string.Format("{0:0.##}", x);
            return result;
        }
    }
}
