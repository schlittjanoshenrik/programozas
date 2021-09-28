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
            //uwu4();
            //uwu5();
            //uwu6();
            uwu7();

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
            Console.WriteLine("Adjon meg egy számot ami a  négyzet kerületét és területét fogja ki számolni!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kerület {0}",a*4);
            Console.WriteLine("Terület {0}",a*a);
           
        }
        static void uwu6()
        {
            Console.WriteLine("Adjon meg kétszámot ami a téglalap területét és kerületét fogja kiszámolnio!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("terület {2}",a , b, a*b );
            Console.WriteLine("kerület {2}",a ,b , 2*(a+b));
        }
        static void uwu7()
        {
            Console.WriteLine("Adjon meg kétszámot");
            int szam = int.Parse(Console.ReadLine());
            int szam2 = int.Parse(Console.ReadLine());

        }
    }
}
