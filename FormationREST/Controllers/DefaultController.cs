using FormationEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FormationREST.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpGet]
        public string Get()
        {
            return "hello";
        }

        [HttpGet]
        public string Get(int id)
        {
            return "hello" + id;
        }

        [HttpGet]
        [Route("api/book/{id}")]
        public Book GetBook(int id)
        {
            return new Book { Id = id };
        }

        [HttpGet]
        [Route("api/books")]
        public IEnumerable<Book> GetBooks()
        {
            List<Book> l = new List<Book>();
            l.Add(new Book { });

            return l;
        }
    }
}
