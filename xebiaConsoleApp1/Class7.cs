﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//7.Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 
//Test Data:
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100
//25 / 4 = 6
//25 mod 4 = 1


namespace xebiaConsoleApp1
{
    internal class Class7
    {
        static void Main7()
        {


            Console.Write("Input the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        


        Console.ReadKey();
        }

    }
}
