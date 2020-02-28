using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListProjectUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        //ADD
        [TestMethod]
        public void Add_OneValue_CountIncrement()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;

            //Act
            myList.Add(5);

            //Assert
            Assert.AreEqual(expected, myList.Count);
        }
        [TestMethod]
        public void Add_OneValue_ReturnIndex0()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;

            //Act
            myList.Add(expected);

            //Assert
            Assert.AreEqual(expected, myList[0]);
        }
        [TestMethod]
        public void Add_TwoValues_ReturnIndex1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 10;
            int value1 = 5;
            int value2 = 10;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            //Assert
            Assert.AreEqual(expected, myList[1]);
        }

        [TestMethod]
        public void Add_ThreeValues_ReturnIndex2()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 15;
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_FourValues_ReturnIndex3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int expected = 20;
            int value1 = 5;
            int value2 = 10;
            int value3 = 15;
            int value4 = 20;
            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            //Assert
            Assert.AreEqual(expected, myList[3]);
        }

        [TestMethod]
        public void Add_5Values_VerifyValueAtIndex0Persists()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            Assert.AreEqual(expected, myList[0]);

        }

        [TestMethod]
        public void Add_5Values_DoubleCapacity()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 8;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            Assert.AreEqual(expected, myList.Capacity);
        }

        [TestMethod]
        public void Add_5Values_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 5;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            Assert.AreEqual(expected, myList.Count);
        }

        [TestMethod]
        public void Add_9Values_VerifyValueAtIndex0Persists()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;
            int value6 = 12;
            int value7 = 14;
            int value8 = 16;
            int value9 = 18;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);

            Assert.AreEqual(expected, myList[0]);
        }

        [TestMethod]
        public void Add_9Values_VerifyValueAtIndex5Persists()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 12;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;
            int value6 = 12;
            int value7 = 14;
            int value8 = 16;
            int value9 = 18;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);

            Assert.AreEqual(expected, myList[5]);
        }

        [TestMethod]
        public void Add_9Values_DoubleCapacity()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 16;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;
            int value6 = 12;
            int value7 = 14;
            int value8 = 16;
            int value9 = 18;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);

            Assert.AreEqual(expected, myList.Capacity);
        }

        [TestMethod]
        public void Add_9Values_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 9;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;
            int value6 = 12;
            int value7 = 14;
            int value8 = 16;
            int value9 = 18;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);

            Assert.AreEqual(expected, myList.Count);
        }




        //Test if it removes dup values
        //indexer exception
        //Remove
        //remove anything not in the list, count stays the same

        [TestMethod]
        public void Remove_NonExistentValue_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;
            int value1 = 2;


            myList.Add(value1);


            myList.Remove(20);
            int actual = myList.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ValueFrom1ValueArray_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 0;
            int value1 = 2;


            myList.Add(value1);


            myList.Remove(value1);
            int actual = myList.Count;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Value1From2ValueArray_GetIndex0()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int value1 = 2;
            int value2 = 4;

            myList.Add(value1);
            myList.Add(value2);

            myList.Remove(value1);
            int actual = myList[0];


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value2From2ValueArray_GetIndex0()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int value1 = 2;
            int value2 = 4;

            myList.Add(value1);
            myList.Add(value2);

            myList.Remove(value1);
            int actual = myList[0];


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_ValueNotInList_ReturnFalse()
        {
            CustomList<int> myList = new CustomList<int>();
            bool expected = false;
            int value1 = 2;
            int value2 = 4;

            myList.Add(value1);
            myList.Add(value2);

            bool actual = myList.Remove(5);


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value1From2ValueArray_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 1;
            int value1 = 2;
            int value2 = 4;

            myList.Add(value1);
            myList.Add(value2);

            myList.Remove(value1);
            int actual = myList.Count;


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value1From3ValueArray_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value1);
            int actual = myList.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value2From3ValueArray_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value2);
            int actual = myList.Count;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value3From3ValueArray_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value3);
            int actual = myList.Count;

            Assert.AreEqual(expected, actual);

        }



        //RemoveValuesGetIndexes
        [TestMethod]
        public void Remove_Value1From3ValueArray_GetIndex0()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value1);
            int actual = myList[0];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value2From3ValueArray_Index0Persists()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value2);
            int actual = myList[0];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value3From3ValueArray_GetIndex0()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 2;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value3);
            int actual = myList[0];

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void Remove_Value1From3ValueArray_GetIndex1()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 6;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value1);
            int actual = myList[1];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value2From3ValueArray_GetIndex1()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 6;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value2);
            int actual = myList[1];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value3From3ValueArray_GetIndex1()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value3);
            int actual = myList[1];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value3From3ValueArray_GetIndex2()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 0;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value3);
            int actual = myList[2];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value3From4ValueArray_GetIndex2()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 8;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);


            myList.Remove(value3);
            int actual = myList[2];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_Value4From4ValueArray_GetIndex2()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 6;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;

            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            myList.Remove(value4);
            int actual = myList[2];

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_OneValueInListOfDuplicates_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 3;
            int value1 = 2;
            int value2 = 2;
            int value3 = 2;
            int value4 = 2;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            myList.Remove(value1);
            int actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_Value4WhenSameValueIsAtIndex1_GetIndex1()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 6;
            int value1 = 5;
            int value2 = 2;
            int value3 = 6;
            int value4 = 2;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            myList.Remove(value4);
            int actual = myList[1];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_ValueNotInList_GetCount()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 4;
            int value1 = 5;
            int value2 = 2;
            int value3 = 6;
            int value4 = 2;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            myList.Remove(7);
            int actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }












        /////ToString();
        [TestMethod]
        public void ToString_4IntList()
        {
            CustomList<int> myList = new CustomList<int>();
            string expected = "1,2,3,4,";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            string actual = myList.ToString();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ToString_3BoolList()
        {

            CustomList<bool> myList = new CustomList<bool>();
            string expected = "False,True,True,";
            bool value1 = false;
            bool value2 = true;
            bool value3 = true;


            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            string actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_2StringList()
        {
            CustomList<string> myList = new CustomList<string>();
            string expected = "This,works,";
            string value1 = "This";
            string value2 = "works";

            myList.Add(value1);
            myList.Add(value2);

            string actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_PlusOperator_ConcatenateTwoLists()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "1,3,5,2,4,6,";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            one.Add(value1);
            one.Add(value3);
            one.Add(value5);

            two.Add(value2);
            two.Add(value4);
            two.Add(value6);
            CustomList<int> customList = one + two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Overload_PlusOperator_GetCount()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            int expected = 6;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            one.Add(value1);
            one.Add(value3);
            one.Add(value5);

            two.Add(value2);
            two.Add(value4);
            two.Add(value6);
            CustomList<int> customList = one + two;
            int actual = customList.Count;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_PlusOperator_GetCapacity()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            int expected = 8;
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            one.Add(value1);
            one.Add(value3);
            one.Add(value5);

            two.Add(value2);
            two.Add(value4);
            two.Add(value6);
            CustomList<int> customList = one + two;
            int actual = customList.Capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_PlusOperator_AddTwoLists_DifferentSizes()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "1,2,3,4,5,6,7,";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            two.Add(value7);
            CustomList<int> customList = one + two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_2ListsSameSize_Subtract1ValueFromList1()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "3,5,";
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 1;
            int value6 = 6;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            CustomList<int> customList = one - two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_2ListsSameSize_Subtract2ValuesFromList1()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "3,";
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
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_2ListsDifferentSize_Subtract1ValueFromList1()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "3,5,";
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 1;
            int value6 = 6;
            int value7 = 6;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            two.Add(value7);
            CustomList<int> customList = one - two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_2ListsDifferentSize_Subtract2ValuesFromList1()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "3,5,";
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 2;
            int value5 = 1;
            int value6 = 6;
            int value7 = 6;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            two.Add(value7);
            CustomList<int> customList = one - two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_List1Has2DupValuesList2Has1OfSame_Subtract()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "1,5,";
            int value1 = 1;
            int value2 = 1;
            int value3 = 5;
            int value4 = 2;
            int value5 = 1;
            int value6 = 2;
            int value7 = 6;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            two.Add(value7);
            CustomList<int> customList = one - two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_2ListsSameValues_Subtract()
        {
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();

            string expected = "";
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;
            int value4 = 1;
            int value5 = 3;
            int value6 = 5;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);
            CustomList<int> customList = one - two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_SubtractIntListFromItself()
        {
            CustomList<int> one = new CustomList<int>();

            string expected = "";
            int value1 = 1;
            int value2 = 3;
            int value3 = 5;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            CustomList<int> customList = one - one;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Overload_MinusOperator_SubtractBoolListFromBoolList()
        {
            CustomList<bool> one = new CustomList<bool>();
            CustomList<bool> two = new CustomList<bool>();

            string expected = "True,";
            bool value1 = true;
            bool value2 = true;
            bool value3 = false;
            bool value4 = false;
            bool value5 = true;
            bool value6 = false;

            one.Add(value1);
            one.Add(value2);
            one.Add(value3);

            two.Add(value4);
            two.Add(value5);
            two.Add(value6);

            CustomList<bool> customList = one - two;
            string actual = customList.ToString();

            Assert.AreEqual(expected, actual);
        }

        //ZIP
        [TestMethod]
        public void Zip_OddAndEvenLists_Together()
        {
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();

            string expected = "1,2,3,4,5,6,";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;

            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);

            even.Add(value2);
            even.Add(value4);
            even.Add(value6);

            string actual = odd.Zip(even).ToString();

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Zip_TwoListsDifferentSizes_Together()
        {
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();

            string expected = "1,2,3,4,5,6,";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;

            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            odd.Add(value7);

            even.Add(value2);
            even.Add(value4);
            even.Add(value6);

            string actual = odd.Zip(even).ToString();

            Assert.AreEqual(expected, actual);

        }



        [TestMethod]
        public void Zip_TwoListsWhereSomeValuesAreTheSame_Together()
        {
            CustomList<int> odd = new CustomList<int>();
            CustomList<int> even = new CustomList<int>();

            string expected = "1,2,3,4,5,6,7,2,";
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;

            odd.Add(value1);
            odd.Add(value3);
            odd.Add(value5);
            odd.Add(value7);

            even.Add(value2);
            even.Add(value4);
            even.Add(value6);
            even.Add(value2);

            string actual = odd.Zip(even).ToString();

            Assert.AreEqual(expected, actual);

        }
    }
}
