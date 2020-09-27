using System.Xml;
using System.Xml.Serialization;

namespace TestTask.DataClasses
{
    [XmlRoot("yml_catalog")]
    public class Yml_catalog
    {
        [XmlElement("shop")]
        public Shop shop { get; set; }
    }
}
