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
    using System.Xml.Serialization;
    
    public partial class amphibia
    {
        public long IdAmphibia { get; set; }
        public long IdEspecie { get; set; }
        public string Sinonimia { get; set; }
        public string Identificacion { get; set; }
        public string Descripcion { get; set; }
        public string ColorEnVida { get; set; }
        public string Diagnosis { get; set; }
        public string Morfometria { get; set; }
        public string SVLMacho { get; set; }
        public string ReferenciaSVLMacho { get; set; }
        public string SVLHembra { get; set; }
        public string ReferenciaSVLHembra { get; set; }
        public string Comportamiento { get; set; }
        public string Larva { get; set; }
        public string Canto { get; set; }
        public string ColorEnPreservacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        
    }
}