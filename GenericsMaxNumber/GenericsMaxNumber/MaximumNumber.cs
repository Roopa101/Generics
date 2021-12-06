using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxNumber
{
    class MaximumNumber
    {
        public static int FindMaxValue()
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
        public static void MaxNum()
        {
            Console.WriteLine("Maximum number is " + FindMaxValue());
        }
        
    }
}
