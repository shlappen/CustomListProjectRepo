using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
            yield return new ArgumentOutOfRangeException();
        }

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

        //COPY OVERLOAD
        public void Copy(T[] sourceArray, int j)
        {
            for (int i = j; j < count; i++)
            {
                array[i] = sourceArray[j];
                j++;
            }
        }
        //COPY OVERLOAD
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
                        break;
                    }
                    else
                    {
                        Copy(array, array, j);
                        //T[] sourceArray = new T[capacity];
                        Copy(targetArray);
                        break;
                    }
                }
                //else
                //{
                //    throw new ArgumentException("Index is outside the bounds of the array");
                //}
            }
        }


        //TOSTRING
        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(array[i].ToString() + ",");
            }
            return result.ToString();
        }



        //public override string ToString()
        //{
        //    string result = "";
        //    for (int i = 0; i < count; i++)
        //    {
        //        result += (array[i].ToString());
        //    }
        //    return result;
        //}


        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listTwo.count; i++)
            {
                listOne.Add(listTwo[i]);
            }
            CustomList<T> concatenatedList = new CustomList<T>();
            concatenatedList = listOne;
            return concatenatedList;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listOne.count - 1; i++)
            {
                for (int j = 0; j < listTwo.count - 1; j++)
                {
                    if (Equals(listOne[i], listTwo[j]))
                    {
                        listOne.Remove(listOne[i]);
                    }
                }
            }
            //foreach (T listOneItem in listOne)
            //{
            //    foreach (T listTwoItem in listTwo)
            //    {
            //        if (Equals(listOneItem, listTwoItem))
            //        {
            //            listOne.Remove(listOneItem);
            //        }

            //    }

            //}
            listOne.count -=;
            CustomList<T> concatenatedList = new CustomList<T>();
            concatenatedList = listOne;
            return concatenatedList;
        }
    }
}














