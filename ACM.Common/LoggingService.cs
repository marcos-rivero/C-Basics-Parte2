using System;
using System.Collections.Generic;

namespace ACM.Common
{
    public static class LoggingService
    {
        //public static void EscribirEnUnArchivo(List<Object> listaDeObjetos){
        public static void EscribirEnUnArchivo(List<ILoggable> listaDeObjetos) {
            foreach (var objeto in listaDeObjetos) {
                Console.WriteLine(objeto.ToString());
         }
        }
    }
}
