using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EquationLib;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkWithUser workWithUser = new WorkWithUser();
            workWithUser.ChoseTypeOfEquation();
            Console.ReadKey();
        }
    }
}
