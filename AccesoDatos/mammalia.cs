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
    
    public partial class mammalia
    {
        public long IdMammalia { get; set; }
        public long IdEspecie { get; set; }
        public string Descripcion { get; set; }
        public string Diagnosis { get; set; }
        public string Morfometria { get; set; }
        public string Movimientos { get; set; }
        public string ListaRojaCriterios { get; set; }
        public string Sinonimia { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual especie especie { get; set; }
    }
}
