using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEF
{
    public class BookRepository2 : AbstractRepository<Book>
    {

        public IEnumerable<Book> GetByPrice(decimal price)
        {
            IEnumerable<Book> l = GetByLambda(book => book.Price <= price);
            return l;
        }

        public IEnumerable<Book> GetByTitle(string title)
        {
            IEnumerable<Book> l = GetByLambda(book => book.Title.ToUpper().Contains(title.ToUpper()));
            return l;
        }
    }
}
