namespace DictionariesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary that maps
            // strings to other strings
            Dictionary<String, String> dict = new Dictionary<String, String>();

            // Add some data
            dict.Add("Pax", "123-4567");
            dict.Add("Pax?", "cell number");
            dict.Add("Shiro", "555-5555");
            dict["Jenny"] = "867-5309";

            Console.WriteLine("Pax’s number: " + dict["Pax"]);

            // Check to see if the key "Jenny" is in
            // the dictionary before attempting to
            // retrieve it
            if (dict.ContainsKey("Jenny"))
            {
                Console.WriteLine(dict["Jenny"]);
            }


        }
    }
}
