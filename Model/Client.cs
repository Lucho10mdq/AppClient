using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        int clientId;
        string name, lastname, dni, address;
        DateTime    fechaNacimiento;

        public Client(string name, string lastname, string dni, string address, DateTime fechaNacimiento)
        {
            this.name = name;
            this.lastname = lastname;
            this.dni = dni;
            this.address = address;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
