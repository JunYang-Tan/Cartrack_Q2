using System;

namespace Cartrack_Question_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string:");
            PalindromeTester pld = new PalindromeTester();
            pld.Checker(Console.ReadLine());
            Console.ReadKey();
        }


        public class PalindromeTester
        {
            public bool Checker(string str)
            {
                var length = 0;
                var flag = true;

                //determine the length of the string
                foreach (var a in str)
                {
                    length++;
                }

                //check palindrome
                for (int i = 0; i < length / 2; i++)
                {
                    if (str[i] != str[length - (i + 1)])
                    {
                        flag = false;
                        break;
                    }
                }

                //if flag true, text is palindrome
                if (flag)
                {
                    Console.WriteLine("{0} is palindrome", str);
                    return flag;
                }
                else
                {
                    Console.WriteLine("{0} is not palindrome", str);
                    return flag;
                }
            }
        }
    }
}


