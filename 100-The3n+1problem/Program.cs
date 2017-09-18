using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_The3n_1problem
{
    class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            /*
            Question 1
            Consider the following algorithm:
            1.input n
            2.print n
            3. if n = 1 then STOP
            4. if n is odd then n ←− 3n + 1
            5. else n ←− n / 2
            6.GOTO 2
            Given the input 22, the following sequence of numbers will be printed
            22 11 34 17 52 26 13 40 20 10 5 16 8 4 2 1            */
            int x = 1000;
            numlist.Add(x);
            count++;
            if (x > 1) {
                Sol(x);
            }                                 
            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(count);
        }
        static List<int> numlist = new List<int>();
        static void Sol(int num)
        {
            //List<int> numlist = new List<int>();
            

            if (num > 1)
            {
                if (num % 2 == 0)
                {
                    numlist.Add(num / 2);
                    count++;
                    Sol(num / 2);
                }
                else
                {
                    numlist.Add((num * 3)+1);
                    count++;
                    Sol((num * 3) + 1);
                }
            }


        }
    }
}
