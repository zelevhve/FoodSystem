
using System;
using System.Collections.Generic;
using FoodSystem.Contracts;
using FoodSystem.Model;

namespace FoodSystem.DataContext
{
    public class ClienteData : Contracts.IClienteData
    {
        public void Delete(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente Save(Cliente entity)
        {
            throw new NotImplementedException();
        }

        IList<Cliente> IDataBase<Cliente>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
