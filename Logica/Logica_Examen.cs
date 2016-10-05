using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class Logica_Examen
    {
        Datos_Examen dt = new Datos_Examen();

        public List<taxapublica> seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(int parametro)
        {
           
            return dt.seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(parametro);
        }
        public taxacatalogo seleccionarFotoPrincipalPorIdTaxaExamen(int parametro)
        {

            return dt.seleccionarFotoPrincipalPorIdTaxaExamen(parametro);
        }

        public List<taxaamphibia> seleccionarTaxasEspeciesAnfibiosExamen(int parametro, String opcion)
        {
            return dt.seleccionarTaxasEspeciesAnfibiosExamen(parametro,opcion);
        }
    }
}
