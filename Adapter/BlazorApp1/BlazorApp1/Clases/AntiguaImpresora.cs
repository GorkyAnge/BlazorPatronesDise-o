using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Clases
{
    public class AntiguaImpresora : IAntiguaImpresora

    {
        public string mensaje;
        public string ImprimirConFormatoAntiguo()
        {
            return mensaje ;
        }

        public void setearMensaje(string mensajeS)
        {
            mensaje = mensajeS;

            if (string.IsNullOrEmpty(mensaje) ) {
                mensaje= "Imprimiendo con el formato antiguo.";
            }

        }
    }
}
    