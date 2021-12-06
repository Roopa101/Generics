using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxNumber
{
    class Program
    { 
        public static void Main(string[] args)
        { 
            Console.WriteLine("\nWelcome to Find Maximum number using Generics");
          
            Console.WriteLine("1:Maximum in Integer   2:Maximum in Float  3:Maximum in String");
           
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            
           
            switch(choice)
            {
                case 1:
                    MaximumNumber.MaxNumInt();
                    break;
                case 2:
                    MaximumNumber.MaxNumFloat();
                    break;
                case 3:
                    MaximumNumber.MaxNumString();
                    break;
                default:
                    Console.WriteLine("Invalid Choice ");
                    break;
            }
            Console.ReadLine();
        }
    }
}