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
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);


            myList.Remove(value2);

            Console.WriteLine(myList[0]);

            Console.ReadLine();
            //Assert



        }
    }
}
