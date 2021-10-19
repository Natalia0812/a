using System;

namespace a__
{
    class Program
    {
        static void Main(string[] args)
        {

            int a1 = 1;
            a1 = a1 * a1++;
            Console.WriteLine(a1);  //1

            int a2 = 1;
            a2 = a2++ *a2 ;
            Console.WriteLine(a2); //2

            Console.WriteLine();

            int b1 = 2;
            b1 = b1 * b1++;   //4
            Console.WriteLine(b1);

            int b2 = 2;
            b2 = b2++ * b2;
            Console.WriteLine(b2);  //6





            Console.WriteLine("Hello World!");
        }
    }
}
