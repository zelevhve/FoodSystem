using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSystem.DataContext
{
    public class DataBase<T> : Contracts.IDataBase<T>
    {
        private DbContext _context;
        public DataBase(DbContext context)
        {
            _context = context;
        }
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public T Save(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
