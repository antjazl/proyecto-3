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
    
    public partial class nombrecomun
    {
        public nombrecomun()
        {
            this.nombrecomuncatalogoes = new List<nombrecomuncatalogo>();
            this.nombrecomunpublicacions = new List<nombrecomunpublicacion>();
        }
    
        public long IdNombreComun { get; set; }
        public long IdTaxa { get; set; }
        public string Nombre { get; set; }
        public string Comentario { get; set; }
        public bool Principal { get; set; }
        public Nullable<int> Orden { get; set; }
        public Nullable<long> IdPublicacion { get; set; }
        public Nullable<bool> Borrado { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        [XmlIgnore]
        public virtual publicacion publicacion { get; set; }
        [XmlIgnore]
        public virtual taxa taxa { get; set; }
        [XmlIgnore]
        public virtual List<nombrecomuncatalogo> nombrecomuncatalogoes { get; set; }
        [XmlIgnore]
        public virtual List<nombrecomunpublicacion> nombrecomunpublicacions { get; set; }
    }
}