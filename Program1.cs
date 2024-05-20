using System;

namespace pritingtriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the desired height of the triangle:-");
            if (int.TryParse(Console.ReadLine(), out int height_of_triangle) && height_of_triangle > 0)
            {
                PrintingTriangle(height_of_triangle);
            }
            else
            {
                Console.WriteLine("enter the positive input not negative");
            }
        }

        static void PrintingTriangle(int height_of_triangle)
        {
            for (int i = 1; i <= height_of_triangle; i++)
            {
                
                for (int j = 0; j < height_of_triangle - i; j++)
                {
                    Console.Write(" ");
                }
              
                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
               
                Console.WriteLine();
            }
        }
    }
}