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
    /// Descripción breve de ServicioWebTaxaNombreComun
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebTaxaNombreComun : System.Web.Services.WebService
    {
        Logica_Taxa_NombreComun lgcTxaNomComu = new Logica_Taxa_NombreComun();
        [WebMethod]
        public List<taxa> seleccionarTaxa()
        {
            return lgcTxaNomComu.seleccionarTaxa();
        }
        [WebMethod]
        public taxa seleccionarTaxaPorId(int idTaxa)
        {
            return lgcTxaNomComu.seleccionarTaxaPorId(idTaxa);
        }
        [WebMethod]
        public taxa seleccionarTaxaNombreComunPorIdTaxa(int idTaxa)
        {
            return lgcTxaNomComu.seleccionarTaxaNombreComunPorIdTaxa(idTaxa);
        }
    }
}
