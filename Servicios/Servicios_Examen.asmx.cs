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
    /// Descripción breve de Servicios_Examen
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Servicios_Examen : System.Web.Services.WebService
    {

        Logica_Examen lg = new Logica_Examen();

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
    }
}
