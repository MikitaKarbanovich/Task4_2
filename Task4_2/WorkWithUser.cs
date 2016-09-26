using EquationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class WorkWithUser
    {
        public void ChoseTypeOfEquation()
        {
            bool isValid = false;
            string keyboardInput = String.Empty;
            Console.WriteLine("Please, choose type of equation.");
            Console.WriteLine("Enter, '1' if you want to calculate linear equation or '2' if you want to calculate quadratic equation");
            keyboardInput = Console.ReadLine();
            while (!isValid)
            {
                switch (keyboardInput)
                {
                    case "1":
                        Equation eq = new Equation();
                        Console.WriteLine("TEMPLATE: ax+b=c");
                        Console.WriteLine(eq.LinnerEquation(this.WorkWithEquation()));
                        isValid = true;
                        break;
                    case "2":
                        Console.WriteLine("TEMPLATE: ax^2+bx+c=0");
                        Equation eq1 = new Equation();
                        Console.WriteLine(eq1.QuadraticEquation(this.WorkWithEquation()));
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("No matches.Please choose one of valid options ");
                        keyboardInput = Console.ReadLine();
                        break;
                }
            }
        }
        public string[] WorkWithEquation()
        {
            string[] arguments = new String[3];
            string[] argumentsName = { "a", "b", "c" };
            string keyboardInput = String.Empty;
            for (int i = 0; i < arguments.Length; i++)
            {
                Console.WriteLine($"Please write {argumentsName[i]}");
                keyboardInput = Console.ReadLine();
                arguments[i] = keyboardInput;

            }
            return arguments;
        }
    }
}
