using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodss
{
    static class StatClass
    {
        public static void Test3(this Program p , int i)   //the parameter is only binding with old class thats
                                                   //why while caliing  no parameter is needed rest of all parameter will taken
                                                   // multiple binding parameter is not allowed  & binding parameter is always in first place
        {
            Console.WriteLine("Method 3 "+ i);

        }

        public static long Factorial(this Int32 x)
            {
                       if (x ==1)
                return 1;
               if (x ==2) 
                return 2;
               else
            {
                return x * Factorial(x - 1);
            }

            }

        public static string ToProper(this string OldStr)
        {
            if (OldStr.Trim().Length > 0)
            {
                string NewStr = null;

                OldStr = OldStr.ToLower();
                string[] sarr = OldStr.Split(' ');

                foreach (string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if (NewStr == null)
                        NewStr = new string(carr);
                    else
                        NewStr += " " + new string(carr);
                }
                return NewStr;
            }

            return OldStr;

        }

    }
}
