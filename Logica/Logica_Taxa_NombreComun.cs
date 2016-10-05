using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AccesoDatos;

namespace Logica
{
    public class Logica_Taxa_NombreComun
    {
        Datos_Taxa_NombreComun dtsTxaNombreCom = new Datos_Taxa_NombreComun();

        public List<taxa> seleccionarTaxa()
        {
            return dtsTxaNombreCom.seleccionarTaxa();
        }

        public taxa seleccionarTaxaPorId(int idTaxa)
        {
            return dtsTxaNombreCom.seleccionarTaxaPorId(idTaxa);
        }

        public taxa seleccionarTaxaNombreComunPorIdTaxa(int idTaxa)
        {
            return dtsTxaNombreCom.seleccionarTaxaNombreComunPorIdTaxa(idTaxa);
        }
    }
}
