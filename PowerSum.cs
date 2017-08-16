using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Enter the power value");
            int p = Convert.ToInt16(Console.ReadLine());
            double ans=Math.Pow(2, p);
            Console.WriteLine(ans);
            while(ans!=0)
            {
                sum = sum + (ans % 10);
                ans = ans / 10;
            }
            Console.WriteLine("Sum of the digits is" + (int)sum);
            Console.ReadLine();
        }
    }
}
