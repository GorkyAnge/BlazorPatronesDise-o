using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorApp1.Interfaces;

namespace BlazorApp1.Clases
{
    // Cliente que utiliza la nueva interfaz
    public class Cliente
    {
        public string RealizarImpresion(INuevaImpresora nuevaImpresora)
        {
            return nuevaImpresora.Imprimir();
        }
    }
}
