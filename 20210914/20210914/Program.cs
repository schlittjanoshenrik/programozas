using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210914
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");

            //uwu1();
            //uwu2();
            //uwu3();
            uwu4();
            uwu5();

            Console.ReadKey();
            Console.WriteLine();
        }
        static void uwu1()
        {

            Console.WriteLine("Adja meg  a nevét!");
            string nev = Console.ReadLine();
            Console.WriteLine("Hello {0}", nev);
        }
        static void uwu2()
        {

            Console.WriteLine("Adja meg  a nevét!");
            string nev = Console.ReadLine();
            Console.WriteLine("Hello {0}", nev);
        }
        static void uwu3()
        {
            
            Console.WriteLine("Adjon meg egy számot!");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", szam*2);


        }
        static void uwu4()
        {
            Console.WriteLine("Adjon meg kétszámot számot!");
            int szam = int.Parse(Console.ReadLine());
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Szorzat {0}*{1}={2}",szam,szam2, szam * szam2);
            Console.WriteLine("Osztás{0}/{1}={2}", szam, szam2, szam / szam2);
            Console.WriteLine("Összeadás{0}+{1}={2}", szam, szam2, szam + szam2);
            Console.WriteLine("Kivonás{0}-{1}={2}", szam, szam2, szam - szam2);
            Console.WriteLine("Maradék{0}%{1}={2}", szam, szam2, szam % szam2);
        }
        static void uwu5()
        {

        }
    }
}
