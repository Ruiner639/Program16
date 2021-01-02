using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Program16
{
    public class Calculator
    {
        public Calculator(int ValueA, string Operation, int ValueB)
        {
            int sum = 0;
            string sumEx = "";
            switch (Operation)
            {
                case ("+"):
                    sum = ValueA + ValueB;
                    break;
                case ("-"):
                    sum = ValueA - ValueB;
                    break;
                case ("*"):
                    sum = ValueA * ValueB;
                    break;
                case ("/"):
                    try
                    {
                        sum = ValueA / ValueB;
                    }
                    catch(Exception e)
                    {
                        sumEx = Convert.ToString(e).Remove(0,30).Remove(28);
                    }
                    break;
            }
            if(sumEx == "")
            {
                Console.WriteLine(ValueA + Operation + ValueB + "=" + sum);
            }
            else
            {
                Console.WriteLine(sumEx);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ValueA = 0;
            int ValueB = 0;
            string Operation = "Error";
            int i = 0;
            while (i != 1)
            {
                try
                {
                    Console.WriteLine("Enter value A:");
                    ValueA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter value B:");
                    ValueB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose the operation(+,-,*,/):");
                    Operation = Console.ReadLine();
                    if((Operation == "+")||(Operation == "-")||(Operation == "*")||(Operation == "/"))
                    {
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Error in filling out the operation item");
                    }
                }
                catch
                {
                    Console.WriteLine("Enter only numbers: ");
                }
            }
            new Calculator(ValueA, Operation, ValueB);
        }
    }
}
