using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AccesoDatos
{
    public partial class amphibia
    {
        [XmlIgnore]
        public virtual especie especie { get; set; }
    }
}
