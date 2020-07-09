using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiguiSuanfa
{
    public class Recursion
    {
        public static int Fun(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return Fun(n - 2) + Fun(n - 1);
        }
    }
}
