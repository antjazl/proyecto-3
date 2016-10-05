using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;

namespace Logica
{
    public class LogicaTaxa
    {
        DatosTaxa datos = new DatosTaxa();

        public List<taxa> SeleccionarTaxas()
        {
            return datos.SeleccionarTaxas();
        }

        public taxa SeleccionarTaxaPorId(int idTaxa)
        {
            return datos.SeleccionarTaxaPorId(idTaxa);
        }

        public taxaespecie SeleccionarTaxaEspeciePorId(int idTaxa)
        {
            return datos.SeleccionarTaxaEspeciePorId(idTaxa);
        }

        #region metodos de accion
        public Int64 insertarTaxa(taxa nuevaTaxa)
        {
            return datos.insertarTaxa(nuevaTaxa);
        }

        public bool actualizarTaxa(taxa taxaModificada)
        {
            return datos.actualizarTaxa(taxaModificada);
        }

        public bool eliminarTaxa(long idTaxa)
        {
            return datos.eliminarTaxa(idTaxa);

        }

        #endregion


    }
}
