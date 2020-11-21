using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReverseLinkedLIst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var list = new List<string>
            {
                "a",
                "b",
                "c",
                "d"
            };

            var test = ReverseLinkedList(list);

        }

        // a b c d e
        // e d c b a
        //list.Reverse(); //glad someone already figured out the algorithm
        //return list;
        public static List<string> ReverseLinkedList(List<string> list)
        {
            var endOfList = list.Count - 1;
            var middle = new List<string>();
            
            for (int i = 0; i < list.Count; i++)
            {
                var lastItem = list[endOfList - i];
                middle.Add(lastItem);

            }

            list.Clear();
            list.AddRange(middle);
 
            return list;
        }

    }

    [TestClass]
    public class TestProgram
    {

        [TestMethod]
        public void GivenTwoLettersSetReverseStrings()
        {
            var inital_list = new List<string> { "a", "b" };
            var expected = new List<string> { "b", "a" };

            var actual = Program.ReverseLinkedList(inital_list);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenThreeItemsReverseStrings()
        {
            var inital_list = new List<string> { "a", "b", "c" };
            var expected = new List<string> { "c", "b", "a" };

            var actual = Program.ReverseLinkedList(inital_list);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given4ItemsReverseStrings()
        {
            var inital_list = new List<string> { "a", "b", "c", "d" };
            var expected = new List<string> { "d", "c", "b", "a" };

            var actual = Program.ReverseLinkedList(inital_list);

            Assert.AreNotEqual(expected, actual); //requirement was it returned the same list object
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given5ItemsReverseStrings()
        {
            var inital_list = new List<string> { "a", "b", "c", "d", "e" };
            var expected = new List<string> { "e", "d", "c", "b", "a" };

            var actual = Program.ReverseLinkedList(inital_list);

            Assert.AreNotEqual(expected, actual); //requirement was it returned the same list object
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Given8ItemsReverseStrings()
        {
            var inital_list = new List<string> { "a", "b", "c", "d", "e","f","g","h" };
            var expected = new List<string> { "h","g", "f","e", "d", "c", "b", "a" };

            var actual = Program.ReverseLinkedList(inital_list);

            Assert.AreNotEqual(expected, actual); //requirement was it returned the same list object
            CollectionAssert.AreEqual(expected, actual);
        }

    }

}
