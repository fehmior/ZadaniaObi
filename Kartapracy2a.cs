using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1
            
            /*int a, b;
            int wynik = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            wynik = a + b;
            if (wynik % 2 == 0)
            {
                Console.WriteLine("Parzysta");
            }
            else
            {
                Console.WriteLine("Nieparzysta");
            }*/
            

            // Zad 2

            /*int a, b;
            double srGeo,srAry;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            srAry = (a + b) / 2;
            srGeo = a * b;
            srGeo = Math.Sqrt(srGeo);
            if (srGeo > srAry)
            {
                Console.WriteLine("Tak");
            }
            else
            {
                Console.WriteLine("Nie");
            }*/


            // Zad 3
            /*
            int k ,l ,m;
            k = int.Parse(Console.ReadLine());
            l = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            if (k==l)
            {
                Console.WriteLine("TAK");
            }
            else if (l == m)
            {
                Console.WriteLine("TAK");
            }
            else if(m == k)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */
            // Zad 4

            /*int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            if (a < b && a < c && c < d) 
            {
                Console.WriteLine($"Najmniejsza z liczb jest {a}");
            }
            if(b < a && b < c && c < d)
            {
                Console.WriteLine($"Najmniejsza z liczb jest {b}");
            }
            if(c < a && c < b && c < d)
            {
                 Console.WriteLine($"Najmniejsza z liczb jest {c}");
            }
            if (d < a && d < b && d < c)
            {
                Console.WriteLine($"Najmniejsza z liczb jest {c}");
            }
            if(a == b || a==c || a == d)
            {
                Console.WriteLine($"Najmniejsza z liczb jest {d}");
            }*/
            // Zad 5

            /*int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a > 0 && b > 0 && c > 0)
            {
                if (a < b + c && b < a + b && c < a + b)
                {
                    Console.WriteLine("Tak");
                }
                
                else
                {
                    Console.WriteLine("Nie");
                }
            }
            else
            {
                Console.WriteLine("Kazdy bok musi byc wiekszy od 0 ");
            }*/



            // Zad 6

            /*int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a > 0 && b > 0 && c > 0)
            {
                if (a < (b + c) && b < (a + b) && c < (a + b))
                {
                    if(a * a + b * b == c*c || a * a + c * c == b * b || b * b + c * c == a * a)
                    {
                        Console.WriteLine("trojkat prostoktny");
                    }
                    else if(a * a + b * b < c*c || a * a + c * c < b * b || b * b + c * c < a * a)
                    {
                        Console.WriteLine("trojkat rozwartokatny");
                    }
                    else if(a*a + b*b > c * c || a*a + c*c > b*b || b*b + c*c > a*a)
                    { 
                        Console.WriteLine("trojkat ostrokatny");
                    }
                }
            }
            else
            {
                Console.WriteLine("Kazdy bok musi byc wiekszy od 0 ");
            }
            */
        }
    }
}
