using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Singleton
{
    public class PatronSingleton
    {
        private static PatronSingleton Instancia;
        public string mensaje;
        protected PatronSingleton() {
            mensaje = "hola mundo";
        }

        public static PatronSingleton IntanciaSingleton {
            get {

                if (Instancia == null)
                    Instancia = new PatronSingleton();

                return Instancia;
            }
        }
    }
}
