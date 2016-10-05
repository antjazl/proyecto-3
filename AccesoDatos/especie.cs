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
    
    public partial class especie
    {
        public especie()
        {
            this.amphibias = new HashSet<amphibia>();
            this.aves = new HashSet<ave>();
            this.enlacerelacionadoes = new HashSet<enlacerelacionado>();
            this.especiecatalogoes = new HashSet<especiecatalogo>();
            this.mammalias = new HashSet<mammalia>();
            this.reptilias = new HashSet<reptilia>();
        }
    
        public long IdEspecie { get; set; }
        public long IdTaxa { get; set; }
        public string Etimologia { get; set; }
        public string Taxonomia { get; set; }
        public string HabitatBiologia { get; set; }
        public string Dieta { get; set; }
        public string Reproduccion { get; set; }
        public string InformacionAdicional { get; set; }
        public string ComentarioEstatusPoblacional { get; set; }
        public string Distribucion { get; set; }
        public string DistribucionGlobal { get; set; }
        public string ObservacionZonaAltitudinal { get; set; }
        public string RangoAltitudinal { get; set; }
        public string ReferenciaAreaProtegida { get; set; }
        public string Compilador { get; set; }
        public Nullable<System.DateTime> FechaCompilacion { get; set; }
        public string AutoriaCompilador { get; set; }
        public string Editor { get; set; }
        public Nullable<System.DateTime> FechaEdicion { get; set; }
        public string AutoriaEditor { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public string Agradecimiento { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string Categoria { get; set; }
    
       
    }
}
