using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 5;
            int value5 = 1;
            int value6 = 6;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            CustomList<int> customList = one - two;

            Console.WriteLine("expected: " + "3,");
            Console.WriteLine(customList);
            Console.ReadLine();

            //CustomList<int> one = new CustomList<int>();
            //CustomList<int> two = new CustomList<int>();

            //string expected = "";
            //int value1 = 1;
            //int value2 = 3;
            //int value3 = 5;
            //int value4 = 1;
            //int value5 = 3;
            //int value6 = 5;

            //one.Add(value1);
            //one.Add(value2);
            //one.Add(value3);

            //two.Add(value4);
            //two.Add(value5);
            //two.Add(value6);
            //CustomList<int> customList = one - two;
            //string actual = customList.ToString();

            //Console.WriteLine((expected, actual));

            //CustomList<int> one = new CustomList<int>();
            //CustomList<int> two = new CustomList<int>();

            //string expected = "3,";
            //int value1 = 1;
            //int value2 = 3;
            //int value3 = 5;
            //int value4 = 5;
            //int value5 = 1;
            //int value6 = 6;

            //one.Add(value1);
            //one.Add(value2);
            //one.Add(value3);

            //two.Add(value4);
            //two.Add(value5);
            //two.Add(value6);
            //CustomList<int> customList = one - two;
            //string actual = customList.ToString();

            //Console.WriteLine((expected, actual));

            //CustomList<int> myList = new CustomList<int>();
            //int expected = 0;
            //int value1 = 2;
            //int value2 = 4;
            //int value3 = 6;

            //myList.Add(value1);
            //myList.Add(value2);
            //myList.Add(value3);

            //myList.Remove(value3);
            //int actual = myList[2];

            //Console.WriteLine((expected, actual));

            //CustomList<int> myList = new CustomList<int>();
            //int expected = 6;
            //int value1 = 2;
            //int value2 = 4;
            //int value3 = 6;

            //myList.Add(value1);
            //myList.Add(value2);
            //myList.Add(value3);

            //myList.Remove(value3);
            //int actual = myList[2];


            //Console.WriteLine(myList[2]);
            //Console.ReadLine();


            //CustomList<int> myList = new CustomList<int>();
            //int expected = 6;
            //int value1 = 2;
            //int value2 = 4;
            //int value3 = 6;
            //int value4 = 8;

            //myList.Add(value1);
            //myList.Add(value2);
            //myList.Add(value3);
            //myList.Add(value4);

            //myList.Remove(value4);
            //int actual = myList[2];

            //Console.WriteLine(myList[2]);


        }
    }
}
