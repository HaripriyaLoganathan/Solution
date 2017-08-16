using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSumOfEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Range value");
            int n = Convert.ToInt16(Console.ReadLine());
            int a = 1, b = 2,c=0,count=0,sum=2;
            for(int i=1;i<=n-2;i++)
            {
                count++;
                c= a + b;
                //Console.WriteLine("c" + c);
                a = b;
                b = c;
                if(count%2==0)
                {
                    sum += c;
                }
            }
            Console.WriteLine("Sum of Even terms is " + sum);
            Console.Read();
        }
    }
}
