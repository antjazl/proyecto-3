//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    
    public partial class SeleccionarTaxas_Result
    {
        public long IdTaxa { get; set; }
        public string Nombre { get; set; }
        public string NombreCorto { get; set; }
        public bool EnEcuador { get; set; }
        public bool Endemica { get; set; }
        public Nullable<long> IdTaxaPadre { get; set; }
        public long IdCatalogo { get; set; }
        public bool PublicarEnWeb { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<long> IdPublicacionReporte { get; set; }
        public Nullable<int> Ano { get; set; }
    }
}
