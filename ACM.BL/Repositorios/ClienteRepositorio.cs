using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Repositorios
{
    public class ClienteRepositorio
    {
        public bool Guardar() { return true; }
        public Cliente RetornaCliente(int clienteId) {
            Cliente cliente = new Cliente(1) { 
                Nombre = "Jose",
                Apellido = "Perez",
                Email = "Jose.Perez@unsta.edu.ar"
            };

            Direccion direccion = new Direccion(1) {
                Calle1 = "Av. Mate de Luna 2300",
                CodigoPostal = "4000"
            };

            cliente.Direccion.Add(direccion);

            return cliente;
        }

        public List<Cliente> Retornar() { return new List<Cliente>(); }
    }
}
