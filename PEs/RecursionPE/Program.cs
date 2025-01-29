namespace RecursionPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // local variables for testing our recursive methods
            const int NumElements = 5;
            int[] nums = new int[NumElements];
            int[] numsReverse = new int[NumElements];
            int[] numsRandom = new int[NumElements];
            Random rng = new Random();
            string word;

            // Setup 3 arrays - nums in order, nums in reverse order, nums with random values
            for (int i = 0; i < NumElements; i++)
            {
                nums[i] = i;
                numsReverse[i] = NumElements - i - 1;
                numsRandom[i] = rng.Next(0, NumElements * 3);
            }

            // Put the number 42 at a random location in the non-random arrays
            nums[rng.Next(NumElements)] = 42;
            numsReverse[rng.Next(NumElements)] = 42;

            // Print each array
            PrintArray("In order", nums);
            PrintArray("In reverse", numsReverse);
            PrintArray("Random", numsRandom);
            Console.WriteLine();

            
            // Calc the factorial of each random number
            for (int i = 0; i < NumElements; i++)
            {
                Console.WriteLine($"{numsRandom[i]}! = {Factorial(numsRandom[i])}");
            }
            Console.WriteLine();

            /*
            // Sum the elements of each array
            Console.WriteLine($"Sum of nums is {Sum(nums)}");
            Console.WriteLine($"Sum of numsReverse is {Sum(numsReverse)}");
            Console.WriteLine($"Sum of numsRandom is {Sum(numsRandom)}");
            Console.WriteLine();
            */

            // Find if the number 3 is in each array
            Console.WriteLine($"Contains 3 in nums: {Contains(nums, 3)}");
            Console.WriteLine($"Contains 3 in numsReverse: {Contains(numsReverse, 3)}");
            Console.WriteLine($"Contains 3 in numsRandom: {Contains(numsRandom, 3)}");
            Console.WriteLine();

            // Find if the number 42 is in each array
            Console.WriteLine($"Contains 42 in nums: {Contains(nums, 42)}");
            Console.WriteLine($"Contains 42 in numsReverse: {Contains(numsReverse, 42)}");
            Console.WriteLine($"Contains 42 in numsRandom: {Contains(numsRandom, 42)}");
            Console.WriteLine();


            /*
            // Prompt the user for a word to test string methods
            Console.WriteLine("Enter a word:");
            word = Console.ReadLine();
            Console.WriteLine($"Is {word} a palindrome? {IsPalindrome(word)}");
            Console.WriteLine($"Reverse of {word} is {Reverse(word)}");
            */
        }

        /// <summary>
        /// Helper method to output array data
        /// </summary>
        /// <param name="label"></param>
        /// <param name="nums"></param>
        public static void PrintArray(string label, int[] nums)
        {
            Console.Write(label + ": ");
            foreach(int n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Factorial(int n)
        {
            //Base Case & Error combined
            if (n <= 1)
            {
                if (n < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else 
            {
                return n * Factorial(n - 1); //State Change n-1;
            }

            //Base case and Error separate 
            //if (n == 0)
            //{
            //    return 1;
            //}
            ////Recursive Case
            //else if (n > 0)
            //{
            //    return n * Factorial(n - 1); //State Change n-1;
            //}
            ////Error Case
            //else
            //{
            //    return -1;
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        static bool Contains(int[] nums, int target)
        {
            //Solution reducing the size of the array

            //Base case - nums is null or empty
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            //Base case - 1 element
            else if (nums.Length == 1)
            {
                return nums[0] == target;
            }
            //Recursive Case
            // https://learn.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            {
                return (nums[0] == target)  // 1st element matches
                    ||                      // OR
                                            //[1..] --- gets subarray from index 1 to end
                    Contains(nums[1..], target); //Something in the rest of the array matches (state change)
            }
        }
    }
}
