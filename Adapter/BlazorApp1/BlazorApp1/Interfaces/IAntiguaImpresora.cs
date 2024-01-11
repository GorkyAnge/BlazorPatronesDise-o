using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Interfaces
{
    public interface IAntiguaImpresora
    {
        string ImprimirConFormatoAntiguo();
        void setearMensaje(string m);
    }
}
