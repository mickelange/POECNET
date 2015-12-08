using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FormationEF;
using System.Collections.Generic;
using System.Linq;

namespace FormationEFTest
{
    [TestClass]
    public class UnitTest1
    {
        /* [TestMethod]
         public void EFTest()
         {
             FormationEntities entities = new FormationEntities();
             List<Book> l = entities.Books.ToList();
             Book b = new Book { Title = "EF", Price = 9.99m };
             entities.Books.Add(b);
             entities.SaveChanges();
             b = entities.Books.First();
             b.Price += 1;
             entities.SaveChanges();
             b = entities.Books.Find(1);

             //LINQ langage integré de requette
             //IEnumerable est au dessu de toutes les collections
             //avantage : vrai langage, intellicence, acces aux methodes developpés ds le projet
             //lazy loading : requete faite au dernier moment.
             IEnumerable<Book> ie = from Book in entities.Books
                                    where Book.Price < 10
                                    orderby Book.Id
                                    select Book;


             IEnumerable<Book> ie2 = from Book in entities.Books
                                     where Book.Title.ToUpper().Contains(".NET")
                                     orderby Book.Id
                                     select Book;

             // LINQ ne lancera la requete que lorsqu'on fera un forech par exemple
             // deplus LINQ optimise le reQUETTAGE : IL PEUT decider de ne faaire qu'une seule requete de ces 3.
             IEnumerable<Book> ie3 = ie2.Intersect(ie);

             //LAMBDA expression
             // => se lit "donne"
             //ecriture + concise.
             //lambda permet d'avoir une fonction arythmétique dans le where
             ie = entities.Books.Where(Book => Book.Price < 10).OrderBy(Book => Book.Id);
             ie2 = entities.Books.Where(Book => Book.Title.ToUpper().Contains(".NET")).OrderBy(Book => Book.Id);
             // la variable f contient une fonction
             Func<Book, bool> f = Book => Book.Title.ToUpper().Contains(".NET");
             ie2 = entities.Books.Where(f);
             //entities.set<Book>() <=> entities.Books
         }*/

        [TestMethod]
        public void BookRepositoryGetAllTest()
        {
            BookRepository bookRepo = new BookRepository();
            IEnumerable<Book> bookList = bookRepo.GetAll();
            Assert.AreEqual(2, bookList.Count());
        }

        [TestMethod]
        public void BookRepositoryGetByIdTest()
        {
            BookRepository bookRepo = new BookRepository();
            Book b  = bookRepo.GetById(1);
            Assert.AreEqual(1, b.Id);
        }

        [TestMethod]
        public void BookRepositoryInsertDelete()
        {
            BookRepository bookRepo = new BookRepository();

            Book b = new Book { Title = "Le chateau de Hurle", Price = 9.99m };
            bookRepo.insert(b);
            bookRepo.Save();

           // Assert.IsTrue(bookRepo.Entities.Books.Contains(b));
            bookRepo.Remove(b);
            bookRepo.Save();
            IEnumerable<Book> bookList = bookRepo.GetAll();
            Assert.AreEqual(2, bookList.Count());

        }


        [TestMethod]
        public void BookRepositoryGetByLambda()
        {
            BookRepository bookRepo = new BookRepository();
            IEnumerable<Book> bookList = bookRepo.GetByLambda(book => book.Price <= 10);
            Assert.AreEqual(1, bookList.Count());
        }
        [TestMethod]
        public void BookRepositoryGetByTitle()
        {
            BookRepository bookRepo = new BookRepository();
            IEnumerable<Book> bookList = bookRepo.GetByTitle("java");
            Assert.AreEqual(1, bookList.Count());
        }

    }
}
