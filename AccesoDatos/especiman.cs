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
    
    public partial class especiman
    {
        public especiman()
        {
            this.ImagenEspecimen = new List<ImagenEspeciman>();
        }
    
        public long IdEspecimen { get; set; }
        public string Qcaz { get; set; }
        public string SC { get; set; }
        public Nullable<long> IdTaxaWeb { get; set; }
        public string Orden { get; set; }
        public string Familia { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public string TaxaCuestion { get; set; }
        public Nullable<int> AnoColeccion { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public Nullable<decimal> LatGeo { get; set; }
        public Nullable<decimal> LonGeo { get; set; }
        public Nullable<bool> Tejidos { get; set; }
        public string Tipo { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string FuenteCoordenadas { get; set; }
        public Nullable<bool> QcazSN { get; set; }
        public string FuenteRegistro { get; set; }
        public Nullable<long> IdPublicacion { get; set; }
        public string ObservacionesGeoreferenciacion { get; set; }
        public string ObservacionesGenerales { get; set; }
        public Nullable<bool> Nueva { get; set; }
    
        [XmlIgnore]
        public virtual publicacion publicacion { get; set; }
        [XmlIgnore]
        public virtual taxa taxa { get; set; }
        [XmlIgnore]
        public virtual List<ImagenEspeciman> ImagenEspecimen { get; set; }
    }
}
