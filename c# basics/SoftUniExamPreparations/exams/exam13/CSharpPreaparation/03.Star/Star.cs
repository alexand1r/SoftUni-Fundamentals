using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outerDots = n-1;
            int innerDots = 1;

            Console.WriteLine(new string('.',n) + "*" + new string('.',n));
            
            for (int i = 0; i < n/2-1; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', outerDots));
                Console.WriteLine();
                outerDots--;
                innerDots += 2;
            }
            Console.WriteLine("{0}{1}{0}", new String('*', n/2+1), 
                new string('.',n-1));
            outerDots = 1;
            innerDots = n*2 - 3;
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine();
                innerDots -= 2;
            }
            Console.WriteLine("{0}{1}{2}{1}{2}{1}{0}", new String('.', n/2),
                '*',new string('.', n/2-1));
            outerDots = n/2 - 1;
            innerDots = 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.Write(new string('.', outerDots));
                Console.Write('*');
                Console.Write(new string('.', n/2-1));
                Console.Write('*');
                Console.Write(new string('.', innerDots));
                Console.Write('*');
                Console.Write(new string('.', n / 2 - 1));
                Console.Write('*');
                Console.Write(new string('.', outerDots));
                Console.WriteLine();
                outerDots--;
                innerDots += 2;
            }
            Console.WriteLine("{0}{1}{0}", new String('*', n / 2 + 1),
                new string('.', n - 1));
        }
    }
}