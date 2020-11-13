using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10i_201113
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();

            Console.WriteLine("Negyzet");
            for (int i = 0; i < n;  i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(c);
                }
                Console.Write('\n');
                //Console.WriteLine();
            }

            Console.WriteLine("Derekszogu");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(c);
                }
                Console.Write('\n');
            }

            Console.WriteLine("Negyzet2");
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
            Console.Write('\n');

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(c);
                for (int j = 0; j < n - 2; j++)
                {
                    Console.Write(' ');
                }
                Console.Write(c);
                Console.Write('\n');
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(c);
            }
            Console.Write('\n');

            Console.WriteLine("Negyzet2b");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == 0 || j == n - 1 || i == 0 || i == n - 1)
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');
            }

            Console.WriteLine("Negyzet sarkai");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j == 0 || j == n - 1) && (i == 0 || i == n - 1))
                    {
                        Console.Write(c);
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write('\n');
            }

            Console.WriteLine("Piramis");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write(c);
                }
                Console.Write('\n');
            }
        }
    }
}
