using EquationLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class WorkWithUser
    {
        public void ChoseTypeOfEquation()
        {
            Equation eq = new Equation();
            bool isValid = false;
            string keyboardInput = String.Empty;
            string[] parameters;
            Console.WriteLine("Please, choose type of equation.");
            Console.WriteLine("Enter, '1' if you want to calculate linear equation or '2' if you want to calculate quadratic equation");
            keyboardInput = Console.ReadLine();
            while (!isValid)
            {
                switch (keyboardInput)
                {
                    case "1":
                        Log("Linear equation\n");
                        Log("TEMPLATE: ax+b=c\n");
                        Console.WriteLine("TEMPLATE: ax+b=c");
                        parameters = this.WorkWithEquation();
                        Log(eq.LinnerEquation(parameters));
                        Console.WriteLine(eq.LinnerEquation(parameters));
                        isValid = true;
                        break;
                    case "2":
                        Log("Quadratic equation\n");
                        Log("TEMPLATE: ax^2+bx+c=0\n");
                        Console.WriteLine("TEMPLATE: ax^2+bx+c=0");
                        parameters = this.WorkWithEquation();
                        Log(eq.QuadraticEquation(parameters));
                        Console.WriteLine(eq.QuadraticEquation(parameters));
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
            for (int i = 0; i < arguments.Length;)
            {
                Console.WriteLine($"Please write {argumentsName[i]}");
                double doubleValue;
                keyboardInput = Console.ReadLine();
                if (double.TryParse(keyboardInput, out doubleValue))
                {
                    arguments[i] = keyboardInput;
                    Log($"{argumentsName[i]} = {arguments[i]}\n");
                    i++;
                }
                else
                {
                    Log($"Invalid parameter {argumentsName[i]} = {keyboardInput}\n");
                }
            }
            return arguments;
        }
        public static void Log(string message)
        {
            string PATHTOLOG = @"C:\log.txt";
            File.AppendAllText(PATHTOLOG, message);
        }
    }

}
