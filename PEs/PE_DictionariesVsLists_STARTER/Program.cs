namespace PE_DictionariesVsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new file reader, which loads a file of words
            // into both a list and a dictionary
            WordLoader reader = new WordLoader();

            // Get the two data structures needed for the exercise
            List<String> wordList = reader.WordList;
            Dictionary<String, bool> wordDictionary = reader.WordDictionary;
            string choice;

            // *********************
            // TODO: Put your code between here...
            Console.Write("Would you like to search (L)ist or (D)ictionary? >");
            choice = Console.ReadLine();

            if (choice == "L")
            {
                System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                watch.Start();              


                foreach (string word in wordList)
                {
                    if(wordList.Contains(word + word))
                    {
                        Console.WriteLine(word + word);
                    }
                }

                
                watch.Stop();
                Console.WriteLine(
                    "List search for all double words took "
                    + watch.Elapsed.TotalMilliseconds + "ms\n");
            }
            else if (choice == "D")
            {

            }
            // ...and here.
            // *********************
        }
    }
}
