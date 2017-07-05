using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace lambda_2._77
{
    class Program
    {
        static void Main(string[] args)
        {
            // *** Func vs. Action
            //Func<int, int, int> addFunc = (x, y) => x + y;
            //Action<int, int> printAddAction = (x, y) => { int z = x + y; Console.WriteLine("Action: {0} and {1} equals {2}", x, y,z); };
            //printAddAction(4, 5);
            //Console.WriteLine("Function: {0}", addFunc(2, 3));
            //Console.ReadKey();

            Action<int> example1 = (int x) => Console.WriteLine("Write {0}", x);
            Action<int, int> example2 = (x, y) => Console.WriteLine("Write {0} and {1}", x, y);
            Action example3 = () => Console.WriteLine("Done");
            
            // Call the anonymous methods.
            example1(1);
            example1.Invoke(1);
            example2.Invoke(2, 3);
            example2(4, 5);
            example3.Invoke();

            Console.ReadKey();

        }
    }
}
