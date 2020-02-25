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


            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);


            myList.Remove(value1);

            Console.WriteLine(myList[0]);

            Console.ReadLine();
            //Assert



        }
    }
}
