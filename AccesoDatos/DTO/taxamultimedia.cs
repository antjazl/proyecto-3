using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class taxamultimedia
    {
        public long IdMultimedia { get; set; }
        public string Titulo { get; set; }
        public string NombreArchivo { get; set; }
        public long IdTaxa { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
