using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationLibrary;

namespace FormationUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AuthorTest()
        {
            Author a = new Author { Id = 1, Name = "Toto" };
            Assert.AreEqual(1, a.Id);
        }

        [TestMethod]
        public void BookTest()
        {
            Book b = new Book { Id = 1,Title ="Un titre",Category= Category.Roman};
            Assert.AreEqual(1, b.Id);
        }


        [TestMethod]
        public void PublisherTest()
        {
            Book b = new Book { Id = 1, Title = "Un titre", Category = Category.Roman, Publisher = new Publisher { Id = 2, Name = "Publisher" } };
            Assert.AreEqual(2, b.Publisher.Id);
        }

        [TestMethod]
        public void Author2Test()
        {
            Book b = new Book { Id = 1, Title = "Un titre", Category = Category.Roman };
            b.Authors.Add(new Author { Id = 1, Name = "Toto" });
            Assert.AreEqual(1, b.Authors.Count);
        }

        [TestMethod]
        public void Author2Test()
        {
            Book b = new Book { Id = 1, Title = "Un titre", Category = Category.Roman };
            b.Authors.Add(new Author { Id = 1, Name = "Toto" });
            Assert.AreEqual(1, b.Authors.Count);
        }


    }
}
