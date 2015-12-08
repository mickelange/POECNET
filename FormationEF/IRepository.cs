using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationEF
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByLambda(Func<T, bool> where);
        T insert(T entity);
        void Remove(T entity);
        void Save();
        //TP : faire aussi AbstractRepository
    }
}
