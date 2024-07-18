using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodss
{
    internal class TestExtMethods
    {

        static void Main()
        {
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3(20);


            int i = 8;
           long result = i.Factorial();
            Console.WriteLine("Factorial of {0 } is : {1}", i, result);


            String str = "heLLo hoW ArE YoU";
            str = str.ToProper();
            Console.WriteLine(str);


            Console.ReadLine();
        }
    }
}
