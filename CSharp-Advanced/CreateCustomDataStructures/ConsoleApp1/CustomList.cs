using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class CustomList
    {
        private const int InitialSize = 2;


        private int[] items;
        private int counter = 0;
        public CustomList()
        {
            this.items = new int[InitialSize];
        }

        public int Count => this.counter;
        public int this[int i]
        {
            get
            {
                ValidateIndex(i);
                return this.items[i];
            }
            set
            {
                ValidateIndex(i);
                this.items[i] = value;
            }
        }

        public int RemoveAt(int index)
        {
            ValidateIndex(index);

            int removedValue = this.items[index];
            for (int i = index; i < counter - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
            this.counter--;
            if (this.items.Length / 2 >= this.counter)
            {
                int[] copy = new int[this.counter];
                Array.Copy(this.items, copy, this.counter);
                this.items = copy;
            }
            else
            {
                for (int i = counter; i < this.items.Length; i++)
                {
                    items[i] = default;
                }
            }

            return removedValue;
        }
        public void Add(int value)
        {
            if (this.counter == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.counter++] = value;
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < this.items.Length; i++)
            {
                if (value == this.items[i])
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            ValidateIndex(firstIndex);
            ValidateIndex(secondIndex);

            int copy = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = copy;
        }
        public void Resize()
        {
            int[] tempArr = new int[this.items.Length * 2];
            Array.Copy(this.items, tempArr, this.counter);
            this.items = tempArr;
        }

        public void Insert(int index, int item)
        {
            this.ValidateIndex(index);
            int[] copy = new int[this.counter + 1];

            for (int i = 0; i < index; i++)
            {
                copy[i] = this.items[i];
            }

            copy[index] = item;
            this.counter++;

            for (int i = index + 1; i < copy.Length; i++)
            {
                copy[i] = this.items[i - 1];
            }

            this.items = copy;
        }
        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.counter)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
