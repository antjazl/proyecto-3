using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccesoDatos;
using Logica;

namespace ServiciosWCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceWCFTaxa" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceWCFTaxa.svc o ServiceWCFTaxa.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceWCFTaxa : IServiceWCFTaxa
    {
        LogicaTaxa logica = new LogicaTaxa();
        Logica_Examen lg = new Logica_Examen();

        public List<taxa> seleccionarTaxa()
        {
            return logica.SeleccionarTaxas();
        }

        public taxa seleccionarTaxaPorId(int idTaxa)
        {
            return logica.SeleccionarTaxaPorId(idTaxa);
        }

        public List<taxapublica> seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(int parametro)
        {

            return lg.seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(parametro);
        }

        public taxacatalogo seleccionarFotoPrincipalPorIdTaxaExamen(int parametro)
        {

            return lg.seleccionarFotoPrincipalPorIdTaxaExamen(parametro);
        }
    }
}
