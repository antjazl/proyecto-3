using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class Logica_Publicacion_Autores
    {
        Datos_Publicacion_Autores dt = new Datos_Publicacion_Autores();

        public taxamultimedia seleccionarTaxaMultimediaPorId(int idtaxa)
        {
            return dt.seleccionarTaxaMultimediaPorId(idtaxa);
        }


    }
}
