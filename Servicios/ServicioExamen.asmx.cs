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
    /// Descripción breve de ServicioTaxaMultimedia
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioTaxaMultimedia : System.Web.Services.WebService
    {
        Logica_Publicacion_Autores lg = new Logica_Publicacion_Autores();

        [WebMethod]
        public taxamultimedia seleccionarTaxaMultimediaPorId(int idtaxa)
        {
            return lg.seleccionarTaxaMultimediaPorId(idtaxa);
        }

    }
}
