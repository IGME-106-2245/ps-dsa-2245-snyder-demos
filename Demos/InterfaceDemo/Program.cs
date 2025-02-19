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
            List<IPettable> petList = new List<IPettable>();

            petList.Add(new Dog());

            petList.Add(new Cat());

            foreach (IPettable pet in petList)
            {
                if (pet is Cat)
                {
                    pet.ReceivePets();

                }
            }
        }
    }
}
