using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository;

namespace Service
{
    public class ServiceClient
    {
        private ClienteRepository listClient = ClienteRepository.GetInstance();

        public void Add(string name,string lastName,string dni,string address,DateTime birtbirthdate)
        {
            Client oClient = new Client(name, lastName, dni, address, birtbirthdate);
            listClient.Add(oClient);
        }
        public List<Client> GetAll()
        {
            return listClient.GetAll();
        }
        public Client GetByDni(string dni)
        {
            Client oClient = null;
            return oClient = listClient.GetByDni(dni);
        }

        public void Modify(string name,string lastName,string dni,string addres,DateTime birthdate)
        {
            Client oCliente = new Client(name, lastName, dni, addres, birthdate);
            listClient.Modify(oCliente);
        }
    }
}
