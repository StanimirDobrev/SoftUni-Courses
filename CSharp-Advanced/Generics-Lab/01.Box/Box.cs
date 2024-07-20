using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _BoxOfT
{
    public class Box<T>
    {
        private Stack<T> elements;

        public Box()
        {
            elements = new Stack<T>();
        }

        public int Count { get { return elements.Count; } }
        public void Add(T element)
        {
            elements.Push(element);
        }

        public T Remove()
        {
            T removedElement = elements.Pop();

            return removedElement;
        }

        
    }
}
