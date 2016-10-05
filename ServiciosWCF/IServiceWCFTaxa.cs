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
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceWCFTaxa" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceWCFTaxa
    {
        [OperationContract]
        List<taxa> seleccionarTaxa();

        [OperationContract]
        taxa seleccionarTaxaPorId(int idTaxa);

        [OperationContract]
        taxacatalogo seleccionarFotoPrincipalPorIdTaxaExamen(int parametro);

        [OperationContract]
        List<taxapublica> seleccionarPublicacionesSeleccionarPublicacionesPorIdTaxaExamen(int parametro);

    }
}
