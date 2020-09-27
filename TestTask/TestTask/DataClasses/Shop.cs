using System.Xml;
using System.Xml.Serialization;

namespace TestTask.DataClasses
{
    public class Shop
    {
        [XmlElement("offers")]
        public Offers offers { get; set; }
    }
}
