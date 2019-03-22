using System;

namespace Assignment1_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROBLEM 1
            int z, p;
          
            int a = 5, b = 15;
            printPrimeNumbers(a, b);

            Console.ReadKey();

            //PROBLEM 2
            //Console.WriteLine("Enter value ");
            int n1 = 5;
            double r1 = getSeriesResult(n1);
            Console.WriteLine("The sum of the series is: " + r1);

            Console.ReadKey();

            //PROBLEM 3
            /*Console.WriteLine("Print triangle");*/
           
            int n4 = 5;
            printTriangle(n4);


            Console.ReadKey();

            //PROBLEM 4
            int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };
            computeFrequency(arr);

            //CLOSES CONSOLE
            Console.ReadKey();

        } //PROBLEM 1 IDENTIFY PRIME NUMBERS
        public static void printPrimeNumbers(int a, int b)
        {
            try
            {
                int i, j;
                for (i = a; i <= b; i++)
                {
                    bool isPrime = true;
                    for (j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine("Prime:" + i);
                    }
                }
            }
            catch
            {
            Console.WriteLine("Exception occured while computing printPrimeNumbers()");
            }
        } //PROBLEM 2 COMPUTE FACTORIAL
        public static double getSeriesResult(int n)
        {
            try
            {
                int a = 1; // always start at 1 for factorial.
                double final = 0, result = 0;
                for (a = 1; a <= n; a++)
                {
                    final = ((Math.Pow(-1, (a + 1))) * factorial(a)) / (a + 1);
                    result = result + final;
                }
                return Math.Round(result, 3);
            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return 0;
        }
        public static double factorial(int b)
        {
            try
            {
                int counter, fact;
                fact = b;

                for (counter = b - 1; counter >= 1; counter--)
                {
                    fact = fact * counter;
                }
                return fact;

            }
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
            }
            return 0;
        }
            
            
            //PROBLEM 3 PRINT TRIANGLE 
        public static void printTriangle(int n)
        {
            try
            {
                int i, j, k, l;
                for (i = 1; i <= n; i++)
                {
                    for (j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    for (l = i; l > 1; l--)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                }

            }
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
            }

        } //COMPUTE FREQUENCY 
        public static void computeFrequency(int[] a)
        {
            try
            {
                int[] arr = { 1, 1, 1, 3, 3, 4, 5, 6, 7, 0 };
                int[] count = new int[10];

                
                for (int x = 0; x < 10; x++)
                {
                    for (int y = 0; y < arr.Length; y++)
                    {
                        if (arr[y] == x)
                            count[x]++;
                    }
                }

                //For displaying output only            
                for (int x = 0; x < 10; x++)
                    Console.WriteLine("Number " + x + " appears " + count[x] + " times");
            }
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
            }

        }
    }
}
