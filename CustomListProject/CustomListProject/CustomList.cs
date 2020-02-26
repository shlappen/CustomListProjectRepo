using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {



        private int capacity = 4;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        T[] array = new T[4];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }


        //ADD
        public void Add(T item)
        {
            count++;
            if (count == capacity)
            {
                capacity *= 2;
                T[] targetArray = new T[capacity];
                Copy(targetArray);
                array[count - 1] = item;
            }
            else
            {
                array[count - 1] = item;
            }
        }

        //COPY
        public void Copy(T[] targetArray)
        {
            for (int i = 0; i < count; i++)
            {
                targetArray[i] = array[i];
            }
            array = targetArray;
        }

        public void Copy(T[] sourceArray, T[] targetArray, int j)
        {
            for (int i = j; j < count; i++)
            {
                targetArray[i] = sourceArray[j + 1];
                j++;
            }
            array = targetArray;
        }


        //REMOVE
        //if count is 1 or cannot find value, throw error
        public void Remove(T item)
        {
            count--;
            T[] targetArray = new T[capacity];
            for (int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i], item))
                {
                    var j = i;
                    if (j == count)
                    {
                        Copy(targetArray);
                        array = targetArray;
                        break;
                    }
                    else
                    {
                        Copy(array, array, j);
                        Copy(targetArray);
                        break;
                    }
                }
            }
        }


        //TOSTRING
        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(array[i].ToString());
            }
            return result.ToString();
        }
        //{
        //    customListString = item.ToString();
        //}
        //return customListString;

        //return $"[{ToString()}]";





    }
}














