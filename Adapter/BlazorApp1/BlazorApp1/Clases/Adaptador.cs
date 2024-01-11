using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Clases
{
    public class Adaptador : INuevaImpresora
    {
        private readonly IAntiguaImpresora _antiguaImpresora;

        public Adaptador(IAntiguaImpresora antiguaImpresora)
        {
            _antiguaImpresora = antiguaImpresora;
        }

        public string Imprimir()
        {
            return _antiguaImpresora.ImprimirConFormatoAntiguo();
        }
    }

}
