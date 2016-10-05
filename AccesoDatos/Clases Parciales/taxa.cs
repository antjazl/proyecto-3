using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AccesoDatos
{
    public partial class taxa
    {
        public taxa()
        {
            this.especies = new List<especie>();
            this.especimen = new List<especiman>();
            this.multimedias = new List<multimedia>();
            this.nombrecomuns = new List<nombrecomun>();
            this.ordenamientotaxas = new List<ordenamientotaxa>();
            this.sinonimoes = new List<sinonimo>();
            this.taxa1 = new List<taxa>();
            this.taxapublicacions = new List<taxapublicacion>();
            this.tipoes = new List<tipo>();
        }

      
        public virtual List<especie> especies { get; set; }
        [XmlIgnore]
        public virtual List<especiman> especimen { get; set; }
       
        public virtual List<multimedia> multimedias { get; set; }
        
        public virtual List<nombrecomun> nombrecomuns { get; set; }
        [XmlIgnore]
        public virtual List<ordenamientotaxa> ordenamientotaxas { get; set; }
        [XmlIgnore]
        public virtual List<sinonimo> sinonimoes { get; set; }

        
        public virtual List<taxapublicacion> taxapublicacions { get; set; }
        [XmlIgnore]
        public virtual List<tipo> tipoes { get; set; }
        [XmlIgnore]
        public virtual List<taxa> taxa1 { get; set; }
        [XmlIgnore]
        public virtual taxa taxa2 { get; set; }
    }
}
