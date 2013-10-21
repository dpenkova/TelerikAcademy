using System;
using System.Text;

namespace GenericList
{
    // Task 05 - Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. 
    // Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
    // Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
    // clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.

    // Task 06 - Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

    // Task 07 - Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
    // You may need to add a generic constraints for the type T.

    public class GenericList<T>
        where T : IComparable
    {
        private T[] items;
        private int currentPosition = 0;

        // constructor with parameter capacity or default capacity 4
        public GenericList(int capacity = 4)
        {
            items = new T [capacity];
        }

        public int Count
        {
            get { return this.currentPosition; }
        }

        // adding element method

        public void AddItem(T item)
        {
            CheckListCapacity();

            this.items[this.currentPosition] = item;
            this.currentPosition++;
        }

        private void CheckListCapacity()
        {
            if (this.currentPosition == this.items.Length)
            {
                DoubleCapacity();
            }
        }

        // accessing element by index

        public T this[int index]
        {
            get 
            {
                CheckIndexRange(index);

                return this.items[index];
            }

            set
            {
                CheckIndexRange(index);

                this.items[index] = value;
            }
        }

        private void CheckIndexRange(int index)
        {
            if (index >= this.currentPosition || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index. Index range is [0 - {0}]", this.currentPosition - 1));
            }
        }

        // removing element by index

        public void RemoveItemByIndex(int index)
        {
            CheckIndexRange(index);

            T[] newArr = new T[this.items.Length];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = this.items[i];
            }

            for (int i = index + 1; i < this.currentPosition; i++)
            {
                newArr[i - 1] = this.items[i];
            }

            this.items = newArr;
            this.currentPosition--;
        }

        // inserting element at given position
        public void InsertItemAtPosition(int index, T value)
        {
            CheckIndexRange(index);
            CheckListCapacity();

            T[] newArr = new T [this.items.Length];

            for (int i = 0; i < index; i++)
            {
                newArr[i] = this.items[i];
            }

            newArr[index] = value;

            for (int i = index; i < this.currentPosition; i++)
            {
                newArr[i + 1] = this.items[i];
            }

            this.items = newArr;
            this.currentPosition++;
        }

        // more compact way without creating a temp array

        //public void InsertItemAtPosition(int index, T value)
        //{
        //    CheckIndexRange(index);
        //    CheckListCapacity();

        //    this.currentPosition++;

        //    for (int i = this.currentPosition - 1; i > index; i--)
        //    {
        //        this.items[i] = this.items[i - 1];
        //    }

        //    this.items[index] = value;
        //}

        // clearing the list

        public void ClearList()
        {
            //Array.Clear(this.items, 0, this.items.Length);
            
            this.items = new T[4];
            this.currentPosition = 0;
        }

        // finding element by its value 

        public int FindIndex(T value)
        {
            int index = -1;

            for (int i = 0; i < this.currentPosition; i++)
            {
                if (value.Equals(this.items[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        // override ToString
        public override string ToString()
        {
            StringBuilder itemsList = new StringBuilder();
            itemsList.AppendLine("\nList content\n----------------");

            for (int i = 0; i < this.currentPosition; i++)
            {
                itemsList.AppendFormat("{0, 5} : {1, -15}\n", i, this.items[i]);
            }

            itemsList.AppendLine("----------------");

            return itemsList.ToString();
        }



        // Task 06 - Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
        
        private void DoubleCapacity()
        {
            T[] newArr = new T[this.items.Length * 2];

            //Array.Copy(this.items, newArr, this.currentPosition);

            for (int i = 0; i < this.items.Length; i++)
            {
                newArr[i] = this.items[i];
            }

            this.items = newArr;
        }

        // Task 07 - Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. 
        // You may need to add a generic constraints for the type T.

        public T MinItem()
        {
            if (this.currentPosition == 0)
            {
                throw new Exception("The list is empty.");
            }

            if (this.currentPosition == 1)
            {
                return this.items[0];
            }

            else
            {
                T min = this.items[0];

                for (int i = 1; i < this.currentPosition; i++)
                {
                    if (min.CompareTo(this.items[i]) > 0)
                    {
                        min = this.items[i];
                    }
                }

                return min;
            }
        }

        public T MaxItem()
        {
            if (this.currentPosition == 0)
            {
                throw new Exception("The list is empty.");
            }

            if (this.currentPosition == 1)
            {
                return this.items[0];
            }

            else
            {
                T max = this.items[0];

                for (int i = 1; i < this.currentPosition; i++)
                {
                    if (max.CompareTo(this.items[i]) <= 0)
                    {
                        max = this.items[i];
                    }
                }

                return max;
            }
        }
    }
}
