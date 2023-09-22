using System;
using Infraestructura.Datos;
using Infraestructura.Modelos;

namespace Servicios.ClienteService
{
    public class ClienteService
    {
        ClienteDatos clienteDatos;

        public ClienteService(string cadenaConexion)
        {
            clienteDatos = new ClienteDatos(cadenaConexion);
        }

        public void InsertarCliente(ClienteModel cliente)
        {
            ValidarDatos(cliente);
            clienteDatos.InsertarCliente(cliente);
        }

        private void ValidarDatos(ClienteModel cliente)
        {
            throw new NotImplementedException();
        }

        public ClienteModel ObtenerCliente(int id)
        {
            return clienteDatos.ObtenerClientePorId(id);
        }

        /*public void ModificarCliente(ClienteModel cliente)
        {
            ValidarDatos(cliente);
            clienteDatos.ModificarCliente(cliente);
        }*/

       /* private void ValidarDatos(ClienteModel cliente)
        {
            // Aquí puedes agregar validaciones adicionales según tus requerimientos.
            if (string.IsNullOrWhiteSpace(cliente.Nombre) || string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new Exception("El nombre y el apellido no pueden estar en blanco.");
            }
        }*/
    }
}
