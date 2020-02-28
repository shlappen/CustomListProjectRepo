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
                array = targetArray;
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

        }

        //COPY OVERLOAD
        //j is count - 1 remove last
        public void Copy(T[] blankArray, int j)
        {
            for (int i = 0; i < j; i++)
            {
                blankArray[i] = array[i];
            }
        }
        //COPY OVERLOAD
        public void Copy(T[] sourceArray, T[] targetArray, int j)
        {
            for (int i = j; j + 1 < count; i++)
            {
                targetArray[i] = array[j + 1];
                j++;
            }
        }

        public bool Remove(T item)
        {
            T[] targetArray = new T[capacity];
            bool found = false;
            for (int i = 0; i < count; i++)
            {
                var j = i;

                if (Equals(array[i], item))
                {
                    found = true;

                    //remove last
                    if (j == count - 1)
                    {
                        Copy(targetArray, j);
                        array = targetArray;
                        break;
                    }
                    else
                    {
                        Copy(targetArray, j);
                        Copy(array, targetArray, j);
                        array = targetArray;
                        //T[] sourceArray = new T[capacity];
                        //Copy(sourceArray);
                        //array = sourceArray;
                        break;
                    }
                }
            }
            if (found)
            {
                count--;
            }
            return found;
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


        //Zip
        public CustomList<T> Zip(CustomList<T> list)
        {
            CustomList<T> concatenatedList = new CustomList<T>();
            for (int i = 0; i < list.count; i++)
            {
                concatenatedList.Add(array[i]);
                concatenatedList.Add(list[i]);

            }
            return concatenatedList;
        }

        //+Operator overload
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


        //-Operator overload
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> concatenatedList = new CustomList<T>();
            for (int i = 0; i < listTwo.count; i++)
            {
                listOne.Remove(listTwo[i]);
            }
            if (Equals(listOne[0], listTwo[0]))
            {
                listOne.Remove(listOne[0]);
            }
            concatenatedList = listOne;
            return concatenatedList;
        }
    }
}














