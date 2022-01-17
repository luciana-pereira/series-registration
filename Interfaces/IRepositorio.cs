using System.Collections.Generic;

namespace series.registration.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Insert(T entidade);
        void Delet(int id);
        void Update(int id, T entidade);
        int NextId();
        
    }
}