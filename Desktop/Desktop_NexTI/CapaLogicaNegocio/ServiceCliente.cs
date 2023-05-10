using CapaAccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class ServiceCliente
    {
        private DatosCliente _datosClientes;

        public ServiceCliente(string connectionString)
        {
            _datosClientes = new DatosCliente(connectionString);
        }

        public int AddClient(Cliente cliente)
        {
            if (!IsValidID(cliente.Cedula.ToString()))
            {
                throw new ArgumentException("Invalid ID.");
            }

            if (!IsValidEmail(cliente.Correo))
            {
                throw new ArgumentException("Invalid email address.");
            }

            return _datosClientes.AddClient(cliente);
        }

        public List<Cliente> GetAllClients()
        {
            DataTable clientsTable = _datosClientes.GetAllClients();
            List<Cliente> clients = new List<Cliente>();

            foreach (DataRow row in clientsTable.Rows)
            {
                Cliente client = new Cliente
                {
                    ID = Convert.ToInt32(row["ID"]),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Cedula = row["Cedula"].ToString(),
                    Telefono = row["Telefono"].ToString(),
                    Correo = row["Correo"].ToString(),
                    FotoPerfil = (byte[])row["FotoPerfil"],
                    Cursos = row["Cursos"].ToString()
                };

                clients.Add(client);
            }

            return clients;
        }

        public Cliente GetClientById(int id)
        {
            return _datosClientes.GetClientById(id);
        }

        private bool IsValidID(string id)
        {
           
            if (id.Length != 10)
            {
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
