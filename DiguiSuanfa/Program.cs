using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiguiSuanfa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            while (true)
            {
                int n = 0;
                int.TryParse(Console.ReadLine(),out n);
                Console.WriteLine(Recursion.Fun(n).ToString());
            }
        }

        public long Rerision(long n)
        {
            if (n == 0)
                return 1;
            else
            return Rerision(n - 1) * n;

        }
    }
}
