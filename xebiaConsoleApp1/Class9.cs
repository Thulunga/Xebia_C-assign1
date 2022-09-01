using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//9.Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30

//Expected Output:
//The average of 10 , 15 , 20 , 30 is: 18


namespace xebiaConsoleApp1
{
    internal class Class9
    {
        static void Main9()
        {
            double number1, number2, number3, number4;

            Console.Write("Enter the First number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            number3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            number4 = Convert.ToDouble(Console.ReadLine());

            double result = (number1 + number2 + number3 + number4) / 4;
            int result1 = (int)result;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4} ",
         number1, number2, number3, number4, result1);


            Console.ReadKey();
        }

    }
}
