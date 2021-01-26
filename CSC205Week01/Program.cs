using System;

namespace CSC205Week01
{
    class Program
    {
        // making a 3 rows triangle using carots 
        static void Main(string[] args)
        {
            //Printing out the names of my teammates and me
            Console.WriteLine("My teammates are: Evan Ritter, Yauchin Lam, Bao Tran (myself)");

            //Caret
            int count = 3;
            int count2 = 3;
            //first for loop is to print out the rows of the pattern
            for (int i = 1; i <= 3; i++)
            {
                for (int j = count; j > 0; j--)
                {
                    Console.Write(" ");                       
                }

                for (int k = count; k <= count2; k++)
                {
                    Console.Write("^");
                }
                count--;
                count2++;
                Console.WriteLine();
            }
        }
    }
}
