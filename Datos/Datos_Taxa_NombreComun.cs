using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Taxa_NombreComun
    {
        BiologiaBdRelacionesEntities contexto;
        public Datos_Taxa_NombreComun()
        {
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<taxa> seleccionarTaxa()
        {
            return contexto.taxas.ToList();
        }

        public taxa seleccionarTaxaPorId(int idTaxa)
        {
            return contexto.taxas.Where(txa => txa.IdTaxa == idTaxa).SingleOrDefault();
        }

        public taxa seleccionarTaxaNombreComunPorIdTaxa(int idTaxa)
        {
            return contexto.taxas.Include("nombrecomuns").Where(txa => txa.IdTaxa == idTaxa).SingleOrDefault();
        }




    }
}
