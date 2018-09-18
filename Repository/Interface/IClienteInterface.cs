using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Repository
{
    interface IClienteInterface
    {
        int Add(Client oClient);
        List<Client> GetAll();
        int Modify(Client oCliente);
        Client GetByDni(string dni);
    }
}
