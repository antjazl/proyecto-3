using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Datos
{
    public class Datos_Examen
    {
        BiologiaBdRelacionesEntities contexto;

        public Datos_Examen()
        {
            contexto = new BiologiaBdRelacionesEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<taxapublica> seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(int parametro)
        {
            List<taxapublica> ls = new List<taxapublica>();
            var consultaTaxPublicacion = from txa in contexto.taxas
                                         join taxapu in contexto.taxapublicacions on txa.IdTaxa equals taxapu.IdTaxa
                                         join publ in contexto.publicacions on taxapu.IdPublicacion equals publ.IdPublicacion
                                         where txa.IdTaxa == parametro
                                         select new taxapublica
                                         {
                                             IdTaxa = txa.IdTaxa,
                                             Nombre = txa.Nombre,
                                             IdPublicacion = publ.IdPublicacion,
                                             Titulo = publ.Titulo,
                                             TituloSecundario = publ.TituloSecundario,
                                             Editor = publ.Editor,
                                             Editorial = publ.Editorial,
                                             Volumen = publ.Volumen,
                                             Numero = publ.Numero,
                                             Cita = publ.Cita
                                        };


            ls = consultaTaxPublicacion.ToList();
            return ls;
        }

        public taxacatalogo seleccionarFotoPrincipalPorIdTaxaExamen(int parametro)
        {
            var consultaTaxCatalogo = from txa in contexto.taxas
                                         join taxamul in contexto.multimedias on txa.IdTaxa equals taxamul.IdTaxa
                                         join cata in contexto.catalogoes on taxamul.IdCatalogo equals cata.IdCatalogo
                                         where (txa.IdTaxa == parametro) && (cata.IdCatalogo==1122)
                                         select new taxacatalogo
                                         {
                                             IdTaxa = txa.IdTaxa,
                                             Nombre = txa.Nombre,
                                             NombreArchivo = taxamul.NombreArchivo,
                                             Descripcion = cata.Descripcion,
                                             DescrpcionC = taxamul.Descripcion
                                         };

            taxacatalogo txaTaxaCat = consultaTaxCatalogo.SingleOrDefault();
            return txaTaxaCat;
        }

        public List<taxaamphibia> seleccionarTaxasEspeciesAnfibiosExamen(int parametro, String opcion)
        {
            List<taxaamphibia> ls = new List<taxaamphibia>();
            var consultaTaxAmphibia = (IQueryable<taxaamphibia>)null;

            if (opcion.Equals("si"))
            {
                 consultaTaxAmphibia = from txa in contexto.taxas
                                             join taxnombrec in contexto.nombrecomuns on txa.IdTaxa equals taxnombrec.IdTaxa
                                             join espe in contexto.especies on txa.IdTaxa equals espe.IdTaxa
                                             join amp in contexto.amphibias on espe.IdEspecie equals amp.IdEspecie
                                             where txa.IdTaxa == parametro
                                             select new taxaamphibia
                                             {
                                                 IdTaxa = txa.IdTaxa,
                                                 IdAmphibia = amp.IdAmphibia,
                                                 Sinonimia = amp.Sinonimia,
                                                 Nombre = txa.Nombre
                                             };
                ls = consultaTaxAmphibia.ToList();
            }
            else if(opcion.Equals("no")){
                consultaTaxAmphibia = from txa in contexto.taxas
                                             join taxnombrec in contexto.nombrecomuns on txa.IdTaxa equals taxnombrec.IdTaxa
                                             join espe in contexto.especies on txa.IdTaxa equals espe.IdTaxa
                                             join amp in contexto.amphibias on espe.IdEspecie equals amp.IdEspecie
                                             where txa.IdTaxa == parametro
                                             select new taxaamphibia
                                             {
                                                 IdTaxa = txa.IdTaxa,
                                                 IdAmphibia = amp.IdAmphibia,
                                                 Sinonimia = amp.Sinonimia
                                             };
                ls = consultaTaxAmphibia.ToList();

            }
            return ls;
        }
    }
}
