using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Threading.Channels;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CsSession4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            /*Write a program that allows the user to insert an integer then print all
            numbers between 1 to that number.*/

            /*int n; int.TryParse(Console.ReadLine(), out n);

            if(n<1)
            {
                Console.WriteLine("Enter Valid Number");
                return;
            }

            for (int i = 1; i<= n; ++i)
                Console.Write($"{i} ");*/

            //add the if condition to handle zero and nigative numbers
            #endregion

            #region Q2

            /*Write a program that allows the user to insert an integer then
            print a multiplication table up to 12.*/

            /*int n; int.TryParse(Console.ReadLine(), out n);
            
            for(int i = 1; i <= 12; ++i)
            {
                Console.Write($"{n*i} ");
            }*/

            #endregion

            #region Q3

            /*Write a program that allows to user to insert number then print all even
            numbers between 1 to this number*/

            /*int n; int.TryParse(Console.ReadLine(), out n);

            for(int i = 1; i <= n; ++i)
            {
                if(i%2==0)
                    Console.Write($"{i} ");
            }*/

            #endregion

            #region Q4

            //Write a program that takes two integers then prints the power.

            /*int n, nn;
            Console.Write("Enter base Number: ");
            int.TryParse(Console.ReadLine(), out n);
            Console.Write("Enter Power Number: ");
            int.TryParse(Console.ReadLine(), out nn);

            
            double res = 1;*/ // Starting with 1 not 0, because 0 multiply will be zero with all

            //way 1 (Using loop)
            /*for (int i = 1; i <= nn; ++i)
                res *= n;*/

            //way 2 (Using Math Function)
            /*res = 1;
            res = Math.Pow(n, nn);

            Console.WriteLine($"The resault is: {res}");*/



            #endregion

            #region Q5

            /*Write a program to enter marks of five subjects and calculate total,
            average and percentage.*/

            /*Console.WriteLine("Enter 5 Numbers of Sujects Grades [Maximum 100]");
            double sum, temp;*/


            // Way 1 (Without Array)
            /*temp = 0; sum = 0;
            for (int i = 1; i <= 5; ++i)
            {
                Console.Write($"Enter Grade of Subject {i}: ");
                double.TryParse(Console.ReadLine(), out temp);

                if(temp < 0 || temp > 100)
                {
                    Console.WriteLine("This is Non Valid Grade (Skipped)");
                }
                else
                {
                    sum += temp;
                }

                temp = 0;
            }*/



            // Way 2 (Using Array)
            /*temp = 0; sum = 0;

            double[] arr = new double[5];

            for (int i = 0; i < 5; ++i)
            {
                Console.Write($"Enter Grade of Subject {i+1}: ");
                double.TryParse(Console.ReadLine(), out arr[i]);

                if (arr[i]< 0 || arr[i] > 100)
                {
                    Console.WriteLine("This is Non Valid Grade (Skipped)");
                }
                else
                {
                    sum += arr[i];
                }
            }*/


            /*Console.Clear();
            Console.WriteLine($"Total = {sum}");
            Console.WriteLine($"Average = {sum/5}");
            Console.WriteLine($"Percentage = {(sum*100)/500}%");*/

            #endregion

            #region Q6

            /*Write a program to allow the user to enter a string and print the
            REVERSE of it.*/

            // way 1
            /*Console.Write("Enter a String: ");
            string s = Console.ReadLine();
            string ss = "";

            for (int i = s.Length - 1; i >= 0; --i)
                ss += s[i];

            Console.WriteLine($"The reseved word is: {ss}");*/


            //way2 (Using Functions)

            /*string s = Console.ReadLine();

            char[] arr = s.ToCharArray(); //Function convert string to array of char
            Array.Reverse(arr); //Function reverse the array funtion automaticly
            string ss = new string(arr);

            Console.WriteLine($"The reseved word is: {ss}");*/


            #endregion

            #region Q7

            //Write a program to allow the user to enter int and print the REVERSED of it.

            // Way1
            /*Console.Write("Enter an integer: ");
            int n; int.TryParse(Console.ReadLine(), out n);
            int rn = 0;

            while (n != 0)
            {
                int temp =  n%10;
                rn = rn * 10 + temp;        //rn *= 10 + temp;
                n /= 10;
            }

            Console.WriteLine($"Reserved Number is: {rn}");*/

            // Way2 (Using Functions)

            /*Console.Write("Enter an integer: ");
            string s = Console.ReadLine();

            char[] arr = s.ToCharArray(); //Funtion to convert string to array of char
            Array.Reverse(arr);//Function reverse the array funtion automaticly
            string ss = new string(arr);// Making new string from array of char

            Console.WriteLine($"Reserved Number is: {ss}");*/

            /*
             Important Note:

            In first way I can't handle the case when 0 is last digit like 120, it becomes 21
            so, I try to fix in second way but I deal with the number as a string
            if there is a better way tell me

            thx Eng. Yassin 
             */




            #endregion

            #region Q8

            //Write a program in C# Sharp to find prime numbers within a range of numbers.

            /*Console.WriteLine("Finding Prime Number in a Range");
            Console.WriteLine("======================================================");
            Console.Write("Enter the Start Point: ");
            int s; int.TryParse(Console.ReadLine(), out s);
            Console.Write("Enter the End Point: ");
            int e; int.TryParse(Console.ReadLine(), out e);

            //Note : I make the bool funtion pr to make it eaisier when coding (:
            for(int i = s; i <= e; ++i)
            {
                if(pr(i))
                    Console.Write($"{i} ");
            }

            bool pr(int num)
            {
                if (num < 2)
                    return false; //return 0;

                for(int i = 2; i<num/2 ; ++i) //we devide range with 2, we can use Math.sqrt Function to save time
                {
                    if (num % i == 0)
                        return false;
                }

                return true; //return 1;
            }*/

            #endregion

            #region Q9

            /*Write a program in C# Sharp to convert a decimal number into binary
            without using an array.*/

            // Way1 (Using Math)

            /*Console.Write("Enter the Number to convert into Binary: ");
            int n; int.TryParse(Console.ReadLine(), out n);

            string s = "";

            if (n == 0)
            {
                Console.WriteLine("The binary number is: 0");
                return;
            }

            while(n>0)
            {
                s = (n % 2) + s;
                n /= 2;
            }

            Console.WriteLine($"The binary number is: {s}");*/

            // Way2 (Using Function)

            /*
             
               No time    

            */
            #endregion

            #region Q10

            /*Create a program that asks the user to input three points(x1, y1), (x2,
            y2), and(x3, y3), and determines whether these points lie on a single
            straight line.*/

            /*Console.Write("Enter X1:");
            double x1; double.TryParse(Console.ReadLine(), out x1);
            Console.Write("Enter y1:");
            double y1; double.TryParse(Console.ReadLine(), out y1);
            Console.Write("Enter X2:");
            double x2; double.TryParse(Console.ReadLine(), out x2);
            Console.Write("Enter Y2:");
            double y2; double.TryParse(Console.ReadLine(), out y2);
            Console.Write("Enter X3:");
            double x3; double.TryParse(Console.ReadLine(), out x3);
            Console.Write("Enter Y3:");
            double y3; double.TryParse(Console.ReadLine(), out y3);

            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);

            if (slope1 == slope2)
                Console.WriteLine("All Points are in the same line");
            else
                Console.WriteLine("The Points aren't in the same line");*/

            /*      
             Important Note:
             I search on the internet to find the method of slope because I am weak at math
             it"s ok? 
            */

            #endregion

            #region Q11

            /*Write a program that prints an identity matrix using for loop, in other
            words takes a value n from the user and shows the identity table of size n * n.*/

            /*int n; int.TryParse(Console.ReadLine(), out n);

            for (int i = 0; i < n; ++i) //i is the row
            {
                for (int j = 0; j < n; ++j) //j is the column
                {
                    if(i==j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine(); //go to new line, for matrix shape
            }*/

            #endregion


        }
}
}
