using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ACM.Common.Test
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void EscribirEnArchivo_Objetos_EscribirEnConsola()
        {
            //var listadoDeObjetos = new List<Object>();
            var listadoDeObjetos = new List<ILoggable>();
            
            var cliente = new Cliente(1)
            {
                Nombre = "Fabian",
                Email = "Fabian@unsta.edu.ar"
            };

            listadoDeObjetos.Add(cliente);

            var direccion = new Direccion(1)
            {
                Calle1 = "Av. Peron 2400",
                CodigoPostal = "4000"
            };

            listadoDeObjetos.Add(direccion);

            LoggingService.EscribirEnUnArchivo(listadoDeObjetos);
        }
    }
}
