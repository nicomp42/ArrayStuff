using System;

namespace ArrayStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] alpha = new int[5];
            // Not a Best Practice to let the compiler initialize our array
            Console.WriteLine(alpha[0]);
            Console.WriteLine(alpha[1]);
            Console.WriteLine(alpha[2]);
            Console.WriteLine(alpha[3]);
            Console.WriteLine(alpha[4]);

            Console.WriteLine(alpha[5]);    // index out of range exception

            alpha[5] = 42;


        }
    }
}
