using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//4.Write a C# Sharp program to print the result of the specified operations. 
//Test data:

//-1 + 4 * 6
//(35 + 5) % 7
//14 + -4 * 6 / 11
//2 + 15 / 6 * 1 - 7 % 2
//Expected Output:
//23
//5
//12
//3


namespace xebiaConsoleApp1
{
    internal class Class4
    {
        static void Main4()
        {


            System.Console.WriteLine(-1 + 4 * 6);
            System.Console.WriteLine((35 + 5) % 7);

            System.Console.WriteLine(14 + -4 * 6 / 11);

            System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);


            Console.ReadKey();
        }

    }
}
