
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> Items { get; set; }
        public Box()
        {
            Items = new Stack<T>();
        }

        public int Count { get { return Items.Count; } }
        public void Add(T element)
        {
            Items.Push(element);
        }
        public T Remove()
        {
            return Count > 0 ? Items.Pop() : default(T);
        }

    }
}
