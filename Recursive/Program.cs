using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive
{

    public class Factorial
    {

        public int fact(int n)
        {
            if (n == 1)
                return 1;
            else 
            return fact(n - 1) * n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Factorial f = new Factorial();

            Console.WriteLine("Factorial of 4 is" + f.fact(4));
            Console.WriteLine("Factorial of 5 is" + f.fact(5));
            Console.ReadLine();


        }
    }
}
