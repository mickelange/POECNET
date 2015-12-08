using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEF
{
    public class BookRepository : IRepository<Book>
    {
        public FormationEntities Entities
        {
            get; set;
        } = new FormationEntities();

        public IEnumerable<Book> GetAll()
        {
            IEnumerable<Book> l = Entities.Books.ToList();
            return l;
        }

        public Book GetById(int id)
        {
            Book b = Entities.Books.Find(id);
            return b;
        }

        public IEnumerable<Book> GetByLambda(Func<Book, bool> where)
        {
            IEnumerable<Book> ie = Entities.Books.Where(where);
            return ie;
        }

        public Book insert(Book entity)
        {
            Entities.Books.Add(entity);
            return entity;
        }

        public void Remove(Book entity)
        {
            Entities.Books.Remove(entity);
           
        }

        public void Save()
        {
            Entities.SaveChanges();
        }

        public IEnumerable<Book> GetByPrice(decimal price)
        {
            IEnumerable<Book> l = GetByLambda(book =>book.Price<= price);
            return l;
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            IEnumerable<Book> l = GetByLambda(book => book.Title.ToUpper().Contains(title.ToUpper()));
            return l;
        }

        public IEnumerable<Book> GetByLambda(Func<Book, bool> where, int page, int nbRow)
        {
            IEnumerable<Book> ie = Entities.Books.Where(where).Skip(page*nbRow).Take(nbRow);
            return ie;
        }

    }
}
