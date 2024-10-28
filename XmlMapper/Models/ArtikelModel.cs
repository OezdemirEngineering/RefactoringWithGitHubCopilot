using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlMapper.Models
{
    [XmlRoot("Artikel")]
    public class ArtikelModel
    {
        [XmlElement("Attribute")]
        public AttributeModel Attribute { get; set; }

        [XmlArray("Stückliste")]
        [XmlArrayItem("Position")]
        public List<PositionModel> Stückliste { get; set; }
    }
}
