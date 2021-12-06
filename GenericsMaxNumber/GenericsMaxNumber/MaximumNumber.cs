using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxNumber
{
    class MaximumNumber
    {
        public static int FindMaxInt()
        {
            Console.WriteLine("Enter the First num:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second num:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third num:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2; ;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            else
            {
                Console.WriteLine("Numbers are Equal");

            }
            return 0;
        }
        public static void MaxNumInt()
        {
            Console.WriteLine("Maximum number is " + FindMaxInt());
        }
        public static float FindMaxFloat()
        {
            Console.WriteLine("Enter the First num:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second num:");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Third num:");
            float num3 = float.Parse(Console.ReadLine());

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2; ;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            else
            {
                Console.WriteLine("Numbers are Equal");

            }
            return 0;
        }
        public static void MaxNumFloat()
        {
            Console.WriteLine("Maximum number is " + FindMaxFloat());
        }
       
        public static String FindMaxString()
        {
            Console.WriteLine("Enter the string1:");
            String string1 = (Console.ReadLine());
            Console.WriteLine("Enter the string2");
            String string2 = (Console.ReadLine());
            Console.WriteLine("Enter the string3");
            String string3 = (Console.ReadLine());

            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string2) > 0)
            {
                return string1;
            }
            else if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0)
            {
                return string2; ;
            }
            else if (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0)
            {
                return string3;
            }
            else
            {
                Console.WriteLine("Strings are Equal");

            }
            return default;
        }
        public static void MaxNumString()
        {
            Console.WriteLine("Maximum string is " + FindMaxString());
        }

    }
}
