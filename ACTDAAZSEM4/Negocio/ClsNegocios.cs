using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACTDAAZSEM4.Entidades;

namespace ACTDAAZSEM4.Negocio
{
    public class ClsNegocios
    {
        public int Contadorletras(Actsem4 entidad){
            return entidad.Texto.Length;

        }
    }
}