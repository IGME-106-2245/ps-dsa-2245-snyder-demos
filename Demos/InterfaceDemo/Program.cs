namespace InterfaceDemo
{
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WeekDays today = WeekDays.Monday;


            if (today == WeekDays.Monday)
            {
                Console.WriteLine("I tolerate Mondays!");
            }
        }
    }
}
