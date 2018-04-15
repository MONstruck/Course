using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCourse
{
    class Program : ToDo
    {
 
            static void Main(string[] args)
            {
            double a, b, c, d, r;// input side of the cube and window 
            try
            {

                Console.WriteLine("Please write a 1 side of the cube");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write a 2 side of the cube");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write a 3 side of the cube");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write a 1 side of the window");
                d = double.Parse(Console.ReadLine());
                Console.WriteLine("Please write a 2 side of the cube");
                r = double.Parse(Console.ReadLine());


                if (IsNotNegative(a, b, c, d, r))// realization
                {
                    if ((Check(a, d, r) && Check(b, d, r)) || (Check(b, d, r) && Check(c, d, r)) || (Check(a, d, r) && Check(a, d, r)))
                    {

                        Console.WriteLine("Cube fit in");
                    }
                    else
                    {
                        Console.WriteLine("Cube not fit");
                    }
                }
                else
                {
                    Console.WriteLine("You write wrong parametrs");
                }
                Console.ReadKey();
            }
            catch (Exception e) { Console.WriteLine(e);  Console.ReadKey(); }

        }
        }
    }