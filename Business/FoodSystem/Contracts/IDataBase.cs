
using System.Collections.Generic;

namespace FoodSystem.Contracts
{
    public interface IDataBase<T>
    {
        T Save(T entity);
        void Delete(T entity);
        T GetById(int id);
        IList<T> GetAll();
    }
}
