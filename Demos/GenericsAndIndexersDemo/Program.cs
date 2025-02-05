namespace GenericsAndIndexersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyList<String> names = new MyList<String>();
            //names.Add("Shiro");
            //names.Add("Pax");
            //names.Add("Lacy");

            //try
            //{ 
            //    names[10] = "Ellie";
            //}
            //catch (IndexOutOfRangeException e) 
            //{
            //    Console.WriteLine(e.Message);
            //}

            //MyList<int> intList = new MyList<int>();
            //MyList<double> doubleList = new MyList<double>();
            //MyList<bool> boolList = new MyList<bool>();
            //MyList<MyList<string>> listOfStringLists = new MyList<MyList<string>>();

            MyList<Dog> dogList = new MyList<Dog>();

            dogList.Add(new Dog());

            MyList<Cat> catList = new MyList<Cat>();

            catList.Add(new Cat());

            Console.WriteLine(dogList[0]);

            
      
        }
    }
}
