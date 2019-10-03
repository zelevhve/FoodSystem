using System.Collections.Generic;

namespace FoodSystem.Contracts
{
    public interface IClienteData : IDataBase<Model.Cliente>
    {
        List<Model.Cliente> GetAll();
    }
}
