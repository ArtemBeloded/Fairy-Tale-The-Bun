using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBun.Containers
{
    public class MyContainer<T> : List<T>
    {
        private T[] container = new T[10];

        public new int Count { get; private set; }

        public new T this[int i]
        {
            get
            {
                if (i < 0 || i >= Count)
                    throw new IndexOutOfRangeException();
                return container[i];
            }

            set
            {
                if (i < 0 || i >= Count)
                    throw new IndexOutOfRangeException();
                container[i] = value;
            }
        }

        public new void Add(T value)
        {
            if (Count >= container.Length)
                Array.Resize<T>(ref container, container.Length * 2);
            container[Count] = value;
            Count++;
        }

        public new void RemoveAt(int id)
        {
            List<T> list = container.ToList();
            list.RemoveAt(id);
            container = list.ToArray();
            Count--;
        }
    }
}
