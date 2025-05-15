using System;
namespace SampleApp
{
    public class Day2
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the age");
            string input1=Console.ReadLine();
            int age=Convert.ToInt16(input1);

            Console.Write("Please enter the income");
            string input2=Console.ReadLine();
            int income=Convert.ToInt32(input2);

            Console.Write("Please enter the credit score");
            string input3=Console.ReadLine();
            int creditScore=Convert.ToInt16(input3);

            if(age>=21&&income>=30000&&creditScore>=700)
            {
                Console.WriteLine("Eligible");
            }
            else 
            {
                Console.WriteLine("Not Eligible");
            }
            Console.ReadKey();

        }
        

    }
}