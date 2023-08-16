using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.Common.Test
{
    [TestClass]
    public class ManejadorDeStringTest
    {
        [TestMethod]
        public void InsertarSpacios_String_RetornarStringConEspacios()
        {
            var miCadena = "HolaMundo";
            var esperado = "Hola Mundo";

            //var actual = ManejadorDeString.InsertarEspacios(miCadena);
            var actual = miCadena.InsertarEspacios();

            Assert.AreEqual(esperado, actual);
        }
    }
}
