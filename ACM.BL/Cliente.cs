using ACM.Common;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Cliente : EntidadBase, ILoggable
    {
        public Cliente() { }
        public Cliente(int clienteId) { 
            ClientId = clienteId;
            Direccion = new List<Direccion>();
        }
        private string apellido;
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Nombre { get; set; }
        public List<Direccion> Direccion { get; set; }

        public int ClientId { get; private set; }

        public string Email { get; set; }

        public string NombreCompleto
        {
            get {
                string nombreCompleto = Nombre;
                if (!string.IsNullOrWhiteSpace(Apellido))
                {
                    if (!string.IsNullOrWhiteSpace(nombreCompleto))
                    {
                        nombreCompleto += ", ";
                    }
                    nombreCompleto += Apellido;
                }
                return nombreCompleto;
            }
        }
        public static int ContadorDeInstancias { get; set; }     

        /// <summary>
        /// Valida si el nombre o el email no existen.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Validar() {
            bool isValid = true;
            if(string.IsNullOrWhiteSpace(Nombre) || string.IsNullOrWhiteSpace(Email))
            {
                isValid = false;
            }

            return isValid;
        }


        public override string ToString()
        {
            //return base.ToString();
            return $"{Nombre} {Apellido}";
        }

        public string Log() => $"{ClientId}: {NombreCompleto} Email: {Email} Status: {EstadoDeLaEntidad}";
    }
}
