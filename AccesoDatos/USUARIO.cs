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
    
    public partial class USUARIO
    {
        public long IDUSUARIO { get; set; }
        public Nullable<long> IDPERFIL { get; set; }
        public string USERUSUARIO { get; set; }
        public string PASSWORDUSUARIO { get; set; }
        public string RETRYPASSWORDUSUARIO { get; set; }
        public string NOMBREUSUARIO { get; set; }
        public string APELLIDOUSUARIO { get; set; }
        public string DIRECCIONUSUARIO { get; set; }
        public string TELEFONOUSUARIO { get; set; }
        public string EMAILUSUARIO { get; set; }
        public Nullable<System.DateTime> FECHAMODIFICACION { get; set; }
        public string USUARIOMODIFICACION { get; set; }
    
        public virtual PERFIL PERFIL { get; set; }
    }
}
