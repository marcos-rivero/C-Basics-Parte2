using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BL.Test
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void NombreCompleto_NombreYApellido_RetornaNombreCompleto()
        {
            // Arrange
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Juan";
            cliente1.Apellido = "Perez";
            string esperado = "Juan, Perez";

            // Act
            string valorActual = cliente1.NombreCompleto;

            // Assert
            Assert.AreEqual(esperado, valorActual);
        }

        [TestMethod]
        public void NombreCompleto_Nombre_RetornaNombreCompleto()
        {
            // Arrange
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Juan";
            //cliente1.Apellido = "Perez";
            string esperado = "Juan";

            // Act
            string valorActual = cliente1.NombreCompleto;

            // Assert
            Assert.AreEqual(esperado, valorActual);
        }

        [TestMethod]
        public void NombreCompleto_Apellido_RetornaNombreCompleto()
        {
            // Arrange
            Cliente cliente1 = new Cliente();
            //cliente1.Nombre = "Juan";
            cliente1.Apellido = "Perez";
            string esperado = "Perez";

            // Act
            string valorActual = cliente1.NombreCompleto;

            // Assert
            Assert.AreEqual(esperado, valorActual);
        }

        [TestMethod]
        public void ConstadorDeInstancias_CrearObjetos_RetornaCantidadDeInstancias()
        {
            // Arrange
            Cliente cliente1 = new Cliente();
            //Act
            Cliente.ContadorDeInstancias++;
            Cliente cliente2 = new Cliente(1);
            
            Cliente.ContadorDeInstancias++; 
            Cliente cliente3 = new Cliente();
            
            Cliente.ContadorDeInstancias++;
            
            int valorEsperado = 3;

            // Assert
            Assert.AreEqual(valorEsperado, Cliente.ContadorDeInstancias);
        }


        [TestMethod]
        public void ToString_NombreYApellido_RetornaNombreCompleto()
        {
            // Arrange
            Cliente cliente1 = new Cliente();
            cliente1.Nombre = "Juan";
            cliente1.Apellido = "Perez";
            string esperado = "Juan Perez";

            Direccion direccion = new Direccion(1)
            {
                Calle1 = "Av. Mate de Luna 2300",
                CodigoPostal = "4000"
            };

            Console.WriteLine(direccion.ToString());

            // Act
            string valorActual = cliente1.ToString();

            Console.WriteLine(cliente1.ToString());


            // Assert
            Assert.AreEqual(esperado, valorActual);
        }
    }
}
