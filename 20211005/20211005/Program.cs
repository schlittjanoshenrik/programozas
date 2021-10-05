using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            //f1();
            //f2();
            //f3();
            //f4();
            //f5();
            f6();
            

            Console.WriteLine("Nyomd le az entert!");
            Console.ReadLine();
        }
        static void f1()
        {
            
            for (int i = 1; i < 6; i++)
            {
                for (int szam = 1; szam < 16; szam++)
                {
                    Console.Write("{0}*{1}={2} ",i, szam, i*szam);
                }
                Console.WriteLine();
            }
        }
        static void f2()
        {
            int a = 2;
            int b = 3;
            int c = 5;
            for (int i = 0; i < 6; i++)
            {
                int terfogat =a*b*c;
                Console.WriteLine("a={0}, b={1} c={2} a térfogata={3} ", a,b,c,terfogat);
                a = a + 1;
                b = b + 2;
                c = c + 3;
            }

        }
        static void f3()
        {
            int a = 5;
            for (int i = 0; i < 10; i++)
            {
                int felszin = 6 * a * a;
                Console.WriteLine("a={0} felszíne={1}", a, felszin);
                a = a + 2;
            }
        }
        static void f4()
        {
            int szam ;
            
            do
            {   Console.WriteLine("Kérem a nullát");
                szam = int.Parse(Console.ReadLine());
               

            } while (szam!=0);
        }
        static void f5()
        {
            int szam;

            do
            {
                Console.WriteLine("Pozitív számot");
                szam = int.Parse(Console.ReadLine());


            } while (szam < 0);
        }
        static void f6()
        {
            int szam;
            do
            {
                Console.WriteLine("Max 10ig kérem a számot");
                szam = int.Parse(Console.ReadLine());
                int osszeg = szam+1;
                for (int i = 1; i < osszeg; i++)
                {
                    Console.WriteLine("{0}",osszeg+i);
                }
            } while (szam >10);
          
        }
    }

}
