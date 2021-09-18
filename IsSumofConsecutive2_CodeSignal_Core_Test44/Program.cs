using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSumofConsecutive2_CodeSignal_Core_Test44
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int x = isSumOfConsecutive2(n);
            Console.WriteLine(x);
            
        }

        static int isSumOfConsecutive2(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                int sum = i, j = 1;
                while (sum < n)
                {
                    sum = sum + i + j;
                    j++;
                }
                if (sum == n) count++;
            }
            return count;
        }

    }
}
