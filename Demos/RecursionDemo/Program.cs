namespace RecursionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialIterative(5));
        }

        public static int FactorialIterative(int n)
        {
            int result = 1;
            while(n > 0)
            {
                result *= n;
                n--;
            }
            return result;
        }

        public static int Factorial(int n)
        {
            //base case
            if (n == 0)
            {
                return 1;
            }

            //recursive case
            else if (n > 0)
            {
                return n * Factorial(n - 1); //state change
            }
            //n < 0
            else 
            {
                return -1;
            }
        }
    }
}
