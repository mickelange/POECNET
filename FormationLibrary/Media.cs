using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationLibrary
{
    public abstract class Media : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Category Category  { get; set; }
        public Publisher Publisher { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();

        public abstract double VATPrice { get; }

    }
}
