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
                return Capacity;
            }
        }

        T[] array = new T[8];

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




        public void Add(T item)
        {
            count++;
            if (count >= 5 && count < 9)
            {
                capacity *= 2;
                T[] targetArray = new T[capacity];
                Copy(array, targetArray);
                array = targetArray;
                array[count - 1] = item;
            }
            else if (count >= 9 && count < 17)
            {
                capacity = 16;
                T[] targetArray = new T[capacity];
                Copy(array, targetArray);
                array = targetArray;
                array[count - 1] = item;
            }
            else
            {
                array[count - 1] = item;

            }

            //if this[int i] is greater than count + 1, throw exception
            //check how many objects are there
            //check how much capacity we need--
            //if objects greater than 4, less than 9 need capacity at 8,
            //greater than 8, less than 17, need capacity at 16
            //In the instance of 5 objects

        }

        public void Copy(T[] sourceArray, T[] targetArray)
        {
            for (int i = 0; i < sourceArray.Length; i++)
            {
                targetArray[i] = sourceArray[i];
            }

        }

        public void Remove()
        {
            
        }


    }









}

