using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString
{
    internal class Box<T>
    {

        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            T copy = Items[firstIndex];
            this.Items[firstIndex] = Items[secondIndex];
            this.Items[secondIndex] = copy;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in this.Items)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        
    }
}
