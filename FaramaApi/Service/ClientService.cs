using FaramaApi.Model;
using System.Security.Cryptography.X509Certificates;

namespace FaramaApi.Service
{
    public class ClientService
    {
        public List<Cliente> MostrasCliente() 
        {
            List<Cliente> listClientes = new List<Cliente>();

            Cliente cliente1 = new Cliente(1, "Rafael");
            Cliente clinte2 = new Cliente(2, "Neymar");

            listClientes.Add(cliente1);

            return listClientes;
                
        }

        
    }
}
