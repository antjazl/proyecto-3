using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class DatosTaxa
    {
        BiologiaBdRelacionesEntities contexto;

        public DatosTaxa()
        {
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<taxa> SeleccionarTaxas()
        {
            var consultaRes = from lstTaxas in contexto.taxas
                              select lstTaxas;
            List<taxa> LstTaxasRes = consultaRes.ToList();
            return LstTaxasRes;
        }

        public taxa SeleccionarTaxaPorId(int idTaxa)
        {
            var consultaId = from txaTaxa in contexto.taxas
                             where txaTaxa.IdTaxa == idTaxa
                             join espeEspecie in contexto.especies on txaTaxa.IdTaxa equals espeEspecie.IdTaxa
                             join ampAmphibia in contexto.amphibias on espeEspecie.IdEspecie equals ampAmphibia.IdEspecie
                             select txaTaxa;
            taxa txaTaxaRes = consultaId.SingleOrDefault();
            return txaTaxaRes;
        }

        public taxaespecie SeleccionarTaxaEspeciePorId(int idTaxa)
        {
            var consultaTaxEsp = from txaTaxaEspe in contexto.taxas
                                 join esp in contexto.especies on txaTaxaEspe.IdTaxa equals esp.IdTaxa
                                 where txaTaxaEspe.IdTaxa == idTaxa
                                 select new taxaespecie
                                 {
                                     IdTaxa = txaTaxaEspe.IdTaxa,
                                     Nombre = txaTaxaEspe.Nombre,
                                     HabitatBiologia = esp.HabitatBiologia,
                                     ComentarioEstatusPoblacional = esp.ComentarioEstatusPoblacional
                                 };
            taxaespecie txaTaxaEspeRes = consultaTaxEsp.SingleOrDefault();
            return txaTaxaEspeRes;

        }

        #region Metodos de accion
        public Int64 insertarTaxa(taxa  nuevaTaxa)
        {
            contexto.taxas.Add(nuevaTaxa);
            contexto.SaveChanges();
            return nuevaTaxa.IdTaxa;
        }

        public bool actualizarTaxa(taxa taxaModificada)
        {
            taxa txaTaxa = contexto.taxas.Where(t => t.IdTaxa == taxaModificada.IdTaxa).SingleOrDefault();
            if (txaTaxa != null)
            {
                txaTaxa.Nombre = taxaModificada.Nombre;
                txaTaxa.NombreCorto = taxaModificada.NombreCorto;
                txaTaxa.EnEcuador = taxaModificada.EnEcuador;
                contexto.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool eliminarTaxa(long idTaxa)
        {
            taxa txaTaxa = contexto.taxas.Where(t => t.IdTaxa == idTaxa).SingleOrDefault();
            if (txaTaxa != null)
            {
                contexto.taxas.Remove(txaTaxa);
                contexto.SaveChanges();
                return true;
            }
            else
                return false;
        }






        #endregion

    }
}
