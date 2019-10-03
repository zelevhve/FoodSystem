using System;

namespace FoodSystem.Business
{
   
    public class ClienteBusiness
    {
        private Contracts.IClienteData _clienteData;

        public ClienteBusiness(Contracts.IClienteData clienteData)
        {
            if (clienteData == null)
                throw new ArgumentNullException("IClienteData");
            _clienteData = clienteData;
        }
    }
}
