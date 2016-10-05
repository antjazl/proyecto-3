using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AccesoDatos
{
    public partial class especie
    {
        [XmlIgnore]
        public virtual ICollection<amphibia> amphibias { get; set; }
        [XmlIgnore]
        public virtual ICollection<ave> aves { get; set; }
        [XmlIgnore]
        public virtual ICollection<enlacerelacionado> enlacerelacionadoes { get; set; }
        [XmlIgnore]
        public virtual taxa taxa { get; set; }
        [XmlIgnore]
        public virtual ICollection<especiecatalogo> especiecatalogoes { get; set; }
        [XmlIgnore]
        public virtual ICollection<mammalia> mammalias { get; set; }
        [XmlIgnore]
        public virtual ICollection<reptilia> reptilias { get; set; }
    }
}
