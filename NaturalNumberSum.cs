using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter the range value");
            int n = Convert.ToInt16(Console.ReadLine());
            for(int i=1;i<n;i++)
            {
                if(i%3==0||i%5==0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum of the numbers are " + sum);
            Console.ReadLine();
        }
    }
}
