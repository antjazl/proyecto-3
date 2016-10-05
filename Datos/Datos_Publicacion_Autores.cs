using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Publicacion_Autores
    {
        BiologiaBdRelacionesEntities contexto;

        public Datos_Publicacion_Autores(){
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public taxamultimedia seleccionarTaxaMultimediaPorId(int idtaxa)
        {
            var consultaTaxEsp = from txaTaxa in contexto.taxas
                                 join mul in contexto.multimedias on txaTaxa.IdTaxa equals mul.IdTaxa
                                 where (txaTaxa.IdTaxa == idtaxa)&&(mul.IdCatalogo==1122)
                                 select new taxamultimedia
                                 {
                                     IdTaxa = txaTaxa.IdTaxa,
                                     IdMultimedia = mul.IdMultimedia,
                                     Titulo = mul.Titulo,
                                     NombreArchivo = mul.NombreArchivo,
                                     Descripcion = mul.Descripcion,
                                     FechaModificacion = mul.FechaModificacion,
                                     UsuarioModificacion = mul.UsuarioModificacion
                                 };
            taxamultimedia txaTaxaMulti = consultaTaxEsp.SingleOrDefault();
            return txaTaxaMulti;
        }





    }
}
