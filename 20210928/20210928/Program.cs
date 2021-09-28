using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210928
{
    class Program
    {
        static void Main(string[] args)
        {
            //f0();
            //f1();
            //f2();
            //f3();
            //f4();
            //f5();
            //f6();
            //f7();

            

            Console.WriteLine();
            Console.ReadLine();

        }
        static void f0()
        {
            for (int i = 0; i < 16; i++)
            {
                Console.WriteLine("{0}", 1*1);
            }
            int cv = 1;
            while (cv<1)
            {
                Console.WriteLine("{0}",cv*cv);
                cv++;
            }
            cv = 1;
            do
            {
                Console.WriteLine("{0}", cv*cv);
            } while (cv<16);
        }
        static void f1()
        {
            for (int i = 1; i < 21; i++)
            {   Console.Write("{0} ", i);
               
                
            }
            Console.WriteLine();
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("{0}", i);
                

            }
            Console.WriteLine();
        }
        static void f2()
        {
            for (int i = 15; i < 93; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        static void f3()
        {
            for (int i = 1; i < 16; i++)
            {
               
                Console.WriteLine("{0} ",i+i);
            }
            Console.WriteLine();
            for (int i = 1; i < 16; i++)
            {

                Console.Write("{0} ", i + i);
            }
        }
        static void f4()
        {
            Console.WriteLine("Adjon meg egy számot!");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            for (int i = 1; i < b+1 ; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        static void f5()
        {
            Console.WriteLine("Adjon meg egy számot!");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            for (int i = 1; i < b + 1; i++)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void f6()
        {
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine("{0}", Math.Pow(i,2));
            }
        }
        static void f7()
        {
            for (int i = 100; i < 401; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
    }
}
