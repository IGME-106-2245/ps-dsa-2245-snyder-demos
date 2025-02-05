using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndIndexersDemo
{
    internal class MyList<T> where T: IActionable
    {
        // The data for the list and a constant for the initial size
        private T[] data;
        private const int InitCapacity = 2;

        // auto-property where the get is public, but not the set
        public int Count { get; private set; }

        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException(
                      "Your index is bad");
                }
                return data[i];
            }
            set
            {
                if (i < 0 || i >= Count)
                {
                    throw new IndexOutOfRangeException(
                        "Your index is bad");
                }
                data[i] = value;
            }
        }

        // Creates a basic list
        public MyList()
        {
            data = new T[InitCapacity];
            Count = 0;
        }

        // Adds an item to the list
        public void Add(T item)
        {
            // If we're out of space, make a bigger array,
            // copy the data over, then make our data field refer
            // to the new, bigger array
            if (Count == data.Length)
            {
                T[] newData = new T[data.Length * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    newData[i] = data[i];
                }
                data = newData;
            }

            // Add the new element & increment the count
            data[Count] = item;
            Count++;
        }

    }
}
