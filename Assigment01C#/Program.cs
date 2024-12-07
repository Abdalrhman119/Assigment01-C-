using System.ComponentModel;
using System.Transactions;

namespace Assigment01C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01 : Write a program that allows the user to enter a number then print it
            //Console.WriteLine("Enter a Num : ");
            //int num=int.Parse(Console.ReadLine());
            //Console.WriteLine("Your Num = "+num);  
            #endregion
            #region Q02 : Write a C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen.
            //string input = "659dyh";
            //int result = int.Parse(input);
            //Console.WriteLine("Result : " + result);
            ////System.FormatException: 'The input string '659dyh' was not in a correct format.'
            #endregion
            #region Q03 : Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float x = 9.9f;
            //float y = 3.3f;
            //float result = x * y;
            //Console.WriteLine("Result = "+result);
            #endregion
            #region Q04 : Write C# program that Extract a substring from a given string
            //string x = "Hello";
            //string y = x.Substring(4);  
            //Console.WriteLine("Extract a substring :  " + y);
            #endregion
            #region Q05 : Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 8;  
            //int y =x;
            //y=10;
            //Console.WriteLine("x : "+x );//8
            //Console.WriteLine("y : " + y);//10
            ////Equals with last value
            #endregion
            #region Q06 : Write C#program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Person person1 = new Person();
            //person1.Name = "Ahmed";
            //person1.Age = 16;

            //Person person2 = person1;
            //person2.Name = "Khalid";
            //person2.Age = 40;

            //Console.WriteLine("Person 1:\n Name = " + person1.Name + "\n Age = " + person1.Age);
            //Console.WriteLine("Person 2:\n Name = " + person2.Name + "\n Age = " + person2.Age);
            #endregion
            #region Q07 : Write C# program that take two string variables and print them as one variable 
            //string x = "Hello";
            //string y = "World";
            //string s = x + " " + y;
            //Console.WriteLine("Combined string : " + s);
            #endregion
            #region Q08 : Which of the following statements is correct about the C#.NET code snippet given below?
            //int x;
            //x = Convert.ToInt32(!(30 < 20));
            //Console.WriteLine("The value of d is: " + x);
            ////b)	A value 1 will be assigned to d
            #endregion
            #region Q09 : Which of the following is the correct output for the C# code given below?
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            ////d) 6 1
            ////    / --> select Integer Division --> 13/2=6
            ////    % --> select Modulo   -->  13%2=1
            #endregion
            #region Q10 : What will be the output of the C# code given below?
            //int num = 1, z = 5;
            //
//
//
            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            ////d)7 7
            ////++num = 2
            ////z++ = 5
            ////++z = 7
            #endregion
        }
    }
}
