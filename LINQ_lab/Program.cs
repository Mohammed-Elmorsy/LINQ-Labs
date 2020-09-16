using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_lab
{
    class Program
    {
        public static int subtract(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            //reverse (extension method)
            Console.WriteLine(5643.getReverse());

            //function name (subtraction)
            Console.WriteLine(Operation.operation(15, 9, subtract));

            //anonymous function (devision)
            Console.WriteLine(Operation.operation(20,5, delegate (int a,int b) {
                return a / b;
            }));

            //Lambda expression (sum)
            Console.WriteLine(Operation.operation(3, 5, (x, y) => x + y));

            //(multiplication)
            Console.WriteLine(Operation.operation(12,10, (int x,int y) => x * y));

            Console.ReadLine();
        }
    }

    public static class Reverse
    {
        public static int getReverse(this int num)
        {
            int reminder = 0, reverse = 0;
            while (num != 0)
            {
                reminder = num % 10;
                reverse = reverse * 10 + reminder;
                num /= 10;
            }
            return reverse;

        }
    }

    public delegate int mathOperation(int x, int y);
    public class Operation
    {

        public static int  operation(int x, int y, mathOperation op)
        {
            return op(x, y);
        }
    }
}
