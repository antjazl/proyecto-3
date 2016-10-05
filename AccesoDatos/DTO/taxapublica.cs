using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class taxapublica
    {

        public long IdTaxa { get; set; }
        public string Nombre { get; set; }
        public long IdPublicacion { get; set; }
        public string Titulo { get; set; }
        public string TituloSecundario { get; set; }
        public bool Editor { get; set; }
        public string Editorial { get; set; }
        public string Volumen { get; set; }
        public string Numero { get; set; }
        public string Cita { get; set; }
    }
}
