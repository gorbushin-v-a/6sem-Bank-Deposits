using System.Collections.Generic;

namespace sharps_ent.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        IEnumerable<T> Get();
        T Get(int id);
        void Update(T item);
        void Remove(T item);
    }
}
