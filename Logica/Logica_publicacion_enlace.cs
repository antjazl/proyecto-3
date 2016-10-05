using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class Logica_publicacion_enlace
    {
        Datos_publicacion_enlace dt = new Datos_publicacion_enlace();

        public publicacion seleccionarPublicacionesCitaEnlace(long parametro)
        {
            return dt.seleccionarPublicacionesCitaEnlace(parametro);
        }
    }
}
