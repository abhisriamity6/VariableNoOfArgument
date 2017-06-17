using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNoOfArgument
{
    class VariableClass
    {
        int min;
        int max;
        public VariableClass()
        {

        }
        public int getmin(params int[] numbers)
        {
            min = numbers[0];
            for (int i=1; i < numbers.Length; i++)
            {

            if(numbers[i]<min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            VariableClass varclass = new VariableClass();
            Console.Write("Enter Length of Array : ");
            int arrarlen = int.Parse(Console.ReadLine());
            int[] array = new int[arrarlen];
            for (int i = 0; i < arrarlen; i++)
            {
                Console.Write("Enter {0} Element of Array : ", i );
                int arrelement = int.Parse(Console.ReadLine());
                array[i] = arrelement;
            }
         Console.WriteLine("Minimum Value is {0} ", varclass.getmin(array));
            Console.Read();
        }
    }
}
