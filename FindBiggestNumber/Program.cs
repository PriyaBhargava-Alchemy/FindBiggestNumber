using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Finding the biggest of three numbers in C#
namespace FindBiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, biggerNumber;
            char a = ' ';
            do
            { 
             P(" Enter number 1 : ");
            num1 = Convert.ToDouble(Console.ReadLine());

            P(" Enter number 2 : ");
            num2 = Convert.ToDouble(Console.ReadLine());


            P(" Enter number 3 : ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                biggerNumber = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                biggerNumber = num2;
            }
            else
            {
                biggerNumber = num3;
            }

            P("Biggest number is   :  " + biggerNumber);
            P("Max number is   :  " + MaxNumber(num1, num2));
          
                P("Do you want again ? Press 'y' or 'n'   : ");
              //  a = Convert.ToChar(Console.ReadKey());
            } while (a == 'y') ;
            Console.ReadLine();
        }
      
        //   Method for Print
        static void P(String print)
        {

            Console.WriteLine(print);

        }

        static double MaxNumber(double num1, double num2)
        {
            double result =0;
            result = Math.Max(num1, num2);
            return result;
        }

        static void Ans()
        {
            char a = ' ';
            while (a == 'y' || a == 'n') ;
            
        }
    }
}
