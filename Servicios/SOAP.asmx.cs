using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using AccesoDatos;

namespace Servicios
{
    /// <summary>
    /// Descripción breve de SOAP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class SOAP : System.Web.Services.WebService
    {
        LogicaTaxa logica = new LogicaTaxa();
        Logica_Examen lg = new Logica_Examen();
        Logica_Publicacion_Autores lg2 = new Logica_Publicacion_Autores();
        Logica_publicacion_enlace lg3 = new Logica_publicacion_enlace();

        [WebMethod]
        public List<taxa> SeleccionarTaxas()
        {
            return logica.SeleccionarTaxas();
        }

        [WebMethod]
        public taxa SeleccionarTaxaPorId(int idTaxa)
        {
            return logica.SeleccionarTaxaPorId(idTaxa);
        }

        [WebMethod]
        public taxaespecie SeleccionarTaxaEspeciePorId(int idTaxa)
        {
            return logica.SeleccionarTaxaEspeciePorId(idTaxa);
        }



        [WebMethod]
        public List<taxapublica> seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(int parametro)
        {

            return lg.seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(parametro);
        }
        [WebMethod]
        public taxacatalogo seleccionarFotoPrincipalPorIdTaxaExamen(int parametro)
        {

            return lg.seleccionarFotoPrincipalPorIdTaxaExamen(parametro);
        }
        [WebMethod]
        public List<taxaamphibia> seleccionarTaxasEspeciesAnfibiosExamen(int parametro, String opcion)
        {
            return lg.seleccionarTaxasEspeciesAnfibiosExamen(parametro, opcion);
        }

        [WebMethod]
        public taxamultimedia seleccionarTaxaMultimediaPorId(int idtaxa)
        {
            return lg2.seleccionarTaxaMultimediaPorId(idtaxa);
        }

        #region metodos de accion
        [WebMethod]
        public Int64 insertarTaxa(taxa nuevaTaxa)
        {
            return logica.insertarTaxa(nuevaTaxa);
        }
        [WebMethod]
        public bool actualizarTaxa(taxa taxaModificada)
        {
            return logica.actualizarTaxa(taxaModificada);
        }
        [WebMethod]
        public bool eliminarTaxa(taxa taxaEliminado)
        {
            return logica.eliminarTaxa(taxaEliminado.IdTaxa);

        }
        [WebMethod]
        public publicacion seleccionarPublicacionesCitaEnlace(long parametro)
        {
            return lg3.seleccionarPublicacionesCitaEnlace(parametro);
        }

        #endregion

    }
}
