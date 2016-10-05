using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
   
    public class Datos_publicacion_enlace
    {
        BiologiaBdRelacionesEntities contexto;
        public Datos_publicacion_enlace()
        {
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public publicacion seleccionarPublicacionesCitaEnlace(long parametro)
        {
            return contexto.publicacions.Include("publicacionenlace").Where(pub => pub.IdPublicacion == parametro).Single();
        }

    }
}
