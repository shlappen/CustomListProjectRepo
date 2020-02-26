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

        //public void Copy(T[] sourceArray, T[] targetArray, int j)
        //{
        //int k = 0;
        //if (j > 2)
        //{
        //    k = 2;
        //        }
        //else
        //{
        //for (int i = 0; i <= count - 1; i++)
        //{
        //    targetArray[i] = sourceArray[j];
        //    j++;
        //}
        //array = targetArray;
        //}
        //}

        public void Copy(T[] targetArray)
        {
            for (int i = 0; i < count; i++)
            {
                targetArray[i] = array[i];
            }
            array = targetArray;
        }

        public void Copy(T[] targetArray, int j)
        {
            for (int i = 0; i < count; i++)
            {
                targetArray[i] = array[j];
                j++;
            }
        }


        //public void Copy(T[] sourceArray, T[] newTargetArray, int j)
        //{
        //    for (int i = j; i < count; i++)
        //    {
        //        targetArray[i-1] = sourceArray[j];
        //        j++;
        //    }
        //    array = targetArray;
        //}

    


            //if count is 1 or cannot find value, throw error
    public void Remove(T item)
        {
            count--;
            T[] targetArray = new T[capacity];

            for (int i = 0; i < array.Length; i++)
            {
                if (Equals(array[i], item))
                {

                    //remove first value
                    var j = i;
                    if (j == 0)
                    {
                        j++;
                        Copy(targetArray, j);
                        array = targetArray;
                        break;
                    }

                    //remove last value
                    if (j == count)
                    {
                        Copy(targetArray);
                        array = targetArray;
                        break;
                    }
                    else
                    {
                        Copy(targetArray, j);

                    }
                }

            }
        }

        //9 tests failed
        //public void Remove(T item)
        //{
        //    count--;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (Equals(array[i], item))
        //        {
        //            int j = i;
        //            Copy(array, array, j);
        //        }

        //    }
        //}
        //public void Remove(T item)
        //{
        //    count--;
        //    int j = 0;
        //    if (Find(item, j) == true)
        //    {
        //        Copy(array, array, j);

        //    }




        //    int j = i;
        //    if (j == 0)
        //    {
        //        j++;
        //    }

        //    break;




        //}

        //public bool Find(T item, int j)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (Equals(array[i], item))
        //        {
        //            j = i;
        //            return true;
        //        }

        //    }
        //    return false;
        //}



    }

}














