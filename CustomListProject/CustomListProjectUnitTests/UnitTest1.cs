﻿using System;
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
        //remove anything not in the list count stays the same
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_Value1From2ValueArrayGetIndex0_GetException()
        {
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;


            myList.Add(value1);


            myList.Remove(myList[1]);
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
        public void Remove_Value2From2ValueArray_GetIndex1()
        {
            CustomList<int> myList = new CustomList<int>();
            int expected = 0;
            int value1 = 2;
            int value2 = 4;

            myList.Add(value1);
            myList.Add(value2);

            myList.Remove(value1);
            int actual = myList[1];


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


        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]

        //public void Remove_NonExistent

        //[TestMethod]
        //public void Remove_Value

    }
}
