using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClassLibrary
{
    public interface IRepository<T> where T:  class
    {
        void Add(T Obj);
        T Rmeove(T obj);
        T F(T obj);
        IEnumerable<T> GetAll();
        
    }
}
