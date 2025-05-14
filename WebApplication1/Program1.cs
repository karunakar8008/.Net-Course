using System;

namespace SampleApp
{
    class Calculator
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            double firstNumber = Convert.ToDouble(input1);

            Console.Write("Enter the operation to be performed");
            string symbool=Console.ReadLine();
            char operatioToBePerformed=Convert.ToChar(symbool);

            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();
            double secondNumber = Convert.ToDouble(input2);

            if(operatioToBePerformed=='+')
            {
                Console.WriteLine($"The sum of two numbers is: {firstNumber+secondNumber}");
            }
            else if(operatioToBePerformed=='-')
            {
                Console.WriteLine($"The subtraction of two numbers is: {firstNumber-secondNumber}");
            }
            else if(operatioToBePerformed=='*')
            {
                Console.WriteLine($"The multiplication of two numbers is: {firstNumber*secondNumber}");
            }
            else if(operatioToBePerformed=='/')
            {
                if(secondNumber>0)
                {
                    Console.WriteLine($"The division of two numbers is: {firstNumber/secondNumber}");
                }
                else{
                    Console.WriteLine("Anything divided by zero is undefined");
                }
                
            }
            Console.ReadKey();
        }
    }
}