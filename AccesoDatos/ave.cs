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
    using System.Collections.Generic;
    
    public partial class ave
    {
        public long IdAves { get; set; }
        public long IdEspecie { get; set; }
        public string Identificacion { get; set; }
        public bool CasiEndemica { get; set; }
        public string TaxonomiaRidgelyGreenfield { get; set; }
        public string ComentarioTaxonomia { get; set; }
        public string Movimiento { get; set; }
        public string DistribucionSubespecies { get; set; }
        public string NotaPresenciaProvincia { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual especie especie { get; set; }
    }
}
